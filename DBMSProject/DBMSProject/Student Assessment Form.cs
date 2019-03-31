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
    public partial class Student_Assessment_Form : Form
    {
        public Student_Assessment_Form()
        {
            InitializeComponent();
        }

        private void Student_Assessment_Form_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Connection.buildconnection();



            string queryassessment = "select Id, Name from AssessmentComponent";
            SqlDataAdapter da = new SqlDataAdapter(queryassessment, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "assessmentComponent");
            cb_Assessment.DisplayMember = "Name";
            cb_Assessment.ValueMember = "Id";
            cb_Assessment.DataSource = ds.Tables["assessmentComponent"];

            string querydate = "select Id, AttendanceDate from ClassAttendance";
            SqlDataAdapter da1 = new SqlDataAdapter(querydate, conn);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "classAttendance");
            cb_Date.DisplayMember = "AttendanceDate";
            cb_Date.ValueMember = "Id";
            cb_Date.DataSource = ds1.Tables["classAttendance"];

            btn_Update.Hide();
            dataGridView1.DataSource = null;
            label3.Text = "Select Rubric";
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            btn_filter.Show();
            btn_GetStudent.Show();
            btn_MarkAssessment.Show();
            SqlConnection conn = Connection.buildconnection();
            string queryassessment = "select Id, Name from AssessmentComponent";
            SqlDataAdapter da = new SqlDataAdapter(queryassessment, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "assessmentComponent");
            cb_Assessment.DisplayMember = "Name";
            cb_Assessment.ValueMember = "Id";
            cb_Assessment.DataSource = ds.Tables["assessmentComponent"];

            string querydate = "select Id, AttendanceDate from ClassAttendance";
            SqlDataAdapter da1 = new SqlDataAdapter(querydate, conn);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "classAttendance");
            cb_Date.DisplayMember = "AttendanceDate";
            cb_Date.ValueMember = "Id";
            cb_Date.DataSource = ds1.Tables["classAttendance"];

            btn_Update.Hide();
            dataGridView1.DataSource = null;
            label3.Text = "Select Rubric";
        }

        private void btn_GetStudent_Click(object sender, EventArgs e)
        {

            
            this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;

            SqlConnection conn = Connection.buildconnection();
            String cmd = "SELECT RegistrationNumber FROM [ProjectB].[dbo].[Student]";
            SqlCommand command = new SqlCommand(cmd, conn);
            // Add the parameters if required
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(reader);
            dataGridView1.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {


                dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i].ItemArray[0];
            }

            DataRowView drv = cb_rubriclevel.SelectedItem as DataRowView;
            int classid = Convert.ToInt32(drv.Row["RubricId"]);
            string query1 = "select Id, MeasurementLevel from RubricLevel Where RubricId = @id";
            

            SqlDataAdapter da1 = new SqlDataAdapter(query1, conn);
            da1.SelectCommand.Parameters.AddWithValue("@id", classid);

            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "MeasurementLevel");

            ((DataGridViewComboBoxColumn)dataGridView1.Columns[1]).DataSource = ds1.Tables["MeasurementLevel"];
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[1]).DisplayMember = "MeasurementLevel";
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[1]).ValueMember = "Id";

            btn_GetStudent.Hide();
            btn_filter.Hide();

        }

        private void cb_Assessment_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataRowView drv = cb_Assessment.SelectedItem as DataRowView;
            int classid = Convert.ToInt32(drv.Row["Id"]);
            SqlConnection conn = Connection.buildconnection();
            string queryassessment = "select RubricId from AssessmentComponent Where Id = @id ";
            SqlDataAdapter da = new SqlDataAdapter(queryassessment, conn);
            da.SelectCommand.Parameters.AddWithValue("@id", classid);
            DataSet ds = new DataSet();
            da.Fill(ds, "assessmentComponent");
            cb_rubriclevel.DisplayMember = "RubricId";
            cb_rubriclevel.ValueMember = "RubricId";
            cb_rubriclevel.DataSource = ds.Tables["assessmentComponent"];
            for(int i = 0; i < ds.Tables[0].Rows.Count;i++)
            {
                
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
