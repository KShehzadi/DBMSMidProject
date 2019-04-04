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
            foreach(char c in tb_FirstName.Text)
            {
                if(c < 65 || c > 122 ||(c < 97&& c > 90))
                {
                    MessageBox.Show("First Name only have alphabets!");
                    return;
                }
            }
            foreach (char c in tb_LastName.Text)
            {
                if (c < 65 || c > 122 || (c < 97 && c > 90))
                {
                    MessageBox.Show("Last Name only have alphabets!");
                    return;
                }
            }
            foreach (char c in tb_Contact.Text)
            {
                if (c < 48 || c > 57 )
                {
                    MessageBox.Show("Contact only have Digits!");
                    return;
                }
            }

            Connection.InsertAndUpdate_Student(ref tb_FirstName, ref tb_LastName, ref tb_Contact, ref tb_RegNo, ref tb_Email, ref cb_status, ref btn_insert, ref index);
            Connection.LoadStudentForm(ref dataGridView1, ref cb_status);
            
            
           
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            Connection.LoadStudentForm(ref dataGridView1, ref cb_status);   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlConnection conn = Connection.buildconnection();
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
                cb_status.SelectedValue = Convert.ToInt32(dataGridView1[6, e.RowIndex].Value);
                btn_insert.Text = "Update";
                return;
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
            {

                int i = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                Connection.Delete_Student(i);
               
            }

            Connection.LoadStudentForm(ref dataGridView1, ref cb_status);
        }

        private void btn_Fetch_Click(object sender, EventArgs e)
        {

            Connection.LoadStudentForm(ref dataGridView1, ref cb_status);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void tb_FirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_LastName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tb_Contact_TextChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}
