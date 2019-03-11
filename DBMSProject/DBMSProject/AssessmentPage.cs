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
    public partial class AssessmentPage : Form
    {
        public int index;
        public AssessmentPage()
        {
            InitializeComponent();
        }

        private void AssessmentPage_Load(object sender, EventArgs e)
        {
           
           
            String conURL = "Data Source = DESKTOP-NGEMSRA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            String cmd = "SELECT * FROM [ProjectB].[dbo].[Assessment]";
            SqlCommand command = new SqlCommand(cmd, conn);
            // Add the parameters if required
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {

            String conURL = "Data Source = DESKTOP-NGEMSRA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            if (btn_Insert.Text == "Add New Assessment")
            {

                String query = "INSERT INTO dbo.Assessment (Title,DateCreated,TotalMarks,TotalWeightage) VALUES (@t,@dc,@tm, @tw)";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@t", tb_Title.Text);
                    command.Parameters.AddWithValue("@dc", DateTime.Now);
                    command.Parameters.AddWithValue("@tm",Convert.ToInt32(tb_TotalMarks.Text));
                    command.Parameters.AddWithValue("@tw",Convert.ToInt32(tb_TotalWeiaghtage.Text));
                   
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }
            }
            else if (btn_Insert.Text == "Update")
            {
                String query = "UPDATE dbo.Assessment SET Title = @t,TotalMarks = @tm,TotalWeightage = @tw Where id = @id";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@t", tb_Title.Text);
                    command.Parameters.AddWithValue("@tm", Convert.ToInt32(tb_TotalMarks.Text));
                    command.Parameters.AddWithValue("@tw", Convert.ToInt32(tb_TotalWeiaghtage.Text));
                    command.Parameters.AddWithValue("@id", index);

                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error Updating data into Database!");
                }
            }
            String cmd = "SELECT * FROM [ProjectB].[dbo].[Assessment]";
            SqlCommand commandf = new SqlCommand(cmd, conn);
            // Add the parameters if required
            commandf.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = commandf.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            tb_Title.Clear();
            tb_TotalMarks.Clear();
            tb_TotalWeiaghtage.Clear();
            btn_Insert.Text = "Add New Assessment";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String conURL = "Data Source = DESKTOP-NGEMSRA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                index = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                tb_Title.Text = Convert.ToString(dataGridView1[1, e.RowIndex].Value);
              
                tb_TotalMarks.Text = Convert.ToString(dataGridView1[3, e.RowIndex].Value);
                tb_TotalWeiaghtage.Text = Convert.ToString(dataGridView1[4, e.RowIndex].Value);
                
                btn_Insert.Text = "Update";
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
            {

                int i = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                String query = "DELETE FROM [ProjectB].[dbo].[Assessment] Where id=@id";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", i);



                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0) Console.WriteLine("Error Deleting data From Database!");


                }

            }

            String cmd = "SELECT * FROM [ProjectB].[dbo].[Assessment]";
            SqlCommand commandf = new SqlCommand(cmd, conn);
            // Add the parameters if required
            commandf.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = commandf.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn_Fetch_Click(object sender, EventArgs e)
        {
            String conURL = "Data Source = DESKTOP-NGEMSRA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            String cmd = "SELECT * FROM [ProjectB].[dbo].[Assessment]";
            SqlCommand command = new SqlCommand(cmd, conn);
            // Add the parameters if required
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void lbl_Index_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
