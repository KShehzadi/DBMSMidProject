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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_Student_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddStudent a = new AddStudent();
            a.Show();
            this.Hide();
        }

        private void lbl_clopage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void lbl_rubric_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
}
