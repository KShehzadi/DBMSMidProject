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

   
    public partial class AddStudent : Form
    {
        public int index;
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            String conURL = "Data Source = DESKTOP-NGEMSRA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            if (btn_insert.Text == "Insert Student")
            {
                
                String query = "INSERT INTO dbo.Student (FirstName,LastName,Contact,Email,RegistrationNumber,Status) VALUES (@firstname,@lastname,@contact, @email, @regno, @status)";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@firstname", tb_FirstName.Text);
                    command.Parameters.AddWithValue("@lastname", tb_LastName.Text);
                    command.Parameters.AddWithValue("@contact", tb_Contact.Text);
                    command.Parameters.AddWithValue("@email", tb_Email.Text);
                    command.Parameters.AddWithValue("@regno", tb_RegNo.Text);
                    command.Parameters.AddWithValue("@status", Convert.ToInt32(tb_Status.Text));

                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }
            }
            else if(btn_insert.Text== "Update")
            {
                String query = "UPDATE dbo.Student SET FirstName = @firstname,LastName = @lastname,Contact = @contact,Email = @email,RegistrationNumber = @regno,Status = @status Where id = @id";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@firstname", tb_FirstName.Text);
                    command.Parameters.AddWithValue("@lastname", tb_LastName.Text);
                    command.Parameters.AddWithValue("@contact", tb_Contact.Text);
                    command.Parameters.AddWithValue("@email", tb_Email.Text);
                    command.Parameters.AddWithValue("@regno", tb_RegNo.Text);
                    command.Parameters.AddWithValue("@status", Convert.ToInt32(tb_Status.Text));
                    command.Parameters.AddWithValue("@id", index);

                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error Updating data into Database!");
                }
            }
            String cmd = "SELECT * FROM [ProjectB].[dbo].[Student]";
            SqlCommand commandf = new SqlCommand(cmd, conn);
            // Add the parameters if required
            commandf.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = commandf.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            tb_FirstName.Clear();
            tb_LastName.Clear();
            tb_RegNo.Clear();
            tb_Email.Clear();
            tb_Contact.Clear();
            tb_Status.Clear();
            btn_insert.Text = "Insert Student";
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet1.Student);
            String conURL = "Data Source = DESKTOP-NGEMSRA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            String cmd = "SELECT * FROM [ProjectB].[dbo].[Student]";
            SqlCommand command = new SqlCommand(cmd, conn);
            // Add the parameters if required
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
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
                tb_FirstName.Text = Convert.ToString(dataGridView1[1, e.RowIndex].Value);
                tb_LastName.Text = Convert.ToString(dataGridView1[2, e.RowIndex].Value);
                tb_Contact.Text = Convert.ToString(dataGridView1[3, e.RowIndex].Value);
                tb_Email.Text = Convert.ToString(dataGridView1[4, e.RowIndex].Value);
                tb_RegNo.Text = Convert.ToString(dataGridView1[5, e.RowIndex].Value);
                tb_Status.Text = Convert.ToString(dataGridView1[6, e.RowIndex].Value);
                btn_insert.Text = "Update";
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
            {

                int i = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                String query = "DELETE FROM [ProjectB].[dbo].[Student] Where id=@id";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", i);



                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0) Console.WriteLine("Error Deleting data From Database!");
              

                }
               
            }

            String cmd = "SELECT * FROM [ProjectB].[dbo].[Student]";
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
            String cmd = "SELECT * FROM [ProjectB].[dbo].[Student]";
            SqlCommand command = new SqlCommand(cmd, conn);
            // Add the parameters if required
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;


            conn.Close();

        }
    }
}
