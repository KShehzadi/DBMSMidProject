namespace DBMSProject
{
    partial class StudentAttendanceForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.btn_MarkAttendance = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_ClassFiltter = new System.Windows.Forms.Button();
            this.tb_StudentRegisterationNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_AttendanceStatus = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.Attendance_Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.RegisterationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update_Status = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.Attendance_Status,
            this.RegisterationNumber,
            this.AttendanceDate,
            this.Update_Status,
            this.Delete});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 162);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 181);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 191);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(576, 168);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Index Page";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.67901F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.32099F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cb_class, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_MarkAttendance, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn_Update, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn_ClassFiltter, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tb_StudentRegisterationNumber, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cb_AttendanceStatus, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_refresh, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(105, 49);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.15254F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.84746F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(537, 129);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RegisterationNumber";
            // 
            // cb_class
            // 
            this.cb_class.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_class.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Location = new System.Drawing.Point(145, 3);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(164, 21);
            this.cb_class.TabIndex = 2;
            // 
            // btn_MarkAttendance
            // 
            this.btn_MarkAttendance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_MarkAttendance.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_MarkAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MarkAttendance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_MarkAttendance.Location = new System.Drawing.Point(145, 74);
            this.btn_MarkAttendance.Name = "btn_MarkAttendance";
            this.btn_MarkAttendance.Size = new System.Drawing.Size(164, 21);
            this.btn_MarkAttendance.TabIndex = 5;
            this.btn_MarkAttendance.Text = "Mark Attendance";
            this.btn_MarkAttendance.UseVisualStyleBackColor = false;
            this.btn_MarkAttendance.Click += new System.EventHandler(this.btn_MarkAttendance_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Update.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Update.Location = new System.Drawing.Point(321, 74);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(207, 21);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_ClassFiltter
            // 
            this.btn_ClassFiltter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ClassFiltter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ClassFiltter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ClassFiltter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ClassFiltter.Location = new System.Drawing.Point(3, 74);
            this.btn_ClassFiltter.Name = "btn_ClassFiltter";
            this.btn_ClassFiltter.Size = new System.Drawing.Size(136, 21);
            this.btn_ClassFiltter.TabIndex = 4;
            this.btn_ClassFiltter.Text = "Filter by Class Date";
            this.btn_ClassFiltter.UseVisualStyleBackColor = false;
            this.btn_ClassFiltter.Click += new System.EventHandler(this.btn_ClassFiltter_Click);
            // 
            // tb_StudentRegisterationNumber
            // 
            this.tb_StudentRegisterationNumber.Location = new System.Drawing.Point(145, 28);
            this.tb_StudentRegisterationNumber.Name = "tb_StudentRegisterationNumber";
            this.tb_StudentRegisterationNumber.ReadOnly = true;
            this.tb_StudentRegisterationNumber.Size = new System.Drawing.Size(164, 20);
            this.tb_StudentRegisterationNumber.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Attendance Status";
            // 
            // cb_AttendanceStatus
            // 
            this.cb_AttendanceStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_AttendanceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AttendanceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_AttendanceStatus.FormattingEnabled = true;
            this.cb_AttendanceStatus.Location = new System.Drawing.Point(145, 53);
            this.cb_AttendanceStatus.Name = "cb_AttendanceStatus";
            this.cb_AttendanceStatus.Size = new System.Drawing.Size(164, 21);
            this.cb_AttendanceStatus.TabIndex = 9;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_refresh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_refresh.Location = new System.Drawing.Point(145, 102);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(164, 24);
            this.btn_refresh.TabIndex = 10;
            this.btn_refresh.Text = "Refresh Page";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(115, 8);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(518, 38);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Student Attendance Management Page";
            // 
            // Attendance_Status
            // 
            this.Attendance_Status.DataPropertyName = "Attendance_Status";
            this.Attendance_Status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Attendance_Status.HeaderText = "Attendance_Status";
            this.Attendance_Status.Name = "Attendance_Status";
            // 
            // RegisterationNumber
            // 
            this.RegisterationNumber.HeaderText = "RegisterationNumber";
            this.RegisterationNumber.Name = "RegisterationNumber";
            this.RegisterationNumber.ReadOnly = true;
            // 
            // AttendanceDate
            // 
            this.AttendanceDate.HeaderText = "AttendanceDate";
            this.AttendanceDate.Name = "AttendanceDate";
            this.AttendanceDate.ReadOnly = true;
            // 
            // Update_Status
            // 
            this.Update_Status.HeaderText = "Update_Status";
            this.Update_Status.Name = "Update_Status";
            this.Update_Status.Text = "Update_Status";
            this.Update_Status.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.BackgroundImage = global::DBMSProject.Properties.Resources.images__7_1;
            this.flowLayoutPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(2, -2);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(91, 89);
            this.flowLayoutPanel8.TabIndex = 26;
            // 
            // StudentAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(645, 367);
            this.Controls.Add(this.flowLayoutPanel8);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(661, 406);
            this.Name = "StudentAttendanceForm";
            this.Text = "StudentAttendanceForm";
            this.Load += new System.EventHandler(this.StudentAttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_class;
        private System.Windows.Forms.BindingSource studentBindingSource;
       
        private System.Windows.Forms.Button btn_MarkAttendance;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_ClassFiltter;
        private System.Windows.Forms.TextBox tb_StudentRegisterationNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_AttendanceStatus;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Attendance_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceDate;
        private System.Windows.Forms.DataGridViewButtonColumn Update_Status;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
    }
}