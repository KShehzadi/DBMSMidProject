namespace DBMSProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Student = new System.Windows.Forms.LinkLabel();
            this.lbl_clopage = new System.Windows.Forms.LinkLabel();
            this.lbl_rubric = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_Student
            // 
            this.lbl_Student.AutoSize = true;
            this.lbl_Student.Location = new System.Drawing.Point(47, 86);
            this.lbl_Student.Name = "lbl_Student";
            this.lbl_Student.Size = new System.Drawing.Size(137, 13);
            this.lbl_Student.TabIndex = 0;
            this.lbl_Student.TabStop = true;
            this.lbl_Student.Text = "Student Management Page";
            this.lbl_Student.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Student_LinkClicked);
            // 
            // lbl_clopage
            // 
            this.lbl_clopage.AutoSize = true;
            this.lbl_clopage.Location = new System.Drawing.Point(47, 125);
            this.lbl_clopage.Name = "lbl_clopage";
            this.lbl_clopage.Size = new System.Drawing.Size(121, 13);
            this.lbl_clopage.TabIndex = 1;
            this.lbl_clopage.TabStop = true;
            this.lbl_clopage.Text = "CLO Management Page";
            this.lbl_clopage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_clopage_LinkClicked);
            // 
            // lbl_rubric
            // 
            this.lbl_rubric.AutoSize = true;
            this.lbl_rubric.Location = new System.Drawing.Point(47, 170);
            this.lbl_rubric.Name = "lbl_rubric";
            this.lbl_rubric.Size = new System.Drawing.Size(131, 13);
            this.lbl_rubric.TabIndex = 2;
            this.lbl_rubric.TabStop = true;
            this.lbl_rubric.Text = "Rubric Management Page";
            this.lbl_rubric.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_rubric_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(47, 211);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(156, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Assessment Management Page";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(47, 245);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(148, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Assessment Component Page";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(47, 274);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(125, 13);
            this.linkLabel3.TabIndex = 5;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Class Management Page";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 296);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl_rubric);
            this.Controls.Add(this.lbl_clopage);
            this.Controls.Add(this.lbl_Student);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbl_Student;
        private System.Windows.Forms.LinkLabel lbl_clopage;
        private System.Windows.Forms.LinkLabel lbl_rubric;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}

