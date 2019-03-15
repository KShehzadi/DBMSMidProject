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
                Connection.DeleteCLO(i);
            }

            Connection.LoadCLOForm(ref dataGridView1);

        }

        private void btn_clo_Click(object sender, EventArgs e)
        {
            Connection.InsertAndUpdateCLO(ref tb_cloname,ref index, ref dataGridView1, ref btn_clo);
        }

        private void btn_fetch_Click(object sender, EventArgs e)
        {

            Connection.LoadCLOForm(ref dataGridView1);
        }
       
        private void CLO_Load(object sender, EventArgs e)
        {

            Connection.LoadCLOForm(ref dataGridView1);

        }

        private void lbl_index_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
