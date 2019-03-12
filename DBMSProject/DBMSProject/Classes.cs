using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public partial class Classes : Form
    {
        public Classes()
        {
            InitializeComponent();
        }

        private void Classes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet6.ClassAttendance' table. You can move, or remove it, as needed.
            this.classAttendanceTableAdapter.Fill(this.projectBDataSet6.ClassAttendance);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
