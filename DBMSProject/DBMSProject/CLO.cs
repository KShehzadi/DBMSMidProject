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
    public partial class CLO : Form
    {
        public int index;
        public CLO()
        {
            InitializeComponent();
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
                tb_cloname.Text = Convert.ToString(dataGridView1[1, e.RowIndex].Value);
                btn_clo.Text = "Update";
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
               
                int i = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                String query = "DELETE FROM [ProjectB].[dbo].[CLO] Where id=@id";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", i);
                    


                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)Console.WriteLine("Error Deleting data From Database!");
                  
                }
            }
          
            String cmd = "SELECT * FROM [ProjectB].[dbo].[CLO]";
            SqlCommand commandf = new SqlCommand(cmd, conn);
            // Add the parameters if required
            commandf.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = commandf.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

        }

        private void btn_clo_Click(object sender, EventArgs e)
        {
            String conURL = "Data Source = DESKTOP-NGEMSRA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            if (btn_clo.Text == "Add CLO")
            {
                
                String query = "INSERT INTO dbo.CLO (Name,DateCreated, DateUpdated) VALUES (@name,@datecreated,@dateupdated)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", tb_cloname.Text);
                    command.Parameters.AddWithValue("@datecreated", DateTime.Now);
                    command.Parameters.AddWithValue("@dateupdated", DateTime.Now);
                   

                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0) Console.WriteLine("Error inserting data into Database!");
                    else
                    {
                        tb_cloname.Clear();
                        String cmd = "SELECT * FROM [ProjectB].[dbo].[CLO]";
                        SqlCommand commandf = new SqlCommand(cmd, conn);
                        // Add the parameters if required
                        commandf.Parameters.Add(new SqlParameter("0", 1));
                        SqlDataReader reader = commandf.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            else if(btn_clo.Text == "Update")
            {
                String query = "UPDATE CLO SET Name =@name,DateCreated=@dateupdated WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", tb_cloname.Text);
                    
                    command.Parameters.AddWithValue("@dateupdated", DateTime.Now);
                    command.Parameters.AddWithValue("@id", index);

                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                    {
                        Console.WriteLine("Error Updating data into Database!");
                    }
                    else
                    {
                        tb_cloname.Clear();
                        String cmd = "SELECT * FROM [ProjectB].[dbo].[CLO]";
                        SqlCommand commandf = new SqlCommand(cmd, conn);
                        // Add the parameters if required
                        commandf.Parameters.Add(new SqlParameter("0", 1));
                        SqlDataReader reader = commandf.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                        btn_clo.Text = "Add CLO";
                    }
                }

            }
        }

        private void btn_fetch_Click(object sender, EventArgs e)
        {

            String conURL = "Data Source = DESKTOP-NGEMSRA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            String cmd = "SELECT * FROM [ProjectB].[dbo].[CLO]";
            SqlCommand command = new SqlCommand(cmd, conn);
            // Add the parameters if required
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void CLO_Load(object sender, EventArgs e)
        {
            String conURL = "Data Source = DESKTOP-NGEMSRA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            String cmd = "SELECT * FROM [ProjectB].[dbo].[CLO]";
            SqlCommand command = new SqlCommand(cmd, conn);
            // Add the parameters if required
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

        }

        private void lbl_index_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
