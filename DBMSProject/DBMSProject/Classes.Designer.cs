namespace DBMSProject
{
    partial class Classes
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
            this.btn_insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_Fetch = new System.Windows.Forms.Button();
            this.projectBDataSet6 = new DBMSProject.ProjectBDataSet6();
            this.classAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classAttendanceTableAdapter = new DBMSProject.ProjectBDataSet6TableAdapters.ClassAttendanceTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Mark_Attendance = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(197, 77);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "Insert Class";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class Date (yyyy-mm-dd)";
            // 
            // tb_Date
            // 
            this.tb_Date.Location = new System.Drawing.Point(172, 32);
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(100, 20);
            this.tb_Date.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.attendanceDateDataGridViewTextBoxColumn,
            this.Action,
            this.Delete,
            this.Mark_Attendance});
            this.dataGridView1.DataSource = this.classAttendanceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 192);
            this.dataGridView1.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(568, 380);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Index Page";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_Fetch
            // 
            this.btn_Fetch.Location = new System.Drawing.Point(548, 333);
            this.btn_Fetch.Name = "btn_Fetch";
            this.btn_Fetch.Size = new System.Drawing.Size(75, 23);
            this.btn_Fetch.TabIndex = 5;
            this.btn_Fetch.Text = "Fetch";
            this.btn_Fetch.UseVisualStyleBackColor = true;
            // 
            // projectBDataSet6
            // 
            this.projectBDataSet6.DataSetName = "ProjectBDataSet6";
            this.projectBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classAttendanceBindingSource
            // 
            this.classAttendanceBindingSource.DataMember = "ClassAttendance";
            this.classAttendanceBindingSource.DataSource = this.projectBDataSet6;
            // 
            // classAttendanceTableAdapter
            // 
            this.classAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendanceDateDataGridViewTextBoxColumn
            // 
            this.attendanceDateDataGridViewTextBoxColumn.DataPropertyName = "AttendanceDate";
            this.attendanceDateDataGridViewTextBoxColumn.HeaderText = "AttendanceDate";
            this.attendanceDateDataGridViewTextBoxColumn.Name = "attendanceDateDataGridViewTextBoxColumn";
            // 
            // Action
            // 
            this.Action.DataPropertyName = "Update";
            this.Action.HeaderText = "Update";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "Update";
            this.Action.ToolTipText = "Update";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Mark_Attendance
            // 
            this.Mark_Attendance.DataPropertyName = "Mark_Attendance";
            this.Mark_Attendance.HeaderText = "Mark Attendance";
            this.Mark_Attendance.Name = "Mark_Attendance";
            this.Mark_Attendance.Text = "Mark Attendance";
            this.Mark_Attendance.ToolTipText = "Mark Attendance";
            this.Mark_Attendance.UseColumnTextForButtonValue = true;
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 402);
            this.Controls.Add(this.btn_Fetch);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_Date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_insert);
            this.Name = "Classes";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.Classes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_Fetch;
        private ProjectBDataSet6 projectBDataSet6;
        private System.Windows.Forms.BindingSource classAttendanceBindingSource;
        private ProjectBDataSet6TableAdapters.ClassAttendanceTableAdapter classAttendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Mark_Attendance;
    }
}