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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace DBMSProject
{
    public partial class IndividualStudent_sCLOReports : Form
    {
        public IndividualStudent_sCLOReports()
        {
            InitializeComponent();
        }

        private void IndividualStudent_sCLOReports_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Connection.buildconnection();



            string queryassessment = "SELECT Id, RegistrationNumber FROM Student";
            SqlDataAdapter da = new SqlDataAdapter(queryassessment, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "student");
            cb_Student.DisplayMember = "RegistrationNumber";
            cb_Student.ValueMember = "Id";
            cb_Student.DataSource = ds.Tables["student"];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btn_CLOReports_Click(object sender, EventArgs e)
        {

           

            DataRowView drv = cb_Student.SelectedItem as DataRowView;
            int studentid = Convert.ToInt32(drv.Row["Id"]);
            if(Connection.GenerateCloReportbyStudentId(studentid))
            {
                MessageBox.Show("Report is Generated here : E:/1A Semesters/6th semester/DBMS Labs.");
            }
            else
            {
                MessageBox.Show("Failed To Generate Report!");
            }

           
        }

        private void btn_Assessment_Click(object sender, EventArgs e)
        {
            DataRowView drv = cb_Student.SelectedItem as DataRowView;
            int studentid = Convert.ToInt32(drv.Row["Id"]);
            if (Connection.GenerateAssessmentReportbyStudentId(studentid))
            {
                MessageBox.Show("Assessment Report is Generated here : E:/1A Semesters/6th semester/DBMS Labs.");
            }
            else
            {
                MessageBox.Show("Failed To Generate Report!");
            }

        }
    }
}
