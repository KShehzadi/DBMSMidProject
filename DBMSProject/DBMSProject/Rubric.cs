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
    public partial class Rubric : Form
    {
        public static Rubric Rubric1 = new Rubric();
        public Rubric()
        {
            InitializeComponent();
        }

        private void Rubric_Load(object sender, EventArgs e)
        {
            TextBox[] t;
            int i = 4;
            
            int j;
            t = new TextBox[i];
            
            for (j = 0; j < i; j++)
            {
                t[j] = new TextBox();
                t[j].Name = "txtCheckbox" + j.ToString();
                t[j].Text = j.ToString();
                t[j].Height = j;
                Rubric1.Controls.Add(t[j]);

            }

        }
        }
}
