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
    public partial class StudentAttendanceForm : Form
    {
        public StudentAttendanceForm()
        {
            InitializeComponent();
        }
        public static int indexclassid = 0;
        public static int indexstudentid = 0;
        private void StudentAttendanceForm_Load(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Hide();
            cb_AttendanceStatus.Hide();
            tb_StudentRegisterationNumber.Hide();


            SqlConnection conn = Connection.buildconnection();



            string query = "select Id, AttendanceDate from ClassAttendance";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "classAttendance");
            cb_class.DisplayMember = "AttendanceDate";
            cb_class.ValueMember = "Id";
            cb_class.DataSource = ds.Tables["classAttendance"];



            this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;


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


                dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i].ItemArray[0];
            }


            string query1 = "select LookupId, Name from Lookup Where Category = 'ATTENDANCE_STATUS'";
            SqlDataAdapter da1 = new SqlDataAdapter(query1, conn);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "lookup");
           
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[0]).DataSource = ds1.Tables["lookup"];
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[0]).DisplayMember = "Name";
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[0]).ValueMember = "LookupId";
            btn_Update.Hide();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btn_MarkAttendance_Click(object sender, EventArgs e)
        {
            DataRowView drv = cb_class.SelectedItem as DataRowView;
            int classid = Convert.ToInt32(drv.Row["Id"]);
            if(Connection.CheckExistingClassesbyId(classid))
            {
                MessageBox.Show("some instances of this class date are already present in database proceed to continue. :)");
                
            }
            var value = dataGridView1[0, 0].Value;
            for(int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                value = dataGridView1[0,i].Value;
                if (value == null)
                {
                    MessageBox.Show("warning: Empty Records!");
                    break;
                }
            }
            bool check;
            int aid, sid, ast;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                aid = classid;
                value = dataGridView1[0, i].Value;
                ast = Convert.ToInt32(dataGridView1[0, i].Value);
                sid = Connection.getStudentIdbyRegistrationNumber(dataGridView1[1, i].Value.ToString());
                check = Connection.MarkStudentAttendance(aid, sid,ast);
                if(check == false && value != null)
                {
                    MessageBox.Show("Student with Reg #" + dataGridView1[1, i].Value.ToString() + " attendance is already marked you can't mark it twice! but you can Update it !");
                }
               
            }
            
            btn_refresh_Click(sender, e);
        }

        private void btn_ClassFiltter_Click(object sender, EventArgs e)
        {
            btn_MarkAttendance.Hide();
            dataGridView1.DataSource = null;
            DataRowView drv = cb_class.SelectedItem as DataRowView;
            int classid = Convert.ToInt32(drv.Row["Id"]);
            label2.Hide();
            label3.Hide();
            cb_AttendanceStatus.Hide();
            tb_StudentRegisterationNumber.Hide();
            label1.Show();
            cb_class.Show();
            btn_Update.Hide();
            btn_ClassFiltter.Show();
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = true;
            SqlDataReader reader  = Connection.getStudentIdAndAttendanceStatusFromStudentAttendance(classid);
            DataTable dt = new DataTable();
            if (reader == null)
            {
                MessageBox.Show("No Attendance Records with this class !");
                dataGridView1.Controls.Clear();
                return;
              
            }
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            int i = 0;
            reader = Connection.getStudentIdAndAttendanceStatusFromStudentAttendance(classid);
            while (reader.Read())
            {
                dataGridView1[0, i].Value = reader.GetInt32(1);
                dataGridView1[1, i].Value = Connection.getStudentRegNobyId(reader.GetInt32(0));
                dataGridView1[2, i].Value = Connection.getAttendanceDatebyId(classid);
                i++;

            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {



            SqlConnection conn = Connection.buildconnection();
            this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;

            btn_MarkAttendance.Show();
            btn_ClassFiltter.Show();
            btn_Update.Hide();
            tb_StudentRegisterationNumber.Clear();
            tb_StudentRegisterationNumber.Hide();
            label2.Hide();
            label3.Hide();
            label1.Show();
            cb_AttendanceStatus.Hide();
            cb_class.Show();
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


                dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i].ItemArray[0];
            }


            string query1 = "select LookupId, Name from Lookup Where Category = 'ATTENDANCE_STATUS'";
            SqlDataAdapter da1 = new SqlDataAdapter(query1, conn);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "Name");

            ((DataGridViewComboBoxColumn)dataGridView1.Columns[0]).DataSource = ds1.Tables["Name"];
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[0]).DisplayMember = "Name";
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[0]).ValueMember = "LookupId";
          


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            SqlConnection conn = Connection.buildconnection();
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Update_Status")
            {
                indexclassid = Connection.getAttendanceidbydatefromclassAttendance(Convert.ToDateTime(dataGridView1[2, e.RowIndex].Value));
                indexstudentid = Connection.getStudentIdbyRegistrationNumber(Convert.ToString(dataGridView1[1, e.RowIndex].Value));
               
                label3.Show();
                label2.Show();
                tb_StudentRegisterationNumber.Show();
                cb_AttendanceStatus.Show();
                btn_Update.Show();
                label1.Hide();
                cb_class.Hide();


                string query = "select LookupId, Name from Lookup Where Category = 'ATTENDANCE_STATUS'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "lookup");
                cb_AttendanceStatus.DisplayMember = "Name";
                cb_AttendanceStatus.ValueMember = "LookupId";
                cb_AttendanceStatus.DataSource = ds.Tables["lookup"];
               
                tb_StudentRegisterationNumber.Text = Convert.ToString(dataGridView1[1, e.RowIndex].Value);
                cb_AttendanceStatus.SelectedValue = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                btn_ClassFiltter.Hide();
                btn_MarkAttendance.Hide();
                btn_Update_Click(sender, e);
               
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
            {

                indexclassid = Connection.getAttendanceidbydatefromclassAttendance(Convert.ToDateTime(dataGridView1[2, e.RowIndex].Value));
                indexstudentid = Connection.getStudentIdbyRegistrationNumber(Convert.ToString(dataGridView1[1, e.RowIndex].Value));
                if(Connection.DeleteStudentAttendance(ref indexclassid, ref indexstudentid))
                {
                    MessageBox.Show("Deleted Successfully!");
                }
                else
                {
                    MessageBox.Show("Problem Occured ! cannot delete :(");
                }
                btn_ClassFiltter_Click(sender, e);
              
            }
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            
            DataRowView drv = cb_AttendanceStatus.SelectedItem as DataRowView;
            int astatus = Convert.ToInt32(drv.Row["lookupId"]);

            if(Connection.UpdateStudentAttendance(ref astatus,ref indexclassid,ref indexstudentid))
            {
                MessageBox.Show("Updated Successfully !");
            }
            else
            {
                MessageBox.Show("Cannot Update !");
            }

            btn_ClassFiltter_Click(sender, e);


        }
    }
}
