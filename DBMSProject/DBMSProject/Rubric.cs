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
    public partial class Rubric : Form
    {
        public int index;
        
        public Rubric()
        {
            InitializeComponent();
        }

        private void Rubric_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet3.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet3.Rubric);
            String conURL = "Data Source = DESKTOP-NGEMSRA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            String cmd = "SELECT * FROM [ProjectB].[dbo].[Rubric]";
            SqlCommand command = new SqlCommand(cmd, conn);
            // Add the parameters if required
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
           
                string query = "select id, name from CLO";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Clo");
                cb_clo.DisplayMember = "name";
                cb_clo.ValueMember = "id";
                cb_clo.DataSource = ds.Tables["Clo"];
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if(textBox1.Text == "")
            {
                panel2.Controls.Clear();
                panel1.Controls.Clear();
            }
            try
            {
                int txtno = int.Parse(textBox1.Text);
                int pointX = 30;
                int pointY = 40;
                panel2.Controls.Clear();
                panel1.Controls.Clear();
                for (int i = 0; i < txtno; i++)
                {
                    TextBox a = new TextBox();
                    a.Name = "Rubric"+ (i + 1).ToString();
                    a.Location = new Point(pointX, pointY);
                    
                    panel1.Controls.Add(a);
                    panel1.Show();
                   
                    pointY += 25;
                }
                pointX = 30;
                pointY = 40;
                for (int i = 0; i < txtno; i++)
                {
                    
                    TextBox b = new TextBox();
                    b.Name = "Id" + (i + 1).ToString();
                    b.Location = new Point(pointX, pointY);
                    panel2.Controls.Add(b);
                    panel2.Show();
                    pointY += 25;
                }
            }
            catch (Exception)
            {
                if(textBox1.Text!="")MessageBox.Show("Invalid Entry in Rubric Count");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void btn_rubric_Click(object sender, EventArgs e)
        {
            String conURL = "Data Source = DESKTOP-NGEMSRA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            try
            {
                
                int j = 0;
                int[] idarray = new int[50];
                if (btn_rubric.Text == "Add Rubric")
                {
                    foreach (Control ctr in panel2.Controls)
                    {
                        idarray[j] = Convert.ToInt32(((TextBox)ctr).Text);
                        j++;
                    }
                    j = 0;
                    foreach (Control ctr in panel1.Controls)
                    {
                        if (ctr is TextBox)
                        {
                            string value = ((TextBox)ctr).Text;
                            String query = "INSERT INTO dbo.Rubric (id,Details,CloId) VALUES (@i,@name,@id)";
                            DataRowView drv = cb_clo.SelectedItem as DataRowView;
                            int i = Convert.ToInt32(drv.Row["id"]);
                            using (SqlCommand command = new SqlCommand(query, conn))
                            {

                                command.Parameters.AddWithValue("@name", value);
                                command.Parameters.AddWithValue("@id", i);
                                command.Parameters.AddWithValue("@i", idarray[j]);

                                int result = command.ExecuteNonQuery();

                                // Check Error
                                if (result < 0) Console.WriteLine("Error inserting data into Database!");
                                else j++;

                            }

                        }
                    }

                }
                else if (btn_rubric.Text == "Update")
                {
                    int p = 0;
                    foreach (Control ctr in panel2.Controls)
                    {
                        if (ctr is TextBox)
                        {
                            p = Convert.ToInt32(((TextBox)ctr).Text);
                        }
                    }
                    foreach (Control ctr in panel1.Controls)
                    {
                        if (ctr is TextBox)
                        {
                            string value = ((TextBox)ctr).Text;
                            String query = "Update dbo.Rubric SET id =@newid , Details = @name,CloId=@id where id = @index";
                            DataRowView drv = cb_clo.SelectedItem as DataRowView;
                            int i = Convert.ToInt32(drv.Row["id"]);
                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@name", value);
                                command.Parameters.AddWithValue("@id", i);
                                command.Parameters.AddWithValue("@index", index);
                                command.Parameters.AddWithValue("@newid", p);
                                int result = command.ExecuteNonQuery();

                                // Check Error
                                if (result < 0) Console.WriteLine("Error Updating data into Database!");

                            }

                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("Trying to Send Invalid data in Database!");
            }
            textBox1.Clear();
            String cmd = "SELECT * FROM [ProjectB].[dbo].[Rubric]";
            SqlCommand commandf = new SqlCommand(cmd, conn);
            // Add the parameters if required
            commandf.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = commandf.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            btn_rubric.Text = "Add Rubric";
            panel2.Controls.Clear();
            panel1.Controls.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
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


                int pointX = 30;
                int pointY = 40;


                TextBox a = new TextBox();
                a.Name = "Rubric" + index.ToString();
                a.Location = new Point(pointX, pointY);
               
                a.Text = Convert.ToString(dataGridView1[1, e.RowIndex].Value);
                panel1.Controls.Add(a);
                panel1.Show();
                pointY += 25;


                pointX = 30;
                pointY = 40;
                TextBox b = new TextBox();
                b.Name = "Id" + index.ToString();
                b.Location = new Point(pointX, pointY);
                
                b.Text = Convert.ToString(dataGridView1[0, e.RowIndex].Value);
                panel2.Controls.Add(b);
                panel2.Show();
                pointY += 25;

                cb_clo.SelectedValue = Convert.ToInt32(dataGridView1[2, e.RowIndex].Value);
                btn_rubric.Text = "Update";
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
            {

                int i = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                String query = "DELETE FROM [ProjectB].[dbo].[Rubric] Where id=@id";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", i);



                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0) Console.WriteLine("Error Deleting data From Database!");

                }
            }

            String cmd = "SELECT * FROM [ProjectB].[dbo].[Rubric]";
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
