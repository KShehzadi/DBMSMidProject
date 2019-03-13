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
    public partial class Rubric_Level_Form : Form
    {
        public Rubric_Level_Form()
        {
            InitializeComponent();
        }

        private void Rubric_Level_Form_Load(object sender, EventArgs e)
        {
            
            String conURL = "Data Source = DESKTOP-NGEMSRA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            string query = "select id,Details from [ProjectB].[dbo].[Rubric]";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "rubric");
            cb_rubric.DisplayMember = "Details";
            cb_rubric.ValueMember = "id";
            cb_rubric.DataSource = ds.Tables["rubric"];

            String cmd = "SELECT * FROM [ProjectB].[dbo].[RubricLevel]";
            SqlCommand command = new SqlCommand(cmd, conn);
            // Add the parameters if required
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
        public int index;
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_measurement.Text == "" || tb_details.Text == "" || cb_rubric.Text == "")
            {
                MessageBox.Show("You can't insert a record with empty fields");
                return;
            }
            int ml = -1;
            ml = Convert.ToInt32(tb_measurement.Text);
            if(ml == -1)
            {
                MessageBox.Show("Incorrect Measurement Level!");
            }
            int rubric_id;
            DataRowView drv = cb_rubric.SelectedItem as DataRowView;
            rubric_id = Convert.ToInt32(drv.Row["id"]);
            
            String conURL = "Data Source = DESKTOP-NGEMSRA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conURL);
            SqlDataReader reader;
            conn.Open();
            // First Name and Last Name can be same for two Students but all other fields are unique
            String cmdcheck = "SELECT * FROM [ProjectB].[dbo].[RubricLevel] Where RubricId = @i";
            using (SqlCommand command = new SqlCommand(cmdcheck, conn))
            {

                command.Parameters.AddWithValue("@i", rubric_id);
                

                reader = command.ExecuteReader();
            }
            if (reader.HasRows)
            {
                MessageBox.Show("Rubric Already have a level record in database!");
                return;
            }
            if (btn_Add.Text == "Assign Level")
            {
                

                try
                {
                    String query = "INSERT INTO dbo.RubricLevel (RubricId, Details,MeasurementLevel) VALUES (@rid,@d,@ml)";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@rid", rubric_id);
                        command.Parameters.AddWithValue("@d", tb_details.Text);
                        command.Parameters.AddWithValue("@ml", ml);
                        

                       

                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                            Console.WriteLine("Error inserting data into Database!");
                    }
                }
                catch
                {
                    MessageBox.Show("Trying to Insert Invalid data in database!");
                    return;
                }
            }
            else if (btn_Add.Text == "Update")
            {
                try
                {
                    String query = "UPDATE dbo.RubricLevel SET RubricId = @rid,Details = @d,MeasurementLevel = @m Where id = @id";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@rid", rubric_id);
                        command.Parameters.AddWithValue("@d", tb_details.Text);
                        command.Parameters.AddWithValue("@m", ml);

                        command.Parameters.AddWithValue("@id", index);

                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                            Console.WriteLine("Error Updating data into Database!");
                    }
                }
                catch
                {
                    MessageBox.Show("This Record can not be updated due to invalid data or dependencies  in database!");
                    return;

                }
            }
            String cmd = "SELECT * FROM [ProjectB].[dbo].[RubricLevel]";
            SqlCommand commandf = new SqlCommand(cmd, conn);
            // Add the parameters if required
            commandf.Parameters.Add(new SqlParameter("0", 1));
            reader = commandf.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            tb_details.Clear();
            tb_measurement.Clear();
            

            btn_Add.Text = "Assign Level";
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
                tb_details.Text = Convert.ToString(dataGridView1[2, e.RowIndex].Value);
                tb_measurement.Text = Convert.ToString(dataGridView1[3, e.RowIndex].Value);
               
                cb_rubric.SelectedValue = Convert.ToInt32(dataGridView1[1, e.RowIndex].Value);
                btn_Add.Text = "Update";
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
            {

                int i = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                String query = "DELETE FROM [ProjectB].[dbo].[RubricLevel] Where id=@id";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", i);



                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0) Console.WriteLine("Error Deleting data From Database!");


                }

            }

            String cmd = "SELECT * FROM [ProjectB].[dbo].[RubricLevel]";
            SqlCommand commandf = new SqlCommand(cmd, conn);
            // Add the parameters if required
            commandf.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = commandf.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btn_Fetch_Click(object sender, EventArgs e)
        {
            String conURL = "Data Source = DESKTOP-NGEMSRA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            string query = "select id,Details from [ProjectB].[dbo].[Rubric]";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "rubric");
            cb_rubric.DisplayMember = "Details";
            cb_rubric.ValueMember = "id";
            cb_rubric.DataSource = ds.Tables["rubric"];

            String cmd = "SELECT * FROM [ProjectB].[dbo].[RubricLevel]";
            SqlCommand command = new SqlCommand(cmd, conn);
            // Add the parameters if required
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
    }
}
