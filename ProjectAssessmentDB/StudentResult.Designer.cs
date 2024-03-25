namespace ProjectAssessmentDB
{
    partial class StudentResult
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
            this.SideNav = new System.Windows.Forms.Panel();
            this.btnStudentResult = new System.Windows.Forms.Button();
            this.btnmanagerubriclevel = new System.Windows.Forms.Button();
            this.btnmanageassessment = new System.Windows.Forms.Button();
            this.btnmanagerubrics = new System.Windows.Forms.Button();
            this.btnmanageclo = new System.Windows.Forms.Button();
            this.btnmanagestudent = new System.Windows.Forms.Button();
            this.btnLogoText = new System.Windows.Forms.Button();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.UpperNavText = new System.Windows.Forms.Label();
            this.labelStudent__Result = new System.Windows.Forms.Label();
            this.labelAssessment__Result = new System.Windows.Forms.Label();
            this.labelComponent__Result = new System.Windows.Forms.Label();
            this.labelRubricDetail__Result = new System.Windows.Forms.Label();
            this.labelRubricLevel__Result = new System.Windows.Forms.Label();
            this.labelRubricLevelId__Result = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet8 = new ProjectAssessmentDB.ProjectBDataSet8();
            this.button1 = new System.Windows.Forms.Button();
            this.comboStudent = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet2 = new ProjectAssessmentDB.ProjectBDataSet2();
            this.comboAssessment = new System.Windows.Forms.ComboBox();
            this.assessmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet = new ProjectAssessmentDB.ProjectBDataSet();
            this.comboAssessmentComponent = new System.Windows.Forms.ComboBox();
            this.assessmentComponentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet5 = new ProjectAssessmentDB.ProjectBDataSet5();
            this.comboRubricDetail = new System.Windows.Forms.ComboBox();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet1 = new ProjectAssessmentDB.ProjectBDataSet1();
            this.comboRubricLevel = new System.Windows.Forms.ComboBox();
            this.rubricLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet6 = new ProjectAssessmentDB.ProjectBDataSet6();
            this.comboRubricLevelId = new System.Windows.Forms.ComboBox();
            this.studentTableAdapter = new ProjectAssessmentDB.ProjectBDataSet2TableAdapters.StudentTableAdapter();
            this.assessmentTableAdapter = new ProjectAssessmentDB.ProjectBDataSetTableAdapters.AssessmentTableAdapter();
            this.assessmentComponentTableAdapter = new ProjectAssessmentDB.ProjectBDataSet5TableAdapters.AssessmentComponentTableAdapter();
            this.rubricTableAdapter = new ProjectAssessmentDB.ProjectBDataSet1TableAdapters.RubricTableAdapter();
            this.rubricLevelTableAdapter = new ProjectAssessmentDB.ProjectBDataSet6TableAdapters.RubricLevelTableAdapter();
            this.studentResultTableAdapter = new ProjectAssessmentDB.ProjectBDataSet8TableAdapters.StudentResultTableAdapter();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentComponentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricMeasurementIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assessment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RubricDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RubricLevelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObtainedMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SideNav.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).BeginInit();
            this.SuspendLayout();
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
            this.UpperNavText.Location = new System.Drawing.Point(281, 20);
            this.UpperNavText.Name = "UpperNavText";
            this.UpperNavText.Size = new System.Drawing.Size(202, 34);
            this.UpperNavText.TabIndex = 0;
            this.UpperNavText.Text = "Student Result";
            this.UpperNavText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStudent__Result
            // 
            this.labelStudent__Result.AutoSize = true;
            this.labelStudent__Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelStudent__Result.Location = new System.Drawing.Point(319, 118);
            this.labelStudent__Result.Name = "labelStudent__Result";
            this.labelStudent__Result.Size = new System.Drawing.Size(72, 22);
            this.labelStudent__Result.TabIndex = 4;
            this.labelStudent__Result.Text = "Student";
            // 
            // labelAssessment__Result
            // 
            this.labelAssessment__Result.AutoSize = true;
            this.labelAssessment__Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelAssessment__Result.Location = new System.Drawing.Point(676, 118);
            this.labelAssessment__Result.Name = "labelAssessment__Result";
            this.labelAssessment__Result.Size = new System.Drawing.Size(107, 22);
            this.labelAssessment__Result.TabIndex = 5;
            this.labelAssessment__Result.Text = "Assessment";
            // 
            // labelComponent__Result
            // 
            this.labelComponent__Result.AutoSize = true;
            this.labelComponent__Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelComponent__Result.Location = new System.Drawing.Point(319, 182);
            this.labelComponent__Result.Name = "labelComponent__Result";
            this.labelComponent__Result.Size = new System.Drawing.Size(102, 22);
            this.labelComponent__Result.TabIndex = 6;
            this.labelComponent__Result.Text = "Component";
            // 
            // labelRubricDetail__Result
            // 
            this.labelRubricDetail__Result.AutoSize = true;
            this.labelRubricDetail__Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRubricDetail__Result.Location = new System.Drawing.Point(676, 182);
            this.labelRubricDetail__Result.Name = "labelRubricDetail__Result";
            this.labelRubricDetail__Result.Size = new System.Drawing.Size(113, 22);
            this.labelRubricDetail__Result.TabIndex = 7;
            this.labelRubricDetail__Result.Text = "Rubric Detail";
            // 
            // labelRubricLevel__Result
            // 
            this.labelRubricLevel__Result.AutoSize = true;
            this.labelRubricLevel__Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRubricLevel__Result.Location = new System.Drawing.Point(319, 250);
            this.labelRubricLevel__Result.Name = "labelRubricLevel__Result";
            this.labelRubricLevel__Result.Size = new System.Drawing.Size(110, 22);
            this.labelRubricLevel__Result.TabIndex = 8;
            this.labelRubricLevel__Result.Text = "Rubric Level";
            // 
            // labelRubricLevelId__Result
            // 
            this.labelRubricLevelId__Result.AutoSize = true;
            this.labelRubricLevelId__Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRubricLevelId__Result.Location = new System.Drawing.Point(676, 250);
            this.labelRubricLevelId__Result.Name = "labelRubricLevelId__Result";
            this.labelRubricLevelId__Result.Size = new System.Drawing.Size(129, 22);
            this.labelRubricLevelId__Result.TabIndex = 9;
            this.labelRubricLevelId__Result.Text = "Rubric Level Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.assessmentComponentIdDataGridViewTextBoxColumn,
            this.rubricMeasurementIdDataGridViewTextBoxColumn,
            this.evaluationDateDataGridViewTextBoxColumn,
            this.Assessment,
            this.RubricDetail,
            this.RubricLevelId,
            this.ObtainedMarks});
            this.dataGridView1.DataSource = this.studentResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(265, 398);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(696, 311);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentResultBindingSource
            // 
            this.studentResultBindingSource.DataMember = "StudentResult";
            this.studentResultBindingSource.DataSource = this.projectBDataSet8;
            // 
            // projectBDataSet8
            // 
            this.projectBDataSet8.DataSetName = "ProjectBDataSet8";
            this.projectBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button1.Location = new System.Drawing.Point(323, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "Evaluate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboStudent
            // 
            this.comboStudent.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "FirstName", true));
            this.comboStudent.DataSource = this.studentBindingSource;
            this.comboStudent.DisplayMember = "FirstName";
            this.comboStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboStudent.FormattingEnabled = true;
            this.comboStudent.Location = new System.Drawing.Point(435, 118);
            this.comboStudent.Name = "comboStudent";
            this.comboStudent.Size = new System.Drawing.Size(121, 24);
            this.comboStudent.TabIndex = 14;
            this.comboStudent.ValueMember = "Id";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectBDataSet2;
            // 
            // projectBDataSet2
            // 
            this.projectBDataSet2.DataSetName = "ProjectBDataSet2";
            this.projectBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboAssessment
            // 
            this.comboAssessment.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.assessmentBindingSource, "Title", true));
            this.comboAssessment.DataSource = this.assessmentBindingSource;
            this.comboAssessment.DisplayMember = "Title";
            this.comboAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboAssessment.FormattingEnabled = true;
            this.comboAssessment.Location = new System.Drawing.Point(826, 118);
            this.comboAssessment.Name = "comboAssessment";
            this.comboAssessment.Size = new System.Drawing.Size(121, 24);
            this.comboAssessment.TabIndex = 15;
            this.comboAssessment.ValueMember = "Id";
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
            // comboAssessmentComponent
            // 
            this.comboAssessmentComponent.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.assessmentComponentBindingSource, "Name", true));
            this.comboAssessmentComponent.DataSource = this.assessmentComponentBindingSource;
            this.comboAssessmentComponent.DisplayMember = "Name";
            this.comboAssessmentComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboAssessmentComponent.FormattingEnabled = true;
            this.comboAssessmentComponent.Location = new System.Drawing.Point(435, 182);
            this.comboAssessmentComponent.Name = "comboAssessmentComponent";
            this.comboAssessmentComponent.Size = new System.Drawing.Size(121, 24);
            this.comboAssessmentComponent.TabIndex = 16;
            this.comboAssessmentComponent.ValueMember = "Id";
            // 
            // assessmentComponentBindingSource
            // 
            this.assessmentComponentBindingSource.DataMember = "AssessmentComponent";
            this.assessmentComponentBindingSource.DataSource = this.projectBDataSet5;
            // 
            // projectBDataSet5
            // 
            this.projectBDataSet5.DataSetName = "ProjectBDataSet5";
            this.projectBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboRubricDetail
            // 
            this.comboRubricDetail.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rubricBindingSource, "Details", true));
            this.comboRubricDetail.DataSource = this.rubricBindingSource;
            this.comboRubricDetail.DisplayMember = "Details";
            this.comboRubricDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboRubricDetail.FormattingEnabled = true;
            this.comboRubricDetail.Location = new System.Drawing.Point(826, 181);
            this.comboRubricDetail.Name = "comboRubricDetail";
            this.comboRubricDetail.Size = new System.Drawing.Size(121, 24);
            this.comboRubricDetail.TabIndex = 17;
            this.comboRubricDetail.ValueMember = "Id";
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet1;
            // 
            // projectBDataSet1
            // 
            this.projectBDataSet1.DataSetName = "ProjectBDataSet1";
            this.projectBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboRubricLevel
            // 
            this.comboRubricLevel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rubricLevelBindingSource, "Id", true));
            this.comboRubricLevel.DataSource = this.rubricLevelBindingSource;
            this.comboRubricLevel.DisplayMember = "MeasurementLevel";
            this.comboRubricLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboRubricLevel.FormattingEnabled = true;
            this.comboRubricLevel.Location = new System.Drawing.Point(436, 250);
            this.comboRubricLevel.Name = "comboRubricLevel";
            this.comboRubricLevel.Size = new System.Drawing.Size(121, 24);
            this.comboRubricLevel.TabIndex = 18;
            this.comboRubricLevel.ValueMember = "MeasurementLevel";
            // 
            // rubricLevelBindingSource
            // 
            this.rubricLevelBindingSource.DataMember = "RubricLevel";
            this.rubricLevelBindingSource.DataSource = this.projectBDataSet6;
            // 
            // projectBDataSet6
            // 
            this.projectBDataSet6.DataSetName = "ProjectBDataSet6";
            this.projectBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboRubricLevelId
            // 
            this.comboRubricLevelId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rubricLevelBindingSource, "Id", true));
            this.comboRubricLevelId.DataSource = this.rubricLevelBindingSource;
            this.comboRubricLevelId.DisplayMember = "Id";
            this.comboRubricLevelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboRubricLevelId.FormattingEnabled = true;
            this.comboRubricLevelId.Location = new System.Drawing.Point(826, 250);
            this.comboRubricLevelId.Name = "comboRubricLevelId";
            this.comboRubricLevelId.Size = new System.Drawing.Size(121, 24);
            this.comboRubricLevelId.TabIndex = 19;
            this.comboRubricLevelId.ValueMember = "Id";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // assessmentTableAdapter
            // 
            this.assessmentTableAdapter.ClearBeforeFill = true;
            // 
            // assessmentComponentTableAdapter
            // 
            this.assessmentComponentTableAdapter.ClearBeforeFill = true;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // rubricLevelTableAdapter
            // 
            this.rubricLevelTableAdapter.ClearBeforeFill = true;
            // 
            // studentResultTableAdapter
            // 
            this.studentResultTableAdapter.ClearBeforeFill = true;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StuID";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // assessmentComponentIdDataGridViewTextBoxColumn
            // 
            this.assessmentComponentIdDataGridViewTextBoxColumn.DataPropertyName = "AssessmentComponentId";
            this.assessmentComponentIdDataGridViewTextBoxColumn.HeaderText = "AssesComponentId";
            this.assessmentComponentIdDataGridViewTextBoxColumn.Name = "assessmentComponentIdDataGridViewTextBoxColumn";
            this.assessmentComponentIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // rubricMeasurementIdDataGridViewTextBoxColumn
            // 
            this.rubricMeasurementIdDataGridViewTextBoxColumn.DataPropertyName = "RubricMeasurementId";
            this.rubricMeasurementIdDataGridViewTextBoxColumn.HeaderText = "RubricMeasurementId";
            this.rubricMeasurementIdDataGridViewTextBoxColumn.Name = "rubricMeasurementIdDataGridViewTextBoxColumn";
            // 
            // evaluationDateDataGridViewTextBoxColumn
            // 
            this.evaluationDateDataGridViewTextBoxColumn.DataPropertyName = "EvaluationDate";
            this.evaluationDateDataGridViewTextBoxColumn.HeaderText = "EvaluationDate";
            this.evaluationDateDataGridViewTextBoxColumn.Name = "evaluationDateDataGridViewTextBoxColumn";
            // 
            // Assessment
            // 
            this.Assessment.DataPropertyName = "StudentId";
            this.Assessment.HeaderText = "Assessment";
            this.Assessment.Name = "Assessment";
            // 
            // RubricDetail
            // 
            this.RubricDetail.DataPropertyName = "StudentId";
            this.RubricDetail.HeaderText = "Rubric Detail";
            this.RubricDetail.Name = "RubricDetail";
            // 
            // RubricLevelId
            // 
            this.RubricLevelId.DataPropertyName = "StudentId";
            this.RubricLevelId.HeaderText = "Rubric Level Id";
            this.RubricLevelId.Name = "RubricLevelId";
            this.RubricLevelId.Width = 60;
            // 
            // ObtainedMarks
            // 
            this.ObtainedMarks.DataPropertyName = "StudentId";
            this.ObtainedMarks.HeaderText = "Obtained Marks";
            this.ObtainedMarks.Name = "ObtainedMarks";
            // 
            // StudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 701);
            this.Controls.Add(this.comboRubricLevelId);
            this.Controls.Add(this.comboRubricLevel);
            this.Controls.Add(this.comboRubricDetail);
            this.Controls.Add(this.comboAssessmentComponent);
            this.Controls.Add(this.comboAssessment);
            this.Controls.Add(this.comboStudent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelRubricLevelId__Result);
            this.Controls.Add(this.labelRubricLevel__Result);
            this.Controls.Add(this.labelRubricDetail__Result);
            this.Controls.Add(this.labelComponent__Result);
            this.Controls.Add(this.labelAssessment__Result);
            this.Controls.Add(this.labelStudent__Result);
            this.Controls.Add(this.SideNav);
            this.Controls.Add(this.UpperPanel);
            this.MaximizeBox = false;
            this.Name = "StudentResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentResult";
            this.Load += new System.EventHandler(this.StudentResult_Load);
            this.SideNav.ResumeLayout(false);
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SideNav;
        private System.Windows.Forms.Button btnStudentResult;
        private System.Windows.Forms.Button btnmanagerubriclevel;
        private System.Windows.Forms.Button btnmanageassessment;
        private System.Windows.Forms.Button btnmanagerubrics;
        private System.Windows.Forms.Button btnmanageclo;
        private System.Windows.Forms.Button btnmanagestudent;
        private System.Windows.Forms.Button btnLogoText;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Label UpperNavText;
        private System.Windows.Forms.Label labelStudent__Result;
        private System.Windows.Forms.Label labelAssessment__Result;
        private System.Windows.Forms.Label labelComponent__Result;
        private System.Windows.Forms.Label labelRubricDetail__Result;
        private System.Windows.Forms.Label labelRubricLevel__Result;
        private System.Windows.Forms.Label labelRubricLevelId__Result;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboStudent;
        private System.Windows.Forms.ComboBox comboAssessment;
        private System.Windows.Forms.ComboBox comboAssessmentComponent;
        private System.Windows.Forms.ComboBox comboRubricDetail;
        private System.Windows.Forms.ComboBox comboRubricLevel;
        private System.Windows.Forms.ComboBox comboRubricLevelId;
        private ProjectBDataSet2 projectBDataSet2;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ProjectBDataSet2TableAdapters.StudentTableAdapter studentTableAdapter;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource assessmentBindingSource;
        private ProjectBDataSetTableAdapters.AssessmentTableAdapter assessmentTableAdapter;
        private ProjectBDataSet5 projectBDataSet5;
        private System.Windows.Forms.BindingSource assessmentComponentBindingSource;
        private ProjectBDataSet5TableAdapters.AssessmentComponentTableAdapter assessmentComponentTableAdapter;
        private ProjectBDataSet1 projectBDataSet1;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSet1TableAdapters.RubricTableAdapter rubricTableAdapter;
        private ProjectBDataSet6 projectBDataSet6;
        private System.Windows.Forms.BindingSource rubricLevelBindingSource;
        private ProjectBDataSet6TableAdapters.RubricLevelTableAdapter rubricLevelTableAdapter;
        private ProjectBDataSet8 projectBDataSet8;
        private System.Windows.Forms.BindingSource studentResultBindingSource;
        private ProjectBDataSet8TableAdapters.StudentResultTableAdapter studentResultTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentComponentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricMeasurementIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assessment;
        private System.Windows.Forms.DataGridViewTextBoxColumn RubricDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn RubricLevelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObtainedMarks;
    }
}