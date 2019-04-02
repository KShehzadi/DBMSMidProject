namespace DBMSProject
{
    partial class Student_Assessment_Form
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_MarkAssessment = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_GetStudent = new System.Windows.Forms.Button();
            this.cb_Date = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_AssessmentComponent = new System.Windows.Forms.ComboBox();
            this.cb_rubriclevel = new System.Windows.Forms.ComboBox();
            this.cb_Assessment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubric_Level = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Assigned_MeasurementLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateAssessment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet8 = new DBMSProject.ProjectBDataSet8();
            this.studentTableAdapter = new DBMSProject.ProjectBDataSet8TableAdapters.StudentTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_filter, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_Update, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_MarkAssessment, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_Refresh, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_GetStudent, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cb_Date, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_AssessmentComponent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_rubriclevel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_Assessment, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 166);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Rubric";
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(3, 142);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(242, 21);
            this.btn_filter.TabIndex = 8;
            this.btn_filter.Text = "Filter Student by Assessment";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(251, 142);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(242, 21);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_MarkAssessment
            // 
            this.btn_MarkAssessment.Location = new System.Drawing.Point(499, 142);
            this.btn_MarkAssessment.Name = "btn_MarkAssessment";
            this.btn_MarkAssessment.Size = new System.Drawing.Size(182, 21);
            this.btn_MarkAssessment.TabIndex = 5;
            this.btn_MarkAssessment.Text = "Mark Assessment of All Students";
            this.btn_MarkAssessment.UseVisualStyleBackColor = true;
            this.btn_MarkAssessment.Click += new System.EventHandler(this.btn_MarkAssessment_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(499, 110);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(182, 22);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh Page";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_GetStudent
            // 
            this.btn_GetStudent.Location = new System.Drawing.Point(3, 110);
            this.btn_GetStudent.Name = "btn_GetStudent";
            this.btn_GetStudent.Size = new System.Drawing.Size(242, 22);
            this.btn_GetStudent.TabIndex = 4;
            this.btn_GetStudent.Text = "Get Students  for Marking";
            this.btn_GetStudent.UseVisualStyleBackColor = true;
            this.btn_GetStudent.Click += new System.EventHandler(this.btn_GetStudent_Click);
            // 
            // cb_Date
            // 
            this.cb_Date.FormattingEnabled = true;
            this.cb_Date.Location = new System.Drawing.Point(251, 80);
            this.cb_Date.Name = "cb_Date";
            this.cb_Date.Size = new System.Drawing.Size(242, 21);
            this.cb_Date.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Assessment Component:";
            // 
            // cb_AssessmentComponent
            // 
            this.cb_AssessmentComponent.FormattingEnabled = true;
            this.cb_AssessmentComponent.Location = new System.Drawing.Point(251, 28);
            this.cb_AssessmentComponent.Name = "cb_AssessmentComponent";
            this.cb_AssessmentComponent.Size = new System.Drawing.Size(242, 21);
            this.cb_AssessmentComponent.TabIndex = 0;
            this.cb_AssessmentComponent.SelectedIndexChanged += new System.EventHandler(this.cb_AssessmentComponent_SelectedIndexChanged);
            // 
            // cb_rubriclevel
            // 
            this.cb_rubriclevel.FormattingEnabled = true;
            this.cb_rubriclevel.Location = new System.Drawing.Point(251, 53);
            this.cb_rubriclevel.Name = "cb_rubriclevel";
            this.cb_rubriclevel.Size = new System.Drawing.Size(242, 21);
            this.cb_rubriclevel.TabIndex = 9;
            // 
            // cb_Assessment
            // 
            this.cb_Assessment.FormattingEnabled = true;
            this.cb_Assessment.Location = new System.Drawing.Point(251, 3);
            this.cb_Assessment.Name = "cb_Assessment";
            this.cb_Assessment.Size = new System.Drawing.Size(242, 21);
            this.cb_Assessment.TabIndex = 11;
            this.cb_Assessment.SelectedIndexChanged += new System.EventHandler(this.cb_Assessment_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Assessment:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.linkLabel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 198);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.53846F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.46154F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(701, 156);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 134);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Index Page";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registrationNumberDataGridViewTextBoxColumn,
            this.Rubric_Level,
            this.Assigned_MeasurementLevel,
            this.UpdateAssessment,
            this.Delete});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 128);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            this.registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.HeaderText = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            // 
            // Rubric_Level
            // 
            this.Rubric_Level.DataPropertyName = "Rubric_Level";
            this.Rubric_Level.HeaderText = "Rubric_Level";
            this.Rubric_Level.Name = "Rubric_Level";
            // 
            // Assigned_MeasurementLevel
            // 
            this.Assigned_MeasurementLevel.HeaderText = "Assigned_MeasurementLevel";
            this.Assigned_MeasurementLevel.Name = "Assigned_MeasurementLevel";
            this.Assigned_MeasurementLevel.ReadOnly = true;
            // 
            // UpdateAssessment
            // 
            this.UpdateAssessment.HeaderText = "UpdateAssessment";
            this.UpdateAssessment.Name = "UpdateAssessment";
            this.UpdateAssessment.Text = "UpdateAssessment";
            this.UpdateAssessment.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectBDataSet8;
            // 
            // projectBDataSet8
            // 
            this.projectBDataSet8.DataSetName = "ProjectBDataSet8";
            this.projectBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // Student_Assessment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 355);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Student_Assessment_Form";
            this.Text = "Student_Assessment_Form";
            this.Load += new System.EventHandler(this.Student_Assessment_Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cb_AssessmentComponent;
        private System.Windows.Forms.ComboBox cb_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_GetStudent;
        private System.Windows.Forms.Button btn_MarkAssessment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Refresh;
        private ProjectBDataSet8 projectBDataSet8;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ProjectBDataSet8TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.ComboBox cb_rubriclevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Assessment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Rubric_Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assigned_MeasurementLevel;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateAssessment;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}