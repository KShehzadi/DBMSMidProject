using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public partial class Classes : Form
    {
        public Classes()
        {
            InitializeComponent();
        }

        private void Classes_Load(object sender, EventArgs e)
        {

            SqlConnection conn = Connection.buildconnection();
            String cmd1 = "SELECT * FROM [ProjectB].[dbo].[ClassAttendance]";
            SqlCommand command1 = new SqlCommand(cmd1, conn);
            // Add the parameters if required
            command1.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader1 = command1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader1);
            dataGridView1.DataSource = dt;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy, MM dd";

            SqlConnection conn = Connection.buildconnection();
            DateTime date = new DateTime();
            if(tb_Date.Text == "")
            {
                date = DateTime.Now;
            }
            else
            {
                try
                {
                    string temp = tb_Date.Text + " 00:00";
                    date = DateTime.ParseExact(temp, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Invalid date Format!");
                    return;
                }
               
            }
            if(date==null)
            {
                MessageBox.Show("Invalid Format of Date String!");
                return;
            }
            else
            {
                SqlDataReader reader;
                String cmd = "SELECT * FROM [ProjectB].[dbo].[ClassAttendance] Where Day(AttendanceDate) = @day AND Month(AttendanceDate) = @month AND Year(AttendanceDate) = @year ";
                using (SqlCommand commandf = new SqlCommand(cmd, conn))
                {

                    commandf.Parameters.AddWithValue("@day", date.Day);
                    commandf.Parameters.AddWithValue("@month", date.Month);
                    commandf.Parameters.AddWithValue("@year", date.Year);
                    reader = commandf.ExecuteReader();
                }
                if (reader.HasRows)
                {
                    MessageBox.Show("Class with same Date already exist !");
                    return;
                }
                else
                {
                    if (btn_insert.Text == "Insert")
                    {
                        String query = "INSERT INTO dbo.ClassAttendance (AttendanceDate) VALUES (@datecreated)";
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {

                            command.Parameters.AddWithValue("@datecreated", date.Date);



                            int result = command.ExecuteNonQuery();

                            // Check Error
                            if (result < 0) Console.WriteLine("Error inserting data into Database!");

                        }
                    }
                    else if(btn_insert.Text == "Update")
                    {
                        try
                        {
                            String query = "Update dbo.ClassAttendance Set AttendanceDate = @datecreated Where id = @index";
                            using (SqlCommand command = new SqlCommand(query, conn))
                            {

                                command.Parameters.AddWithValue("@datecreated", date.Date);
                                command.Parameters.AddWithValue("@index", indexclassid);


                                int result = command.ExecuteNonQuery();

                                // Check Error
                                if (result < 0) Console.WriteLine("Error Updating data into Database!");

                            }
                        }
                        catch
                        {
                            MessageBox.Show("Can't Update this record because of dependencies in database!");
                        }
                       }
                }
            }
           
            String cmd1 = "SELECT * FROM [ProjectB].[dbo].[ClassAttendance]";
            SqlCommand command1 = new SqlCommand(cmd1, conn);
            // Add the parameters if required
            command1.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader1 = command1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader1);
            dataGridView1.DataSource = dt;
            btn_insert.Text = "Insert";
        }

        private void btn_Fetch_Click(object sender, EventArgs e)
        {

            SqlConnection conn = Connection.buildconnection();
            String cmd1 = "SELECT * FROM [ProjectB].[dbo].[ClassAttendance]";
            SqlCommand command1 = new SqlCommand(cmd1, conn);
            // Add the parameters if required
            command1.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader1 = command1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader1);
            dataGridView1.DataSource = dt;
        }
        public int indexclassid;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlConnection conn = Connection.buildconnection();
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                indexclassid = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                DateTime date = new DateTime();
                date = (Convert.ToDateTime(dataGridView1[1, e.RowIndex].Value)).Date;
                if(Convert.ToString(date.Month).Length == 1)
                {
                    tb_Date.Text = Convert.ToString(date.Year) + "-0" + Convert.ToString(date.Month) + "-" + Convert.ToString(date.Day);
                }
                else if(Convert.ToString(date.Day).Length==1)
                {
                    tb_Date.Text = Convert.ToString(date.Year) + "-" + Convert.ToString(date.Month) + "-0" + Convert.ToString(date.Day);
                }
                else if(Convert.ToString(date.Month).Length == 1 && Convert.ToString(date.Day).Length == 1)
                {
                    tb_Date.Text = Convert.ToString(date.Year) + "-0" + Convert.ToString(date.Month) + "-0" + Convert.ToString(date.Day);
                }
                else
                {
                    tb_Date.Text = Convert.ToString(date.Year) + "-" + Convert.ToString(date.Month) + "-" + Convert.ToString(date.Day);
                }



                btn_insert.Text = "Update";
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
            {

                int i = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                if(Connection.DeleteStudentAttendancebyClassid(i))
                {
                    MessageBox.Show("All the student attendance from this class are deleted!");
                }
                String query = "DELETE FROM [ProjectB].[dbo].[ClassAttendance] Where id=@id";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", i);



                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                    {
                        Console.WriteLine("Error Deleting data From Database!");
                        return;
                    }


                }
                MessageBox.Show("Class Deleted Successfully!");

            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
              e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Mark Attendance")
            {

            }
                String cmd = "SELECT * FROM [ProjectB].[dbo].[ClassAttendance]";
            SqlCommand commandf = new SqlCommand(cmd, conn);
            // Add the parameters if required
            commandf.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = commandf.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void tb_Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
            if (dateTimePicker1.Value.Month.ToString().Length == 1)
            {
                tb_Date.Text = dateTimePicker1.Value.Year.ToString() + "-0" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString();
            }
            else if (dateTimePicker1.Value.Day.ToString().Length == 1)
            {
                tb_Date.Text = dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-0" + dateTimePicker1.Value.Day.ToString();
            }
            else if (dateTimePicker1.Value.Month.ToString().Length == 1 && dateTimePicker1.Value.Day.ToString().Length == 1)
            {
                tb_Date.Text = dateTimePicker1.Value.Year.ToString() + "-0" + dateTimePicker1.Value.Month.ToString() + "-0" + dateTimePicker1.Value.Day.ToString();
            }
            else
            {
                tb_Date.Text = dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString();
            }
        }
    }
}
