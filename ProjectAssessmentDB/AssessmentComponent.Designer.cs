namespace ProjectAssessmentDB
{
    partial class AssessmentComponent
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
            this.btnmanagerubrics = new System.Windows.Forms.Button();
            this.SideNav = new System.Windows.Forms.Panel();
            this.btnStudentResult = new System.Windows.Forms.Button();
            this.btnmanagerubriclevel = new System.Windows.Forms.Button();
            this.btnmanageassessment = new System.Windows.Forms.Button();
            this.btnmanageclo = new System.Windows.Forms.Button();
            this.btnmanagestudent = new System.Windows.Forms.Button();
            this.btnLogoText = new System.Windows.Forms.Button();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.UpperNavText = new System.Windows.Forms.Label();
            this.labelAssCompName = new System.Windows.Forms.Label();
            this.labelAssCompMarks = new System.Windows.Forms.Label();
            this.labelassessment = new System.Windows.Forms.Label();
            this.labelRubric = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboAssessment = new System.Windows.Forms.ComboBox();
            this.assessmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet = new ProjectAssessmentDB.ProjectBDataSet();
            this.comboRubric = new System.Windows.Forms.ComboBox();
            this.rubricBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet1 = new ProjectAssessmentDB.ProjectBDataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddAssesComp = new System.Windows.Forms.Button();
            this.btnUpdateAssesComp = new System.Windows.Forms.Button();
            this.btnDeleteAssesComp = new System.Windows.Forms.Button();
            this.assessmentTableAdapter = new ProjectAssessmentDB.ProjectBDataSetTableAdapters.AssessmentTableAdapter();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubricTableAdapter = new ProjectAssessmentDB.ProjectBDataSet1TableAdapters.RubricTableAdapter();
            this.projectBDataSet3 = new ProjectAssessmentDB.ProjectBDataSet3();
            this.assessmentComponentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assessmentComponentTableAdapter = new ProjectAssessmentDB.ProjectBDataSet3TableAdapters.AssessmentComponentTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SideNav.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // 
            // UpperNavText
            // 
            this.UpperNavText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpperNavText.AutoSize = true;
            this.UpperNavText.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpperNavText.ForeColor = System.Drawing.Color.Black;
            this.UpperNavText.Location = new System.Drawing.Point(216, 20);
            this.UpperNavText.Name = "UpperNavText";
            this.UpperNavText.Size = new System.Drawing.Size(318, 34);
            this.UpperNavText.TabIndex = 0;
            this.UpperNavText.Text = "Assessment Component";
            this.UpperNavText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAssCompName
            // 
            this.labelAssCompName.AutoSize = true;
            this.labelAssCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelAssCompName.Location = new System.Drawing.Point(323, 126);
            this.labelAssCompName.Name = "labelAssCompName";
            this.labelAssCompName.Size = new System.Drawing.Size(64, 25);
            this.labelAssCompName.TabIndex = 4;
            this.labelAssCompName.Text = "Name";
            // 
            // labelAssCompMarks
            // 
            this.labelAssCompMarks.AutoSize = true;
            this.labelAssCompMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelAssCompMarks.Location = new System.Drawing.Point(687, 125);
            this.labelAssCompMarks.Name = "labelAssCompMarks";
            this.labelAssCompMarks.Size = new System.Drawing.Size(115, 25);
            this.labelAssCompMarks.TabIndex = 5;
            this.labelAssCompMarks.Text = "Total Marks";
            // 
            // labelassessment
            // 
            this.labelassessment.AutoSize = true;
            this.labelassessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelassessment.Location = new System.Drawing.Point(326, 195);
            this.labelassessment.Name = "labelassessment";
            this.labelassessment.Size = new System.Drawing.Size(120, 25);
            this.labelassessment.TabIndex = 6;
            this.labelassessment.Text = "Assessment";
            // 
            // labelRubric
            // 
            this.labelRubric.AutoSize = true;
            this.labelRubric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelRubric.Location = new System.Drawing.Point(690, 194);
            this.labelRubric.Name = "labelRubric";
            this.labelRubric.Size = new System.Drawing.Size(67, 25);
            this.labelRubric.TabIndex = 7;
            this.labelRubric.Text = "Rubric";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(462, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 23);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(827, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 23);
            this.textBox2.TabIndex = 9;
            // 
            // comboAssessment
            // 
            this.comboAssessment.DataSource = this.assessmentBindingSource;
            this.comboAssessment.DisplayMember = "Title";
            this.comboAssessment.FormattingEnabled = true;
            this.comboAssessment.Location = new System.Drawing.Point(466, 197);
            this.comboAssessment.Name = "comboAssessment";
            this.comboAssessment.Size = new System.Drawing.Size(138, 21);
            this.comboAssessment.TabIndex = 10;
            // 
            // assessmentBindingSource
            // 
            this.assessmentBindingSource.DataMember = "Assessment";
            this.assessmentBindingSource.DataSource = this.projectBDataSet;
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboRubric
            // 
            this.comboRubric.DataSource = this.rubricBindingSource1;
            this.comboRubric.DisplayMember = "Id";
            this.comboRubric.FormattingEnabled = true;
            this.comboRubric.Location = new System.Drawing.Point(827, 196);
            this.comboRubric.Name = "comboRubric";
            this.comboRubric.Size = new System.Drawing.Size(121, 21);
            this.comboRubric.TabIndex = 11;
            // 
            // rubricBindingSource1
            // 
            this.rubricBindingSource1.DataMember = "Rubric";
            this.rubricBindingSource1.DataSource = this.projectBDataSet1;
            // 
            // projectBDataSet1
            // 
            this.projectBDataSet1.DataSetName = "ProjectBDataSet1";
            this.projectBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.rubricIdDataGridViewTextBoxColumn,
            this.totalMarksDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.dateUpdatedDataGridViewTextBoxColumn,
            this.assessmentIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assessmentComponentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(289, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 306);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAddAssesComp
            // 
            this.btnAddAssesComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddAssesComp.Location = new System.Drawing.Point(827, 271);
            this.btnAddAssesComp.Name = "btnAddAssesComp";
            this.btnAddAssesComp.Size = new System.Drawing.Size(82, 34);
            this.btnAddAssesComp.TabIndex = 13;
            this.btnAddAssesComp.Text = "Add";
            this.btnAddAssesComp.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAssesComp
            // 
            this.btnUpdateAssesComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdateAssesComp.Location = new System.Drawing.Point(364, 676);
            this.btnUpdateAssesComp.Name = "btnUpdateAssesComp";
            this.btnUpdateAssesComp.Size = new System.Drawing.Size(82, 34);
            this.btnUpdateAssesComp.TabIndex = 14;
            this.btnUpdateAssesComp.Text = "Update";
            this.btnUpdateAssesComp.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAssesComp
            // 
            this.btnDeleteAssesComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeleteAssesComp.Location = new System.Drawing.Point(785, 676);
            this.btnDeleteAssesComp.Name = "btnDeleteAssesComp";
            this.btnDeleteAssesComp.Size = new System.Drawing.Size(82, 34);
            this.btnDeleteAssesComp.TabIndex = 15;
            this.btnDeleteAssesComp.Text = "Delete";
            this.btnDeleteAssesComp.UseVisualStyleBackColor = true;
            // 
            // assessmentTableAdapter
            // 
            this.assessmentTableAdapter.ClearBeforeFill = true;
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet1;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // projectBDataSet3
            // 
            this.projectBDataSet3.DataSetName = "ProjectBDataSet3";
            this.projectBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentComponentBindingSource
            // 
            this.assessmentComponentBindingSource.DataMember = "AssessmentComponent";
            this.assessmentComponentBindingSource.DataSource = this.projectBDataSet3;
            // 
            // assessmentComponentTableAdapter
            // 
            this.assessmentComponentTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // rubricIdDataGridViewTextBoxColumn
            // 
            this.rubricIdDataGridViewTextBoxColumn.DataPropertyName = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.HeaderText = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.Name = "rubricIdDataGridViewTextBoxColumn";
            // 
            // totalMarksDataGridViewTextBoxColumn
            // 
            this.totalMarksDataGridViewTextBoxColumn.DataPropertyName = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.HeaderText = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.Name = "totalMarksDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // dateUpdatedDataGridViewTextBoxColumn
            // 
            this.dateUpdatedDataGridViewTextBoxColumn.DataPropertyName = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.HeaderText = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.Name = "dateUpdatedDataGridViewTextBoxColumn";
            // 
            // assessmentIdDataGridViewTextBoxColumn
            // 
            this.assessmentIdDataGridViewTextBoxColumn.DataPropertyName = "AssessmentId";
            this.assessmentIdDataGridViewTextBoxColumn.HeaderText = "AssessmentId";
            this.assessmentIdDataGridViewTextBoxColumn.Name = "assessmentIdDataGridViewTextBoxColumn";
            // 
            // AssessmentComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 701);
            this.Controls.Add(this.btnDeleteAssesComp);
            this.Controls.Add(this.btnUpdateAssesComp);
            this.Controls.Add(this.btnAddAssesComp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboRubric);
            this.Controls.Add(this.comboAssessment);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelRubric);
            this.Controls.Add(this.labelassessment);
            this.Controls.Add(this.labelAssCompMarks);
            this.Controls.Add(this.labelAssCompName);
            this.Controls.Add(this.SideNav);
            this.Controls.Add(this.UpperPanel);
            this.MaximizeBox = false;
            this.Name = "AssessmentComponent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssessmentComponent";
            this.Load += new System.EventHandler(this.AssessmentComponent_Load);
            this.SideNav.ResumeLayout(false);
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmanagerubrics;
        private System.Windows.Forms.Panel SideNav;
        private System.Windows.Forms.Button btnmanagerubriclevel;
        private System.Windows.Forms.Button btnmanageassessment;
        private System.Windows.Forms.Button btnmanageclo;
        private System.Windows.Forms.Button btnmanagestudent;
        private System.Windows.Forms.Button btnLogoText;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Label UpperNavText;
        private System.Windows.Forms.Label labelAssCompName;
        private System.Windows.Forms.Label labelAssCompMarks;
        private System.Windows.Forms.Label labelassessment;
        private System.Windows.Forms.Label labelRubric;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboAssessment;
        private System.Windows.Forms.ComboBox comboRubric;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddAssesComp;
        private System.Windows.Forms.Button btnUpdateAssesComp;
        private System.Windows.Forms.Button btnDeleteAssesComp;
        private System.Windows.Forms.Button btnStudentResult;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource assessmentBindingSource;
        private ProjectBDataSetTableAdapters.AssessmentTableAdapter assessmentTableAdapter;
        private ProjectBDataSet1 projectBDataSet1;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSet1TableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.BindingSource rubricBindingSource1;
        private ProjectBDataSet3 projectBDataSet3;
        private System.Windows.Forms.BindingSource assessmentComponentBindingSource;
        private ProjectBDataSet3TableAdapters.AssessmentComponentTableAdapter assessmentComponentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentIdDataGridViewTextBoxColumn;
    }
}