namespace ProjectAssessmentDB
{
    partial class StudentAttendance
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
            this.btnmanagerubriclevel = new System.Windows.Forms.Button();
            this.btnmanageassessment = new System.Windows.Forms.Button();
            this.SideNav = new System.Windows.Forms.Panel();
            this.btnmanagerubrics = new System.Windows.Forms.Button();
            this.btnmanageclo = new System.Windows.Forms.Button();
            this.btnmanagestudent = new System.Windows.Forms.Button();
            this.btnLogoText = new System.Windows.Forms.Button();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.UpperNavText = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labrlttendancedate = new System.Windows.Forms.Label();
            this.labelattendancestatus = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnattendancesave = new System.Windows.Forms.Button();
            this.btnStudentResult = new System.Windows.Forms.Button();
            this.SideNav.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmanagerubriclevel
            // 
            this.btnmanagerubriclevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnmanagerubriclevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmanagerubriclevel.FlatAppearance.BorderSize = 0;
            this.btnmanagerubriclevel.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanagerubriclevel.Location = new System.Drawing.Point(0, 360);
            this.btnmanagerubriclevel.Name = "btnmanagerubriclevel";
            this.btnmanagerubriclevel.Size = new System.Drawing.Size(240, 55);
            this.btnmanagerubriclevel.TabIndex = 5;
            this.btnmanagerubriclevel.Text = "Manage Rubric Level";
            this.btnmanagerubriclevel.UseVisualStyleBackColor = false;
            this.btnmanagerubriclevel.Click += new System.EventHandler(this.btnmanagerubriclevel_Click);
            // 
            // btnmanageassessment
            // 
            this.btnmanageassessment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnmanageassessment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmanageassessment.FlatAppearance.BorderSize = 0;
            this.btnmanageassessment.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanageassessment.Location = new System.Drawing.Point(0, 305);
            this.btnmanageassessment.Name = "btnmanageassessment";
            this.btnmanageassessment.Size = new System.Drawing.Size(240, 55);
            this.btnmanageassessment.TabIndex = 4;
            this.btnmanageassessment.Text = "Manage Assessment";
            this.btnmanageassessment.UseVisualStyleBackColor = false;
            this.btnmanageassessment.Click += new System.EventHandler(this.btnmanageassessment_Click);
            // 
            // SideNav
            // 
            this.SideNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(86)))), ((int)(((byte)(255)))));
            this.SideNav.Controls.Add(this.btnStudentResult);
            this.SideNav.Controls.Add(this.btnmanagerubriclevel);
            this.SideNav.Controls.Add(this.btnmanageassessment);
            this.SideNav.Controls.Add(this.btnmanagerubrics);
            this.SideNav.Controls.Add(this.btnmanageclo);
            this.SideNav.Controls.Add(this.btnmanagestudent);
            this.SideNav.Controls.Add(this.btnLogoText);
            this.SideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideNav.Location = new System.Drawing.Point(0, 0);
            this.SideNav.Name = "SideNav";
            this.SideNav.Size = new System.Drawing.Size(240, 721);
            this.SideNav.TabIndex = 2;
            // 
            // btnmanagerubrics
            // 
            this.btnmanagerubrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnmanagerubrics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmanagerubrics.FlatAppearance.BorderSize = 0;
            this.btnmanagerubrics.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanagerubrics.Location = new System.Drawing.Point(0, 250);
            this.btnmanagerubrics.Name = "btnmanagerubrics";
            this.btnmanagerubrics.Size = new System.Drawing.Size(240, 55);
            this.btnmanagerubrics.TabIndex = 3;
            this.btnmanagerubrics.Text = "Manage Rubrics";
            this.btnmanagerubrics.UseVisualStyleBackColor = false;
            this.btnmanagerubrics.Click += new System.EventHandler(this.btnmanagerubrics_Click);
            // 
            // btnmanageclo
            // 
            this.btnmanageclo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnmanageclo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmanageclo.FlatAppearance.BorderSize = 0;
            this.btnmanageclo.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanageclo.Location = new System.Drawing.Point(0, 195);
            this.btnmanageclo.Name = "btnmanageclo";
            this.btnmanageclo.Size = new System.Drawing.Size(240, 55);
            this.btnmanageclo.TabIndex = 2;
            this.btnmanageclo.Text = "Manage CLO";
            this.btnmanageclo.UseVisualStyleBackColor = false;
            this.btnmanageclo.Click += new System.EventHandler(this.btnmanageclo_Click);
            // 
            // btnmanagestudent
            // 
            this.btnmanagestudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnmanagestudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmanagestudent.FlatAppearance.BorderSize = 0;
            this.btnmanagestudent.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanagestudent.Location = new System.Drawing.Point(0, 140);
            this.btnmanagestudent.Name = "btnmanagestudent";
            this.btnmanagestudent.Size = new System.Drawing.Size(240, 55);
            this.btnmanagestudent.TabIndex = 1;
            this.btnmanagestudent.Text = "Manage Student";
            this.btnmanagestudent.UseVisualStyleBackColor = false;
            this.btnmanagestudent.Click += new System.EventHandler(this.btnmanagestudent_Click);
            // 
            // btnLogoText
            // 
            this.btnLogoText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.btnLogoText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogoText.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogoText.FlatAppearance.BorderSize = 0;
            this.btnLogoText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoText.Location = new System.Drawing.Point(0, 0);
            this.btnLogoText.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogoText.Name = "btnLogoText";
            this.btnLogoText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnLogoText.Size = new System.Drawing.Size(240, 140);
            this.btnLogoText.TabIndex = 0;
            this.btnLogoText.Text = "Lab Management System";
            this.btnLogoText.UseVisualStyleBackColor = false;
            this.btnLogoText.Click += new System.EventHandler(this.btnLogoText_Click);
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(198)))), ((int)(((byte)(227)))));
            this.UpperPanel.Controls.Add(this.UpperNavText);
            this.UpperPanel.Location = new System.Drawing.Point(240, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(744, 70);
            this.UpperPanel.TabIndex = 3;
            // 
            // UpperNavText
            // 
            this.UpperNavText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpperNavText.AutoSize = true;
            this.UpperNavText.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpperNavText.ForeColor = System.Drawing.Color.Black;
            this.UpperNavText.Location = new System.Drawing.Point(245, 20);
            this.UpperNavText.Name = "UpperNavText";
            this.UpperNavText.Size = new System.Drawing.Size(267, 34);
            this.UpperNavText.TabIndex = 0;
            this.UpperNavText.Text = "Student Attendance";
            this.UpperNavText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(267, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(332, 523);
            this.dataGridView1.TabIndex = 4;
            // 
            // labrlttendancedate
            // 
            this.labrlttendancedate.AutoSize = true;
            this.labrlttendancedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.labrlttendancedate.Location = new System.Drawing.Point(639, 146);
            this.labrlttendancedate.Name = "labrlttendancedate";
            this.labrlttendancedate.Size = new System.Drawing.Size(76, 31);
            this.labrlttendancedate.TabIndex = 5;
            this.labrlttendancedate.Text = "Date";
            // 
            // labelattendancestatus
            // 
            this.labelattendancestatus.AutoSize = true;
            this.labelattendancestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.labelattendancestatus.Location = new System.Drawing.Point(639, 283);
            this.labelattendancestatus.Name = "labelattendancestatus";
            this.labelattendancestatus.Size = new System.Drawing.Size(98, 31);
            this.labelattendancestatus.TabIndex = 6;
            this.labelattendancestatus.Text = "Status";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(745, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 23);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Leave",
            "Late"});
            this.comboBox1.Location = new System.Drawing.Point(745, 288);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 8;
            // 
            // btnattendancesave
            // 
            this.btnattendancesave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnattendancesave.FlatAppearance.BorderSize = 0;
            this.btnattendancesave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnattendancesave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnattendancesave.Location = new System.Drawing.Point(745, 424);
            this.btnattendancesave.Name = "btnattendancesave";
            this.btnattendancesave.Size = new System.Drawing.Size(80, 38);
            this.btnattendancesave.TabIndex = 9;
            this.btnattendancesave.Text = "Save";
            this.btnattendancesave.UseVisualStyleBackColor = false;
            // 
            // btnStudentResult
            // 
            this.btnStudentResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnStudentResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentResult.FlatAppearance.BorderSize = 0;
            this.btnStudentResult.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentResult.Location = new System.Drawing.Point(0, 415);
            this.btnStudentResult.Name = "btnStudentResult";
            this.btnStudentResult.Size = new System.Drawing.Size(240, 55);
            this.btnStudentResult.TabIndex = 7;
            this.btnStudentResult.Text = "Manage Student Result";
            this.btnStudentResult.UseVisualStyleBackColor = false;
            this.btnStudentResult.Click += new System.EventHandler(this.btnStudentResult_Click);
            // 
            // StudentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 721);
            this.Controls.Add(this.btnattendancesave);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelattendancestatus);
            this.Controls.Add(this.labrlttendancedate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SideNav);
            this.Controls.Add(this.UpperPanel);
            this.MaximizeBox = false;
            this.Name = "StudentAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentAttendance";
            this.Load += new System.EventHandler(this.StudentAttendance_Load);
            this.SideNav.ResumeLayout(false);
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmanagerubriclevel;
        private System.Windows.Forms.Button btnmanageassessment;
        private System.Windows.Forms.Panel SideNav;
        private System.Windows.Forms.Button btnmanagerubrics;
        private System.Windows.Forms.Button btnmanageclo;
        private System.Windows.Forms.Button btnmanagestudent;
        private System.Windows.Forms.Button btnLogoText;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Label UpperNavText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labrlttendancedate;
        private System.Windows.Forms.Label labelattendancestatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnattendancesave;
        private System.Windows.Forms.Button btnStudentResult;
    }
}