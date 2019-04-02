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
    public partial class AssessmentComponent : Form
    {
        public int index;
        public AssessmentComponent()
        {
            InitializeComponent();
        }

        private void AssessmentComponent_Load(object sender, EventArgs e)
        {
            


            SqlConnection conn = Connection.buildconnection();
            String cmd = "SELECT * FROM [ProjectB].[dbo].[AssessmentComponent]";
            SqlCommand command = new SqlCommand(cmd, conn);
            // Add the parameters if required
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;


            string query = "select id, Title from [ProjectB].[dbo].[Assessment]";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "assessment");
            cb_Assessment.DisplayMember = "Title";
            cb_Assessment.ValueMember = "id";
            cb_Assessment.DataSource = ds.Tables["assessment"];




            query = "select id, Details from [ProjectB].[dbo].[Rubric]";
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds, "rubric");
            cb_Rubric.DisplayMember = "Details";
            cb_Rubric.ValueMember = "id";
            cb_Rubric.DataSource = ds.Tables["rubric"];



        }

        private void lbl_index_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           
            foreach (char c in tb_totalmarks.Text)
            {
                if (c < 48 || c > 57)
                {
                    MessageBox.Show("Total Marks can only have Digits!");
                    return;
                }
            }
            SqlConnection conn = Connection.buildconnection();
            try
            {

              
                if (btn_add.Text == "Insert")
                {
                    String query = "INSERT INTO [ProjectB].[dbo].[AssessmentComponent] (Name, RubricId,TotalMarks,DateCreated,DateUpdated,AssessmentId) VALUES (@name,@rid,@tm,@dc,@du,@asid)";
                    DataRowView drv = cb_Rubric.SelectedItem as DataRowView;
                    int rubricid = Convert.ToInt32(drv.Row["id"]);
                    drv = cb_Assessment.SelectedItem as DataRowView;
                    int assessmentid = Convert.ToInt32(drv.Row["id"]);
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", tb_Name.Text);
                        command.Parameters.AddWithValue("@rid", rubricid);
                        command.Parameters.AddWithValue("@tm", Convert.ToInt32(tb_totalmarks.Text));
                        command.Parameters.AddWithValue("@dc", DateTime.Now);
                        command.Parameters.AddWithValue("@du", DateTime.Now);
                        command.Parameters.AddWithValue("@asid", assessmentid);
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0) Console.WriteLine("Error inserting data into Database!");
                      

                    }
                }
                else if (btn_add.Text == "Update")
                {
                    String query = "Update [ProjectB].[dbo].[AssessmentComponent] Set Name = @name, RubricId = @rid,TotalMarks = @tm,DateUpdated = @du,AssessmentId = @asid where id = @index";
                    DataRowView drv = cb_Rubric.SelectedItem as DataRowView;
                    int rubricid = Convert.ToInt32(drv.Row["id"]);
                    drv = cb_Assessment.SelectedItem as DataRowView;
                    int assessmentid = Convert.ToInt32(drv.Row["id"]);
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", tb_Name.Text);
                        command.Parameters.AddWithValue("@rid", rubricid);
                        command.Parameters.AddWithValue("@tm", tb_totalmarks.Text);
                        command.Parameters.AddWithValue("@index", index);
                        command.Parameters.AddWithValue("@du", DateTime.Now);
                        command.Parameters.AddWithValue("@asid", assessmentid);
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0) Console.WriteLine("Error inserting data into Database!");
                    }



                    }
            }
            catch
            {
               MessageBox.Show("Trying to Send Invalid data in Database!");
                return;
            }
            tb_Name.Clear();
            tb_totalmarks.Clear();
            String cmd = "SELECT * FROM [ProjectB].[dbo].[AssessmentComponent]";
            SqlCommand commandf = new SqlCommand(cmd, conn);
            // Add the parameters if required
            commandf.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = commandf.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            btn_add.Text = "Insert";
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlConnection conn = Connection.buildconnection();
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                index = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                tb_Name.Text = Convert.ToString(dataGridView1[1, e.RowIndex].Value);
                tb_totalmarks.Text = Convert.ToString(dataGridView1[3, e.RowIndex].Value);
                cb_Rubric.SelectedValue = Convert.ToInt32(dataGridView1[2, e.RowIndex].Value);
                cb_Assessment.SelectedValue = Convert.ToInt32(dataGridView1[6, e.RowIndex].Value);
                btn_add.Text = "Update";
            }
            
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                try
                {
                    int i = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                    String query = "DELETE FROM [ProjectB].[dbo].[AssessmentComponent] Where id=@id";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id", i);



                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0) Console.WriteLine("Error Deleting data From Database!");

                    }
                }
                catch
                {
                    MessageBox.Show("You can't Delete this. It may have dependencies in Database!");
                }
            }

            String cmd = "SELECT * FROM [ProjectB].[dbo].[AssessmentComponent]";
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

            SqlConnection conn = Connection.buildconnection();
            String cmd = "SELECT * FROM [ProjectB].[dbo].[AssessmentComponent]";
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
