namespace ProjectAssessmentDB
{
    partial class Student
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
            this.btnmanagerubriclevel = new System.Windows.Forms.Button();
            this.btnmanageassessment = new System.Windows.Forms.Button();
            this.btnmanagerubrics = new System.Windows.Forms.Button();
            this.SideNav = new System.Windows.Forms.Panel();
            this.btnStudentResult = new System.Windows.Forms.Button();
            this.btnmanageclo = new System.Windows.Forms.Button();
            this.btnmanagestudent = new System.Windows.Forms.Button();
            this.btnLogoText = new System.Windows.Forms.Button();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.UpperNavText = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBMidProjectDataSet = new ProjectAssessmentDB.DBMidProjectDataSet();
            this.textFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textRegNo = new System.Windows.Forms.TextBox();
            this.textContact = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelregno = new System.Windows.Forms.Label();
            this.labelcontact = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labelstatus = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.studentTableAdapter = new ProjectAssessmentDB.DBMidProjectDataSetTableAdapters.StudentTableAdapter();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SideNav.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMidProjectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmanagerubriclevel
            // 
            this.btnmanagerubriclevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnmanagerubriclevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmanagerubriclevel.FlatAppearance.BorderSize = 0;
            this.btnmanagerubriclevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnmanageassessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanageassessment.Location = new System.Drawing.Point(0, 305);
            this.btnmanageassessment.Name = "btnmanageassessment";
            this.btnmanageassessment.Size = new System.Drawing.Size(240, 55);
            this.btnmanageassessment.TabIndex = 4;
            this.btnmanageassessment.Text = "Manage Assessment";
            this.btnmanageassessment.UseVisualStyleBackColor = false;
            this.btnmanageassessment.Click += new System.EventHandler(this.btnmanageassessment_Click);
            // 
            // btnmanagerubrics
            // 
            this.btnmanagerubrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnmanagerubrics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmanagerubrics.FlatAppearance.BorderSize = 0;
            this.btnmanagerubrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanagerubrics.Location = new System.Drawing.Point(0, 250);
            this.btnmanagerubrics.Name = "btnmanagerubrics";
            this.btnmanagerubrics.Size = new System.Drawing.Size(240, 55);
            this.btnmanagerubrics.TabIndex = 3;
            this.btnmanagerubrics.Text = "Manage Rubrics";
            this.btnmanagerubrics.UseVisualStyleBackColor = false;
            this.btnmanagerubrics.Click += new System.EventHandler(this.btnmanagerubrics_Click);
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
            this.SideNav.Size = new System.Drawing.Size(240, 701);
            this.SideNav.TabIndex = 2;
            this.SideNav.Paint += new System.Windows.Forms.PaintEventHandler(this.SideNav_Paint);
            // 
            // btnStudentResult
            // 
            this.btnStudentResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnStudentResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentResult.FlatAppearance.BorderSize = 0;
            this.btnStudentResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentResult.Location = new System.Drawing.Point(0, 415);
            this.btnStudentResult.Name = "btnStudentResult";
            this.btnStudentResult.Size = new System.Drawing.Size(240, 55);
            this.btnStudentResult.TabIndex = 7;
            this.btnStudentResult.Text = "Manage Student Result";
            this.btnStudentResult.UseVisualStyleBackColor = false;
            this.btnStudentResult.Click += new System.EventHandler(this.btnStudentResult_Click);
            // 
            // btnmanageclo
            // 
            this.btnmanageclo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnmanageclo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmanageclo.FlatAppearance.BorderSize = 0;
            this.btnmanageclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnmanagestudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmanagestudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.UpperPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UpperPanel_Paint);
            // 
            // UpperNavText
            // 
            this.UpperNavText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpperNavText.AutoSize = true;
            this.UpperNavText.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpperNavText.ForeColor = System.Drawing.Color.Black;
            this.UpperNavText.Location = new System.Drawing.Point(277, 20);
            this.UpperNavText.Name = "UpperNavText";
            this.UpperNavText.Size = new System.Drawing.Size(211, 34);
            this.UpperNavText.TabIndex = 0;
            this.UpperNavText.Text = "Student Details";
            this.UpperNavText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpperNavText.Click += new System.EventHandler(this.UpperNavText_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.registrationNumberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(258, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 384);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.dBMidProjectDataSet;
            // 
            // dBMidProjectDataSet
            // 
            this.dBMidProjectDataSet.DataSetName = "DBMidProjectDataSet";
            this.dBMidProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textFirstname
            // 
            this.textFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textFirstname.Location = new System.Drawing.Point(442, 103);
            this.textFirstname.Name = "textFirstname";
            this.textFirstname.Size = new System.Drawing.Size(126, 24);
            this.textFirstname.TabIndex = 4;
            this.textFirstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // textLastname
            // 
            this.textLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textLastname.Location = new System.Drawing.Point(760, 103);
            this.textLastname.Name = "textLastname";
            this.textLastname.Size = new System.Drawing.Size(139, 24);
            this.textLastname.TabIndex = 6;
            this.textLastname.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(643, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // textRegNo
            // 
            this.textRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textRegNo.Location = new System.Drawing.Point(442, 140);
            this.textRegNo.Name = "textRegNo";
            this.textRegNo.Size = new System.Drawing.Size(126, 24);
            this.textRegNo.TabIndex = 8;
            // 
            // textContact
            // 
            this.textContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textContact.Location = new System.Drawing.Point(760, 140);
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(139, 24);
            this.textContact.TabIndex = 9;
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textEmail.Location = new System.Drawing.Point(442, 184);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(126, 24);
            this.textEmail.TabIndex = 10;
            this.textEmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelregno
            // 
            this.labelregno.AutoSize = true;
            this.labelregno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelregno.Location = new System.Drawing.Point(295, 142);
            this.labelregno.Name = "labelregno";
            this.labelregno.Size = new System.Drawing.Size(139, 22);
            this.labelregno.TabIndex = 11;
            this.labelregno.Text = "Registration No.";
            this.labelregno.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelcontact
            // 
            this.labelcontact.AutoSize = true;
            this.labelcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelcontact.Location = new System.Drawing.Point(643, 142);
            this.labelcontact.Name = "labelcontact";
            this.labelcontact.Size = new System.Drawing.Size(72, 22);
            this.labelcontact.TabIndex = 12;
            this.labelcontact.Text = "Contact";
            this.labelcontact.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelemail.Location = new System.Drawing.Point(295, 186);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(54, 22);
            this.labelemail.TabIndex = 13;
            this.labelemail.Text = "Email";
            this.labelemail.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelstatus.Location = new System.Drawing.Point(643, 186);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(61, 22);
            this.labelstatus.TabIndex = 14;
            this.labelstatus.Text = "Status";
            // 
            // comboStatus
            // 
            this.comboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboStatus.Location = new System.Drawing.Point(760, 186);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(139, 28);
            this.comboStatus.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(816, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Mark Attendance";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(258, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 40);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add Student";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnupdate.Location = new System.Drawing.Point(442, 250);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(147, 40);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.Text = "Update Student";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btndelete.Location = new System.Drawing.Point(635, 250);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(147, 40);
            this.btndelete.TabIndex = 19;
            this.btndelete.Text = "Delete Student";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            this.registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.HeaderText = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 701);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.labelstatus);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labelcontact);
            this.Controls.Add(this.labelregno);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textContact);
            this.Controls.Add(this.textRegNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textLastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFirstname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SideNav);
            this.Controls.Add(this.UpperPanel);
            this.MaximizeBox = false;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.SideNav.ResumeLayout(false);
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMidProjectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmanagerubriclevel;
        private System.Windows.Forms.Button btnmanageassessment;
        private System.Windows.Forms.Button btnmanagerubrics;
        private System.Windows.Forms.Panel SideNav;
        private System.Windows.Forms.Button btnmanageclo;
        private System.Windows.Forms.Button btnmanagestudent;
        private System.Windows.Forms.Button btnLogoText;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Label UpperNavText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textRegNo;
        private System.Windows.Forms.TextBox textContact;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelregno;
        private System.Windows.Forms.Label labelcontact;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnStudentResult;
        private DBMidProjectDataSet dBMidProjectDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DBMidProjectDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}