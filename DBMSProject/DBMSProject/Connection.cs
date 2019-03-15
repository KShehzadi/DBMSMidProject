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
    public class Connection
    {


        public static void LoadStudentForm(ref DataGridView dataGridView1,ref ComboBox cb_status)
        {
            SqlConnection conn = Connection.buildconnection();
            String cmd = "SELECT * FROM [ProjectB].[dbo].[Student]";
            SqlCommand command = new SqlCommand(cmd, conn);
            // Add the parameters if required
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

            string query = "select Lookupid, Name from Lookup Where Category = 'STUDENT_STATUS'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "lookup");
            cb_status.DisplayMember = "Name";
            cb_status.ValueMember = "Lookupid";
            cb_status.DataSource = ds.Tables["lookup"];
        }

        public static void Delete_Student(int i)
        {
            SqlConnection conn = Connection.buildconnection();
            String query = "DELETE FROM [ProjectB].[dbo].[Student] Where id=@id";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@id", i);



                int result = command.ExecuteNonQuery();

                // Check Error
                if (result < 0) Console.WriteLine("Error Deleting data From Database!");


            }
        }
        public static void InsertAndUpdate_Student(ref TextBox tb_FirstName, ref TextBox tb_LastName, ref TextBox tb_Contact, ref TextBox tb_RegNo, ref TextBox tb_Email, ref ComboBox cb_status, ref Button btn_insert, ref int index)
        {
            
            SqlConnection conn = Connection.buildconnection();
            SqlDataReader reader;
            // First Name and Last Name can be same for two Students but all other fields are unique
            String cmdcheck = "SELECT * FROM [ProjectB].[dbo].[Student] Where Contact = @contact OR Email = @email OR RegistrationNumber = @regno  ";
            using (SqlCommand command = new SqlCommand(cmdcheck, conn))
            {

                command.Parameters.AddWithValue("@firstname", tb_FirstName.Text);
                command.Parameters.AddWithValue("@lastname", tb_LastName.Text);
                command.Parameters.AddWithValue("@contact", tb_Contact.Text);
                command.Parameters.AddWithValue("@email", tb_Email.Text);
                command.Parameters.AddWithValue("@regno", tb_RegNo.Text);


                reader = command.ExecuteReader();
            }
            if (reader.HasRows && btn_insert.Text != "Update")
            {
                MessageBox.Show("Student with same Date already exist !");
                return;
            }


            if (btn_insert.Text == "Insert Student")
            {
                if (tb_FirstName.Text == "" || tb_LastName.Text == "" || tb_Email.Text == "" || tb_Contact.Text == "" || tb_RegNo.Text == "" || cb_status.Text == "")
                {
                    MessageBox.Show("You can't insert a record with empty fields");
                    return;
                }

                try
                {
                    String query = "INSERT INTO dbo.Student (FirstName,LastName,Contact,Email,RegistrationNumber,Status) VALUES (@firstname,@lastname,@contact, @email, @regno, @status)";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@firstname", tb_FirstName.Text);
                        command.Parameters.AddWithValue("@lastname", tb_LastName.Text);
                        command.Parameters.AddWithValue("@contact", tb_Contact.Text);
                        command.Parameters.AddWithValue("@email", tb_Email.Text);
                        command.Parameters.AddWithValue("@regno", tb_RegNo.Text);

                        DataRowView drv = cb_status.SelectedItem as DataRowView;
                        int i = Convert.ToInt32(drv.Row["Lookupid"]);
                        command.Parameters.AddWithValue("@status", i);

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
            else if (btn_insert.Text == "Update")
            {
                try
                {
                    String query = "UPDATE dbo.Student SET FirstName = @firstname,LastName = @lastname,Contact = @contact,Email = @email,RegistrationNumber = @regno,Status = @status Where id = @id";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@firstname", tb_FirstName.Text);
                        command.Parameters.AddWithValue("@lastname", tb_LastName.Text);
                        command.Parameters.AddWithValue("@contact", tb_Contact.Text);
                        command.Parameters.AddWithValue("@email", tb_Email.Text);
                        command.Parameters.AddWithValue("@regno", tb_RegNo.Text);

                        DataRowView drv = cb_status.SelectedItem as DataRowView;
                        int i = Convert.ToInt32(drv.Row["Lookupid"]);
                        command.Parameters.AddWithValue("@status", i);
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
            tb_FirstName.Clear();
            tb_LastName.Clear();
            tb_RegNo.Clear();
            tb_Email.Clear();
            tb_Contact.Clear();
            btn_insert.Text = "Insert Student";
        }


        public static void LoadCLOForm(ref DataGridView dataGridView1)
        {
            SqlConnection conn = Connection.buildconnection();
            String cmd = "SELECT * FROM [ProjectB].[dbo].[CLO]";
            SqlCommand command = new SqlCommand(cmd, conn);
            // Add the parameters if required
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
        public static void DeleteCLO(int i)
        {
            SqlConnection conn = Connection.buildconnection();
            String query = "Select Id FROM [ProjectB].[dbo].[Rubric] Where CloId=@id";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@id", i);

                SqlDataReader readerrubric = command.ExecuteReader();
                int recordcount = 0;
                while (readerrubric.Read())
                {
                    recordcount++;
                }
                int[] rubricarray = new int[recordcount];
                readerrubric.Close();
                readerrubric = command.ExecuteReader();
                int count = 0;

                while (readerrubric.Read())
                {
                    int rubricid1 = readerrubric.GetInt32(0);
                    rubricarray[count] = rubricid1;
                    count++;
                }
                readerrubric.Close();
                foreach (int rubricid in rubricarray)
                {


                    query = "Delete FROM [ProjectB].[dbo].[AssessmentComponent] Where RubricId=@id";
                    using (SqlCommand commandl = new SqlCommand(query, conn))
                    {
                        commandl.Parameters.AddWithValue("@id", rubricid);
                        int result = commandl.ExecuteNonQuery();
                    }
                }
                foreach (int rubricid in rubricarray)
                {

                    query = "Select Id FROM [ProjectB].[dbo].[RubricLevel] Where RubricId=@id";
                    using (SqlCommand commandr = new SqlCommand(query, conn))
                    {
                        commandr.Parameters.AddWithValue("@id", rubricid);


                        SqlDataReader readerrubriclevel = command.ExecuteReader();
                        count = 0;
                        recordcount = 0;
                        while (readerrubriclevel.Read())
                        {
                            recordcount++;
                        }
                        int[] rubriclevelarray = new int[recordcount];
                        readerrubriclevel.Close();
                        readerrubriclevel = command.ExecuteReader();
                        while (readerrubriclevel.Read())
                        {
                            int rubricid1 = readerrubriclevel.GetInt32(0);
                            rubriclevelarray[count] = rubricid1;
                            count++;
                        }
                        readerrubriclevel.Close();
                        foreach (int rubriclevelid in rubriclevelarray)
                        {

                            query = "Delete FROM [ProjectB].[dbo].[StudentResult] Where RubricMeasurementId=@id";
                            using (SqlCommand commandl = new SqlCommand(query, conn))
                            {
                                commandl.Parameters.AddWithValue("@id", rubriclevelid);
                                int result = commandl.ExecuteNonQuery();
                            }
                        }
                        foreach (int rubriclevelid in rubricarray)
                        {

                            query = "Delete FROM [ProjectB].[dbo].[RubricLevel] Where RubricId=@id";
                            using (SqlCommand commandl = new SqlCommand(query, conn))
                            {
                                commandl.Parameters.AddWithValue("@id", rubriclevelid);
                                int result = commandl.ExecuteNonQuery();
                            }
                        }

                    }
            }


            query = "Delete  FROM [ProjectB].[dbo].[Rubric] Where CloId=@id";
            using (SqlCommand commandl = new SqlCommand(query, conn))
            {
                commandl.Parameters.AddWithValue("@id", i);
                int result = commandl.ExecuteNonQuery();
            }

            query = "DELETE FROM [ProjectB].[dbo].[CLO] Where id=@id";
            using (SqlCommand command3 = new SqlCommand(query, conn))
            {
                command3.Parameters.AddWithValue("@id", i);

                int result = command3.ExecuteNonQuery();

                // Check Error
                if (result < 0) Console.WriteLine("Error Deleting data From Database!");

            }
        }

    }

    public static void InsertAndUpdateCLO(ref TextBox tb_cloname,ref int index, ref DataGridView dataGridView1,ref Button btn_clo)
        {

            SqlConnection conn = Connection.buildconnection();

            if (btn_clo.Text == "Add CLO")
            {
                SqlDataReader reader;
                string check = "Select * from dbo.CLO Where Name = @name";
                using(SqlCommand checkcmd = new SqlCommand(check, conn))
                {
                    checkcmd.Parameters.AddWithValue("@name", tb_cloname.Text);
                    reader = checkcmd.ExecuteReader();
                    if(reader.HasRows)
                    {
                        MessageBox.Show("CLO with same name already exist");
                        return;
                    }
                }
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
                        Connection.LoadCLOForm(ref dataGridView1);
                    }
                }
            }
            else if (btn_clo.Text == "Update")
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
                        Connection.LoadCLOForm(ref dataGridView1);
                        btn_clo.Text = "Add CLO";
                    }
                }

            }
        }
    public static SqlConnection buildconnection()
        {
            String conURL = "Data Source = DESKTOP-NGEMSRA; Initial Catalog = ProjectB; Integrated Security = True; MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conURL);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            return conn;

        }
    }
}
