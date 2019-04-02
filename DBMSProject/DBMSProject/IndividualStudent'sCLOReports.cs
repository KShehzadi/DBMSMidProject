using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public partial class IndividualStudent_sCLOReports : Form
    {
        public IndividualStudent_sCLOReports()
        {
            InitializeComponent();
        }

        private void IndividualStudent_sCLOReports_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Connection.buildconnection();



            string queryassessment = "SELECT Id, RegistrationNumber FROM Student";
            SqlDataAdapter da = new SqlDataAdapter(queryassessment, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "student");
            cb_Student.DisplayMember = "RegistrationNumber";
            cb_Student.ValueMember = "Id";
            cb_Student.DataSource = ds.Tables["student"];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btn_CLOReports_Click(object sender, EventArgs e)
        {
            DataRowView drv = cb_Student.SelectedItem as DataRowView;
            SqlConnection conn = Connection.buildconnection();
            int studentid = Convert.ToInt32(drv.Row["Id"]);
            string queryclo = "SELECT Id, Name FROM CLO ";
            SqlCommand Commandclo = new SqlCommand(queryclo, conn);
            SqlDataReader readerClo = Commandclo.ExecuteReader();
            DataTable datatableclo = new DataTable();
            datatableclo.Load(readerClo);
            int CLOid;
            int RubricId;
            int assessmentcomponentid;
            for(int i = 0; i < datatableclo.Rows.Count;i++)
            {
                CLOid = Convert.ToInt32(datatableclo.Rows[i].ItemArray[0]);
                conn = Connection.buildconnection();
                string queryrubric = "SELECT Id, Details FROM Rubric WHERE CloId = @cloid";
                SqlCommand Commandrubric = new SqlCommand(queryrubric, conn);
                Commandrubric.Parameters.AddWithValue("@cloid", CLOid);
                SqlDataReader readerRubric = Commandrubric.ExecuteReader();
                DataTable datatablerubric = new DataTable();
                datatablerubric.Load(readerRubric);
                
                for (int j = 0; j < datatablerubric.Rows.Count; j++)
                {
                    RubricId = Convert.ToInt32(datatablerubric.Rows[j].ItemArray[0]);
                    conn = Connection.buildconnection();
                    string queryassessment = "SELECT Id, Name FROM AssessmentComponent WHERE RubricId = @rid";
                    SqlCommand Commandassessment = new SqlCommand(queryassessment, conn);
                    Commandassessment.Parameters.AddWithValue("@rid", RubricId);
                    SqlDataReader readerassessment = Commandassessment.ExecuteReader();
                    DataTable datatableassessment = new DataTable();
                    datatableassessment.Load(readerassessment);
                    for (int k = 0; k < datatableassessment.Rows.Count; k++)
                    {
                        assessmentcomponentid = Convert.ToInt32(datatableassessment.Rows[k].ItemArray[0]);
                        string assessmentname = Connection.getAssessmentComponentNamebyId(assessmentcomponentid);
                        string rubricname = Connection.getRubricNamebyId(RubricId);
                        int componentmarks = Connection.getAssessmentComponentTotalMarksbyid(assessmentcomponentid);
                        int studentrubriclevel = Connection.getMeasurementLevelbyRubricLevelId(Connection.getRubricMeasurementIdbyAssessmentComponentIdAndStudentIdFromStudentResult(studentid, assessmentcomponentid));
                        int maxrubriclevel = Connection.getMaximumRubricLevelbyRubricId(RubricId);
                        float obtainedmarks = (float)((((float)studentrubriclevel) / ((float)maxrubriclevel)) * ((float)componentmarks));
                    }



                }
            }

        }
    }
}
