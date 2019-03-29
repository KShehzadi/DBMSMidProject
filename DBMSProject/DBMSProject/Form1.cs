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
        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudent a = new AddStudent();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLO c = new CLO();
            c.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rubric r = new Rubric();
            r.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rubric_Level_Form r = new Rubric_Level_Form();
            r.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AssessmentPage a = new AssessmentPage();
            a.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AssessmentComponent a = new AssessmentComponent();
            a.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Classes c = new Classes();
            c.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StudentAttendanceForm s = new StudentAttendanceForm();
            s.Show();
            this.Hide();
        }
    }
}
