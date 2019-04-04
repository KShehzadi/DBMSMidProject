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
        public static int indexassessmentcomponentid = 0;
        public static int indexrubricid = 0;
        public static int indexrubriclevelid = 0;
        public static int indexStudentid = 0;
        public Student_Assessment_Form()
        {
            InitializeComponent();
        }

        private void Student_Assessment_Form_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Connection.buildconnection();



            string queryassessment = "select Id, Title from Assessment";
            SqlDataAdapter da = new SqlDataAdapter(queryassessment, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "assessment");
            cb_Assessment.DisplayMember = "Title";
            cb_Assessment.ValueMember = "Id";
            cb_Assessment.DataSource = ds.Tables["assessment"];

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
            this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
            label1.Show();
            label1.Show();
            label3.Show();
            label4.Show();
            cb_Assessment.Show();
            cb_AssessmentComponent.Show();
            cb_Date.Show();
            cb_rubriclevel.Show();

            ((DataGridViewComboBoxColumn)dataGridView1.Columns[1]).ReadOnly = false;
            btn_filter.Show();
            btn_GetStudent.Show();
            btn_MarkAssessment.Show();
            SqlConnection conn = Connection.buildconnection();
            string queryassessment = "select Id, Name from AssessmentComponent";
            SqlDataAdapter da = new SqlDataAdapter(queryassessment, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "assessmentComponent");
            cb_AssessmentComponent.DisplayMember = "Name";
            cb_AssessmentComponent.ValueMember = "Id";
            cb_AssessmentComponent.DataSource = ds.Tables["assessmentComponent"];

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
            if(cb_Assessment.Text == "" || cb_AssessmentComponent.Text == ""|| cb_Date.Text == "" || cb_rubriclevel.Text =="")
            {
                MessageBox.Show("Warning: Empty Fields!");
                return;
            }

            this.dataGridView1.Columns[1].Visible = true;

            this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
            label1.Show();
            label1.Show();
            label3.Show();
            label4.Show();
            cb_Assessment.Show();
            cb_AssessmentComponent.Show();
            cb_Date.Show();
            cb_rubriclevel.Show();

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

            SqlConnection conn1 = Connection.buildconnection();
            DataRowView drv = cb_rubriclevel.SelectedItem as DataRowView;
            int classid = Convert.ToInt32(drv.Row["Id"]);
            string query1 = "select Id, MeasurementLevel from RubricLevel Where RubricId = @id";


            SqlDataAdapter da1 = new SqlDataAdapter(query1, conn1);
            da1.SelectCommand.Parameters.AddWithValue("@id", classid);
            
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "rubricLevel");
            
           
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[1]).DisplayMember = "MeasurementLevel";
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[1]).ValueMember = "Id";
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[1]).DataSource = ds1.Tables["rubricLevel"];




            btn_GetStudent.Hide();
            btn_filter.Hide();

        }

        private void cb_AssessmentComponent_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataRowView drv = cb_AssessmentComponent.SelectedItem as DataRowView;
            int classid = Convert.ToInt32(drv.Row["Id"]);
            SqlConnection conn = Connection.buildconnection();
            string queryassessment = "Select Id, Details From Rubric Where Id = Any(select RubricId from AssessmentComponent Where Id = @id) ";
            SqlDataAdapter da = new SqlDataAdapter(queryassessment, conn);
            da.SelectCommand.Parameters.AddWithValue("@id", classid);
            DataSet ds = new DataSet();
            da.Fill(ds, "assessmentComponent");
            cb_rubriclevel.DisplayMember = "Details";
            cb_rubriclevel.ValueMember = "Id";
            cb_rubriclevel.DataSource = ds.Tables["assessmentComponent"];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void cb_Assessment_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = cb_Assessment.SelectedItem as DataRowView;
            int assessmentid = Convert.ToInt32(drv.Row["Id"]);

            SqlConnection conn = Connection.buildconnection();
            string queryassessment = "select Id, Name  from AssessmentComponent Where AssessmentId = @id ";
            SqlDataAdapter da = new SqlDataAdapter(queryassessment, conn);
            da.SelectCommand.Parameters.AddWithValue("@id", assessmentid);
            DataSet ds = new DataSet();
            da.Fill(ds, "assessmentComponent");
            cb_AssessmentComponent.DisplayMember = "Name";
            cb_AssessmentComponent.ValueMember = "Id";
            cb_AssessmentComponent.DataSource = ds.Tables["assessmentComponent"];
        }

        private void btn_MarkAssessment_Click(object sender, EventArgs e)
        {
            var value = dataGridView1[1, 0].Value;
            if(cb_Assessment.Text == "")
            {
                MessageBox.Show("Warning: Empty Value in Assessment!");
                return;
            }
            if (cb_AssessmentComponent.Text == "")
            {
                MessageBox.Show("Warning: Empty Value in Assessment Component!");
                return;
            }
            if (cb_rubriclevel.Text == "")
            {
                MessageBox.Show("Warning: Empty Value in Rubric Level!");
                return;
            }
            if (cb_Date.Text == "")
            {
                MessageBox.Show("Warning: Empty Value in Evaluation Date!");
                return;
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                value = dataGridView1[1, i].Value;
                if (value == null)
                {
                    MessageBox.Show("warning: Empty Records!");
                    return;
                }
            }
            int assessmentcomponentid, studentid, rubricmeasurementid;


            DataRowView drvassessmentcomponent = cb_AssessmentComponent.SelectedItem as DataRowView;
            assessmentcomponentid = Convert.ToInt32(drvassessmentcomponent.Row["Id"]);
            
           
            
            DateTime date = Connection.getAttendanceDatebyId(Convert.ToInt32(cb_Date.SelectedValue));
            
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                studentid =Connection.getStudentIdbyRegistrationNumber(Convert.ToString(dataGridView1[0, i].Value));
                rubricmeasurementid = Convert.ToInt32(dataGridView1[1, i].Value);
                if (Connection.CheckExistingResult(studentid, assessmentcomponentid))
                {
                    MessageBox.Show("Student with Reg #" + Convert.ToString(dataGridView1[0, i].Value) + "already had this evaluation! this one will not count but You can Update it.");
                }
                Connection.MarkStudentAssessment(studentid, assessmentcomponentid, rubricmeasurementid, date);
               
            }
            
            //Show the latest Data Grid View
            dataGridView1.DataSource = null;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {

            if (cb_Assessment.Text == "" || cb_AssessmentComponent.Text == "" )
            {
                MessageBox.Show("Warning: Empty Fields!");
                return;
            }
            this.dataGridView1.Columns[2].Visible = true;
            this.dataGridView1.Columns[3].Visible = true;
            this.dataGridView1.Columns[4].Visible = true;
            this.dataGridView1.Columns[1].Visible = false;

            DataRowView drvassessmentcomponent = cb_AssessmentComponent.SelectedItem as DataRowView;
            int assessmentcomponentid = Convert.ToInt32(drvassessmentcomponent.Row["Id"]);
            indexassessmentcomponentid = assessmentcomponentid;

            DataRowView drvrubricid = cb_rubriclevel.SelectedItem as DataRowView;
            indexrubricid = Convert.ToInt32(drvrubricid.Row["Id"]);

            btn_MarkAssessment.Hide();
            SqlConnection conn = Connection.buildconnection();
            String cmd = "SELECT StudentId, RubricMeasurementId FROM [ProjectB].[dbo].[StudentResult] Where AssessmentComponentId = @asid";
            SqlCommand command = new SqlCommand(cmd, conn);
            // Add the parameters if required
            command.Parameters.AddWithValue("@asid", assessmentcomponentid);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(reader);
            dataGridView1.DataSource = dt;


            conn = Connection.buildconnection();
            cmd = "SELECT StudentId, RubricMeasurementId FROM [ProjectB].[dbo].[StudentResult] Where AssessmentComponentId = @asid";
            command = new SqlCommand(cmd, conn);
            // Add the parameters if required
            command.Parameters.AddWithValue("@asid", assessmentcomponentid);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                int i = 0;
                while(reader.Read())
                {
                    dataGridView1[0, i].Value = Connection.getStudentRegNobyId(reader.GetInt32(0));
                    
                    dataGridView1[2, i].Value = Connection.getMeasurementLevelbyRubricLevelId(reader.GetInt32(1));
                    i++;
                }
            }
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            btn_MarkAssessment.Hide();
            btn_GetStudent.Hide();
            cb_Assessment.Hide();
            cb_AssessmentComponent.Hide();
            cb_rubriclevel.Hide();
            cb_Date.Hide();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlConnection conn = Connection.buildconnection();
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "UpdateAssessment")
            {
                label1.Hide();
                label2.Hide();
                label3.Show();
                label4.Hide();
                cb_Assessment.Hide();
                cb_AssessmentComponent.Hide();
                cb_rubriclevel.Show();
                cb_Date.Hide();
                btn_Update.Show();
                btn_filter.Hide();
                btn_GetStudent.Hide();
                btn_Refresh.Show();

                this.dataGridView1.Columns[4].Visible = false;
                cb_rubriclevel.DataSource = null;
                string queryassessment = "select Id, MeasurementLevel  from RubricLevel Where RubricId = @id ";
                SqlDataAdapter da = new SqlDataAdapter(queryassessment, conn);
                da.SelectCommand.Parameters.AddWithValue("@id", indexrubricid);
                DataSet ds = new DataSet();
                da.Fill(ds, "rubricLevel");
                cb_rubriclevel.DisplayMember = "MeasurementLevel";
                cb_rubriclevel.ValueMember = "Id";
                cb_rubriclevel.DataSource = ds.Tables["rubricLevel"];



                label3.Text = "Select Updated MeasurementLevel for :" + Convert.ToString(dataGridView1[0, e.RowIndex].Value);
                cb_rubriclevel.SelectedValue = Connection.getIdbyRubricIdAndMeasurementLevelFromRubricLevel(indexrubricid,Convert.ToInt32(dataGridView1[2, e.RowIndex].Value));
                indexStudentid = Connection.getStudentIdbyRegistrationNumber(Convert.ToString(dataGridView1[0, e.RowIndex].Value));

            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                indexStudentid = Connection.getStudentIdbyRegistrationNumber(Convert.ToString(dataGridView1[0, e.RowIndex].Value));
                indexrubriclevelid =Connection.getIdbyRubricIdAndMeasurementLevelFromRubricLevel(indexrubricid,Convert.ToInt32(dataGridView1[2, e.RowIndex].Value));
                if(Connection.DeleteFromStudentResult(indexStudentid,indexassessmentcomponentid,indexrubriclevelid))
                {
                    MessageBox.Show("Deleted Successfully");
                   

                }
                else
                {
                    MessageBox.Show("Warning: Can not Delete!");
                    return;
                }
                
                dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
               
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (cb_rubriclevel.Text == "")
            {
                MessageBox.Show("Warning: Empty Fields!");
                return;
            }
            DataRowView drvrubricid = cb_rubriclevel.SelectedItem as DataRowView;
            int newmeasurementlevel = Convert.ToInt32(drvrubricid.Row["Id"]);


            if (Connection.UpdateRubricMeasurementLevelIdFromStudentResult(indexStudentid
                ,indexassessmentcomponentid,newmeasurementlevel))
            {
                MessageBox.Show("Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Warning: Cannot Update");
                return;
            }
            SqlConnection conn = Connection.buildconnection();
            string cmd = "SELECT StudentId, RubricMeasurementId FROM [ProjectB].[dbo].[StudentResult] Where AssessmentComponentId = @asid";
            SqlCommand command = new SqlCommand(cmd, conn);
            // Add the parameters if required
            command.Parameters.AddWithValue("@asid", indexassessmentcomponentid);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                int i = 0;
                while (reader.Read())
                {
                    dataGridView1[0, i].Value = Connection.getStudentRegNobyId(reader.GetInt32(0));

                    dataGridView1[2, i].Value = Connection.getMeasurementLevelbyRubricLevelId(reader.GetInt32(1));
                    i++;
                }
            }
            label3.Hide();
            cb_rubriclevel.Hide();
            this.dataGridView1.Columns[4].Visible = true;
        }
    }
}
