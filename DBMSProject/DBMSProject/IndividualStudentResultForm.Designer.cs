namespace DBMSProject
{
    partial class IndividualStudentResultForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Student = new System.Windows.Forms.ComboBox();
            this.btn_displayResult = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentRubricLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObtainedMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.72454F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.27546F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_Student, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_displayResult, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(599, 96);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.linkLabel1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 228);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(599, 119);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Registeration Number of Student";
            // 
            // cb_Student
            // 
            this.cb_Student.FormattingEnabled = true;
            this.cb_Student.Location = new System.Drawing.Point(210, 3);
            this.cb_Student.Name = "cb_Student";
            this.cb_Student.Size = new System.Drawing.Size(220, 21);
            this.cb_Student.TabIndex = 1;
            // 
            // btn_displayResult
            // 
            this.btn_displayResult.Location = new System.Drawing.Point(210, 66);
            this.btn_displayResult.Name = "btn_displayResult";
            this.btn_displayResult.Size = new System.Drawing.Size(160, 23);
            this.btn_displayResult.TabIndex = 2;
            this.btn_displayResult.Text = "Display Result";
            this.btn_displayResult.UseVisualStyleBackColor = true;
            this.btn_displayResult.Click += new System.EventHandler(this.btn_displayResult_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Component,
            this.Rubric,
            this.ComponentMarks,
            this.StudentRubricLevel,
            this.ObtainedMarks});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 93);
            this.dataGridView1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 99);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Index Page";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Component
            // 
            this.Component.HeaderText = "Component";
            this.Component.Name = "Component";
            // 
            // Rubric
            // 
            this.Rubric.HeaderText = "Rubric";
            this.Rubric.Name = "Rubric";
            // 
            // ComponentMarks
            // 
            this.ComponentMarks.HeaderText = "Component Marks";
            this.ComponentMarks.Name = "ComponentMarks";
            // 
            // StudentRubricLevel
            // 
            this.StudentRubricLevel.HeaderText = "StudentRubricLevel";
            this.StudentRubricLevel.Name = "StudentRubricLevel";
            // 
            // ObtainedMarks
            // 
            this.ObtainedMarks.HeaderText = "ObtainedMarkes";
            this.ObtainedMarks.Name = "ObtainedMarks";
            // 
            // IndividualStudentResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 350);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IndividualStudentResultForm";
            this.Text = "IndividualStudentResultForm";
            this.Load += new System.EventHandler(this.IndividualStudentResultForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Student;
        private System.Windows.Forms.Button btn_displayResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubric;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentRubricLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObtainedMarks;
    }
}