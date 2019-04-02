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
    public partial class IndividualStudentResultForm : Form
    {
        public IndividualStudentResultForm()
        {
            InitializeComponent();
        }

        private void IndividualStudentResultForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Connection.buildconnection();



            string queryassessment = "select Id, RegistrationNumber from Student";
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

        private void btn_displayResult_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            SqlConnection conn = Connection.buildconnection();
            String cmd = "SELECT AssessmentComponentId, RubricMeasurementId FROM [ProjectB].[dbo].[StudentResult] Where StudentId = @sid";
            SqlCommand command = new SqlCommand(cmd, conn);
            // Add the parameters if required
            command.Parameters.AddWithValue("@sid", Convert.ToInt32(cb_Student.SelectedValue));
            int studentid = Convert.ToInt32(cb_Student.SelectedValue);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            int componentmarks, studentrubriclevel, maxrubriclevel, rubricid;
            float obtainedmarks;
            dt.Load(reader);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = Connection.getAssessmentComponentNamebyId(Convert.ToInt32(dt.Rows[i].ItemArray[0]));
                rubricid = Connection.getRubricIdbyAssessmentComponentId(Convert.ToInt32(dt.Rows[i].ItemArray[0]));
                dataGridView1.Rows[i].Cells[1].Value = Connection.getRubricNamebyId(rubricid);
                componentmarks = Connection.getAssessmentComponentTotalMarksbyid(Convert.ToInt32(dt.Rows[i].ItemArray[0]));
                dataGridView1.Rows[i].Cells[2].Value = componentmarks;
                studentrubriclevel = Connection.getMeasurementLevelbyRubricLevelId(Convert.ToInt32(dt.Rows[i].ItemArray[1]));
                dataGridView1.Rows[i].Cells[3].Value = studentrubriclevel;
                maxrubriclevel = Connection.getMaximumRubricLevelbyRubricId(rubricid);
                obtainedmarks = (float)((((float)studentrubriclevel) / ((float)maxrubriclevel)) * ((float)componentmarks));
                dataGridView1.Rows[i].Cells[4].Value = obtainedmarks;

            }

        }
    }
}
