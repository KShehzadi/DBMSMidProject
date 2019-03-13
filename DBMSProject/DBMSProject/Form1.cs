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
            CLO c = new CLO();
            c.Show();
            this.Hide();
        }

        private void lbl_rubric_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rubric r= new Rubric();
            r.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AssessmentPage a = new AssessmentPage();
            a.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AssessmentComponent a = new AssessmentComponent();
            a.Show();
            this.Hide();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Classes c = new Classes();
            c.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rubric_Level_Form r = new Rubric_Level_Form();
            r.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
