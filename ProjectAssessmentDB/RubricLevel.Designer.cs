namespace ProjectAssessmentDB
{
    partial class RubricLevel
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
            this.labelRubricId = new System.Windows.Forms.Label();
            this.labelRubricDetail = new System.Windows.Forms.Label();
            this.labelRubricLevel = new System.Windows.Forms.Label();
            this.txtRubricDetail = new System.Windows.Forms.TextBox();
            this.comboRubricId = new System.Windows.Forms.ComboBox();
            this.comboRubricLevel = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnaddRubricLevel = new System.Windows.Forms.Button();
            this.btnRubricLevelUpdate = new System.Windows.Forms.Button();
            this.btnRubricLevelDelete = new System.Windows.Forms.Button();
            this.projectBDataSet1 = new ProjectAssessmentDB.ProjectBDataSet1();
            this.projectBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubricLevelDataSet = new ProjectAssessmentDB.RubricLevelDataSet();
            this.rubricLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubricLevelTableAdapter = new ProjectAssessmentDB.RubricLevelDataSetTableAdapters.RubricLevelTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SideNav.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).BeginInit();
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
            this.btnStudentResult.TabIndex = 6;
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
            this.UpperNavText.Location = new System.Drawing.Point(284, 20);
            this.UpperNavText.Name = "UpperNavText";
            this.UpperNavText.Size = new System.Drawing.Size(170, 34);
            this.UpperNavText.TabIndex = 0;
            this.UpperNavText.Text = "Rubric Level";
            this.UpperNavText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRubricId
            // 
            this.labelRubricId.AutoSize = true;
            this.labelRubricId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelRubricId.Location = new System.Drawing.Point(275, 116);
            this.labelRubricId.Name = "labelRubricId";
            this.labelRubricId.Size = new System.Drawing.Size(85, 24);
            this.labelRubricId.TabIndex = 4;
            this.labelRubricId.Text = "Rubric Id";
            // 
            // labelRubricDetail
            // 
            this.labelRubricDetail.AutoSize = true;
            this.labelRubricDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelRubricDetail.Location = new System.Drawing.Point(275, 226);
            this.labelRubricDetail.Name = "labelRubricDetail";
            this.labelRubricDetail.Size = new System.Drawing.Size(116, 24);
            this.labelRubricDetail.TabIndex = 5;
            this.labelRubricDetail.Text = "Rubric Detail";
            // 
            // labelRubricLevel
            // 
            this.labelRubricLevel.AutoSize = true;
            this.labelRubricLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelRubricLevel.Location = new System.Drawing.Point(275, 171);
            this.labelRubricLevel.Name = "labelRubricLevel";
            this.labelRubricLevel.Size = new System.Drawing.Size(176, 24);
            this.labelRubricLevel.TabIndex = 6;
            this.labelRubricLevel.Text = "Measurement Level";
            // 
            // txtRubricDetail
            // 
            this.txtRubricDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtRubricDetail.Location = new System.Drawing.Point(457, 226);
            this.txtRubricDetail.Multiline = true;
            this.txtRubricDetail.Name = "txtRubricDetail";
            this.txtRubricDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRubricDetail.Size = new System.Drawing.Size(485, 24);
            this.txtRubricDetail.TabIndex = 7;
            // 
            // comboRubricId
            // 
            this.comboRubricId.FormattingEnabled = true;
            this.comboRubricId.Location = new System.Drawing.Point(457, 116);
            this.comboRubricId.Name = "comboRubricId";
            this.comboRubricId.Size = new System.Drawing.Size(108, 21);
            this.comboRubricId.TabIndex = 8;
            // 
            // comboRubricLevel
            // 
            this.comboRubricLevel.FormattingEnabled = true;
            this.comboRubricLevel.Items.AddRange(new object[] {
            "Exceptional",
            "Good",
            "Fair",
            "Unsatisfactory"});
            this.comboRubricLevel.Location = new System.Drawing.Point(457, 171);
            this.comboRubricLevel.Name = "comboRubricLevel";
            this.comboRubricLevel.Size = new System.Drawing.Size(107, 21);
            this.comboRubricLevel.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.rubricIdDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.measurementLevelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rubricLevelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(293, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 326);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnaddRubricLevel
            // 
            this.btnaddRubricLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnaddRubricLevel.Location = new System.Drawing.Point(291, 294);
            this.btnaddRubricLevel.Name = "btnaddRubricLevel";
            this.btnaddRubricLevel.Size = new System.Drawing.Size(89, 39);
            this.btnaddRubricLevel.TabIndex = 11;
            this.btnaddRubricLevel.Text = "Add";
            this.btnaddRubricLevel.UseVisualStyleBackColor = true;
            this.btnaddRubricLevel.Click += new System.EventHandler(this.btnaddRubricLevel_Click);
            // 
            // btnRubricLevelUpdate
            // 
            this.btnRubricLevelUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnRubricLevelUpdate.Location = new System.Drawing.Point(408, 295);
            this.btnRubricLevelUpdate.Name = "btnRubricLevelUpdate";
            this.btnRubricLevelUpdate.Size = new System.Drawing.Size(89, 39);
            this.btnRubricLevelUpdate.TabIndex = 12;
            this.btnRubricLevelUpdate.Text = "Update";
            this.btnRubricLevelUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRubricLevelDelete
            // 
            this.btnRubricLevelDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnRubricLevelDelete.Location = new System.Drawing.Point(530, 294);
            this.btnRubricLevelDelete.Name = "btnRubricLevelDelete";
            this.btnRubricLevelDelete.Size = new System.Drawing.Size(89, 40);
            this.btnRubricLevelDelete.TabIndex = 13;
            this.btnRubricLevelDelete.Text = "Delete";
            this.btnRubricLevelDelete.UseVisualStyleBackColor = true;
            // 
            // projectBDataSet1
            // 
            this.projectBDataSet1.DataSetName = "ProjectBDataSet1";
            this.projectBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectBDataSet1BindingSource
            // 
            this.projectBDataSet1BindingSource.DataSource = this.projectBDataSet1;
            this.projectBDataSet1BindingSource.Position = 0;
            // 
            // rubricLevelDataSet
            // 
            this.rubricLevelDataSet.DataSetName = "RubricLevelDataSet";
            this.rubricLevelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubricLevelBindingSource
            // 
            this.rubricLevelBindingSource.DataMember = "RubricLevel";
            this.rubricLevelBindingSource.DataSource = this.rubricLevelDataSet;
            // 
            // rubricLevelTableAdapter
            // 
            this.rubricLevelTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rubricIdDataGridViewTextBoxColumn
            // 
            this.rubricIdDataGridViewTextBoxColumn.DataPropertyName = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.HeaderText = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.Name = "rubricIdDataGridViewTextBoxColumn";
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.Width = 300;
            // 
            // measurementLevelDataGridViewTextBoxColumn
            // 
            this.measurementLevelDataGridViewTextBoxColumn.DataPropertyName = "MeasurementLevel";
            this.measurementLevelDataGridViewTextBoxColumn.HeaderText = "MeasurementLevel";
            this.measurementLevelDataGridViewTextBoxColumn.Name = "measurementLevelDataGridViewTextBoxColumn";
            // 
            // RubricLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 701);
            this.Controls.Add(this.btnRubricLevelDelete);
            this.Controls.Add(this.btnRubricLevelUpdate);
            this.Controls.Add(this.btnaddRubricLevel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboRubricLevel);
            this.Controls.Add(this.comboRubricId);
            this.Controls.Add(this.txtRubricDetail);
            this.Controls.Add(this.labelRubricLevel);
            this.Controls.Add(this.labelRubricDetail);
            this.Controls.Add(this.labelRubricId);
            this.Controls.Add(this.SideNav);
            this.Controls.Add(this.UpperPanel);
            this.MaximizeBox = false;
            this.Name = "RubricLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RubricLevel";
            this.Load += new System.EventHandler(this.RubricLevel_Load);
            this.SideNav.ResumeLayout(false);
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SideNav;
        private System.Windows.Forms.Button btnmanagerubriclevel;
        private System.Windows.Forms.Button btnmanageassessment;
        private System.Windows.Forms.Button btnmanagerubrics;
        private System.Windows.Forms.Button btnmanageclo;
        private System.Windows.Forms.Button btnmanagestudent;
        private System.Windows.Forms.Button btnLogoText;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Label UpperNavText;
        private System.Windows.Forms.Label labelRubricId;
        private System.Windows.Forms.Label labelRubricDetail;
        private System.Windows.Forms.Label labelRubricLevel;
        private System.Windows.Forms.TextBox txtRubricDetail;
        private System.Windows.Forms.ComboBox comboRubricId;
        private System.Windows.Forms.ComboBox comboRubricLevel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnaddRubricLevel;
        private System.Windows.Forms.Button btnRubricLevelUpdate;
        private System.Windows.Forms.Button btnRubricLevelDelete;
        private System.Windows.Forms.Button btnStudentResult;
        private ProjectBDataSet1 projectBDataSet1;
        private System.Windows.Forms.BindingSource projectBDataSet1BindingSource;
        private RubricLevelDataSet rubricLevelDataSet;
        private System.Windows.Forms.BindingSource rubricLevelBindingSource;
        private RubricLevelDataSetTableAdapters.RubricLevelTableAdapter rubricLevelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementLevelDataGridViewTextBoxColumn;
    }
}