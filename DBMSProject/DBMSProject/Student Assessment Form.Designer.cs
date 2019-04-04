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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet8)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Update, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_Refresh, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_GetStudent, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cb_Date, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_AssessmentComponent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_rubriclevel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_Assessment, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_filter, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_MarkAssessment, 2, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 173);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Rubric";
            // 
            // btn_filter
            // 
            this.btn_filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_filter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_filter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_filter.Location = new System.Drawing.Point(258, 116);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(249, 21);
            this.btn_filter.TabIndex = 8;
            this.btn_filter.Text = "Filter Student by Assessment Component";
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Update.Location = new System.Drawing.Point(258, 148);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(249, 21);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_MarkAssessment
            // 
            this.btn_MarkAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MarkAssessment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_MarkAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MarkAssessment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_MarkAssessment.Location = new System.Drawing.Point(513, 148);
            this.btn_MarkAssessment.Name = "btn_MarkAssessment";
            this.btn_MarkAssessment.Size = new System.Drawing.Size(182, 21);
            this.btn_MarkAssessment.TabIndex = 5;
            this.btn_MarkAssessment.Text = "Mark Assessment of All Students";
            this.btn_MarkAssessment.UseVisualStyleBackColor = false;
            this.btn_MarkAssessment.Click += new System.EventHandler(this.btn_MarkAssessment_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(513, 116);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(182, 22);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh Page";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_GetStudent
            // 
            this.btn_GetStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GetStudent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_GetStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GetStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_GetStudent.Location = new System.Drawing.Point(3, 116);
            this.btn_GetStudent.Name = "btn_GetStudent";
            this.btn_GetStudent.Size = new System.Drawing.Size(249, 22);
            this.btn_GetStudent.TabIndex = 4;
            this.btn_GetStudent.Text = "Get Students  for Marking";
            this.btn_GetStudent.UseVisualStyleBackColor = false;
            this.btn_GetStudent.Click += new System.EventHandler(this.btn_GetStudent_Click);
            // 
            // cb_Date
            // 
            this.cb_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Date.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Date.FormattingEnabled = true;
            this.cb_Date.Location = new System.Drawing.Point(258, 86);
            this.cb_Date.Name = "cb_Date";
            this.cb_Date.Size = new System.Drawing.Size(249, 21);
            this.cb_Date.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Assessment Component:";
            // 
            // cb_AssessmentComponent
            // 
            this.cb_AssessmentComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_AssessmentComponent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AssessmentComponent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_AssessmentComponent.FormattingEnabled = true;
            this.cb_AssessmentComponent.Location = new System.Drawing.Point(258, 31);
            this.cb_AssessmentComponent.Name = "cb_AssessmentComponent";
            this.cb_AssessmentComponent.Size = new System.Drawing.Size(249, 21);
            this.cb_AssessmentComponent.TabIndex = 0;
            this.cb_AssessmentComponent.SelectedIndexChanged += new System.EventHandler(this.cb_AssessmentComponent_SelectedIndexChanged);
            // 
            // cb_rubriclevel
            // 
            this.cb_rubriclevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_rubriclevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rubriclevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_rubriclevel.FormattingEnabled = true;
            this.cb_rubriclevel.Location = new System.Drawing.Point(258, 59);
            this.cb_rubriclevel.Name = "cb_rubriclevel";
            this.cb_rubriclevel.Size = new System.Drawing.Size(249, 21);
            this.cb_rubriclevel.TabIndex = 9;
            // 
            // cb_Assessment
            // 
            this.cb_Assessment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Assessment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Assessment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Assessment.FormattingEnabled = true;
            this.cb_Assessment.Location = new System.Drawing.Point(258, 3);
            this.cb_Assessment.Name = "cb_Assessment";
            this.cb_Assessment.Size = new System.Drawing.Size(249, 21);
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
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.linkLabel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 258);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.93549F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.064516F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(715, 174);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(651, 159);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Index Page";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registrationNumberDataGridViewTextBoxColumn,
            this.Rubric_Level,
            this.Assigned_MeasurementLevel,
            this.UpdateAssessment,
            this.Delete});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 153);
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(160, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(460, 37);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(407, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Student Assessment Management Page";
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.BackgroundImage = global::DBMSProject.Properties.Resources.images__11_;
            this.flowLayoutPanel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel9.Location = new System.Drawing.Point(11, 2);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(81, 77);
            this.flowLayoutPanel9.TabIndex = 27;
            // 
            // Student_Assessment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(732, 435);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel9);
            this.MinimumSize = new System.Drawing.Size(748, 474);
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
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
    }
}