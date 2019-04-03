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
    public partial class ReportsIndexForm : Form
    {
        public ReportsIndexForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IndividualStudent_sCLOReports i = new IndividualStudent_sCLOReports();
            i.Show();
            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Connection.GenerateClassAssessmentReport())
            {
                MessageBox.Show("Class Assessment Report Created Successfully");
            }
            else
            {
                MessageBox.Show("Failed :(");
            }
        }
    }
}
