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
            Connection.LoadRubricLevelForm(ref dataGridView1, ref cb_rubric);
        }
        public int index;
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Connection.insertorupdaterubriclevel(ref tb_measurement, ref tb_details, ref index, ref dataGridView1, ref cb_rubric, ref btn_Add);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            SqlConnection conn = Connection.buildconnection();
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
                Connection.DeleteRubricLevelById(i);
            }

            String cmd = "select * FROM [ProjectB].[dbo].[RubricLevel]";
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

            SqlConnection conn = Connection.buildconnection();
            
            string query = "select id,Details from [ProjectB].[dbo].[Rubric]";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "rubric");
            cb_rubric.DisplayMember = "Details";
            cb_rubric.ValueMember = "id";
            cb_rubric.DataSource = ds.Tables["rubric"];

            String cmd = "select * FROM [ProjectB].[dbo].[RubricLevel]";
            SqlCommand command = new SqlCommand(cmd, conn);
            // Add the parameters if required
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {

            SqlConnection conn = Connection.buildconnection();
            int rubric_id;
            DataRowView drv = cb_rubric.SelectedItem as DataRowView;
            rubric_id = Convert.ToInt32(drv.Row["id"]);

            SqlDataReader reader;

            String cmd = "select * FROM [ProjectB].[dbo].[RubricLevel] Where RubricId = @id";
            using (SqlCommand command = new SqlCommand(cmd, conn))
            {
                // Add the parameters if required
                command.Parameters.AddWithValue("@id", rubric_id);

                reader = command.ExecuteReader();
            }
            
           
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

        }
    }
}
