﻿namespace ProjectAssessmentDB
{
    partial class Rubric
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
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.UpperNavText = new System.Windows.Forms.Label();
            this.btnLogoText = new System.Windows.Forms.Button();
            this.SideNav = new System.Windows.Forms.Panel();
            this.btnStudentResult = new System.Windows.Forms.Button();
            this.btnmanagerubriclevel = new System.Windows.Forms.Button();
            this.btnmanageassessment = new System.Windows.Forms.Button();
            this.btnmanagerubrics = new System.Windows.Forms.Button();
            this.btnmanageclo = new System.Windows.Forms.Button();
            this.btnmanagestudent = new System.Windows.Forms.Button();
            this.labelCLOId = new System.Windows.Forms.Label();
            this.labelRubricDetail = new System.Windows.Forms.Label();
            this.labelRubricId = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboCLOId = new System.Windows.Forms.ComboBox();
            this.cloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet3 = new ProjectAssessmentDB.ProjectBDataSet3();
            this.cloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet1 = new ProjectAssessmentDB.ProjectBDataSet1();
            this.buttonAddRubric = new System.Windows.Forms.Button();
            this.btnUpdateRubric = new System.Windows.Forms.Button();
            this.btnDeleteRubric = new System.Windows.Forms.Button();
            this.cloTableAdapter = new ProjectAssessmentDB.ProjectBDataSet3TableAdapters.CloTableAdapter();
            this.rubricTableAdapter = new ProjectAssessmentDB.ProjectBDataSet1TableAdapters.RubricTableAdapter();
            this.UpperPanel.SuspendLayout();
            this.SideNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(198)))), ((int)(((byte)(227)))));
            this.UpperPanel.Controls.Add(this.UpperNavText);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.UpperNavText.Location = new System.Drawing.Point(347, 20);
            this.UpperNavText.Name = "UpperNavText";
            this.UpperNavText.Size = new System.Drawing.Size(97, 34);
            this.UpperNavText.TabIndex = 0;
            this.UpperNavText.Text = "Rubric";
            this.UpperNavText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // labelCLOId
            // 
            this.labelCLOId.AutoSize = true;
            this.labelCLOId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelCLOId.Location = new System.Drawing.Point(275, 118);
            this.labelCLOId.Name = "labelCLOId";
            this.labelCLOId.Size = new System.Drawing.Size(66, 22);
            this.labelCLOId.TabIndex = 4;
            this.labelCLOId.Text = "CLO Id";
            // 
            // labelRubricDetail
            // 
            this.labelRubricDetail.AutoSize = true;
            this.labelRubricDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRubricDetail.Location = new System.Drawing.Point(275, 173);
            this.labelRubricDetail.Name = "labelRubricDetail";
            this.labelRubricDetail.Size = new System.Drawing.Size(113, 22);
            this.labelRubricDetail.TabIndex = 5;
            this.labelRubricDetail.Text = "Rubric Detail";
            // 
            // labelRubricId
            // 
            this.labelRubricId.AutoSize = true;
            this.labelRubricId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRubricId.Location = new System.Drawing.Point(275, 228);
            this.labelRubricId.Name = "labelRubricId";
            this.labelRubricId.Size = new System.Drawing.Size(81, 22);
            this.labelRubricId.TabIndex = 6;
            this.labelRubricId.Text = "Rubric Id";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(396, 224);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 26);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(396, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboCLOId
            // 
            this.comboCLOId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cloBindingSource1, "Id", true));
            this.comboCLOId.DataSource = this.cloBindingSource;
            this.comboCLOId.DisplayMember = "Id";
            this.comboCLOId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboCLOId.FormattingEnabled = true;
            this.comboCLOId.Location = new System.Drawing.Point(394, 115);
            this.comboCLOId.Name = "comboCLOId";
            this.comboCLOId.Size = new System.Drawing.Size(121, 28);
            this.comboCLOId.TabIndex = 9;
            this.comboCLOId.ValueMember = "Id";
            this.comboCLOId.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cloBindingSource1
            // 
            this.cloBindingSource1.DataMember = "Clo";
            this.cloBindingSource1.DataSource = this.projectBDataSet3;
            // 
            // projectBDataSet3
            // 
            this.projectBDataSet3.DataSetName = "ProjectBDataSet3";
            this.projectBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cloBindingSource
            // 
            this.cloBindingSource.DataMember = "Clo";
            this.cloBindingSource.DataSource = this.projectBDataSet3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.cloIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rubricBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(544, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 233);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 120;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.Width = 130;
            // 
            // cloIdDataGridViewTextBoxColumn
            // 
            this.cloIdDataGridViewTextBoxColumn.DataPropertyName = "CloId";
            this.cloIdDataGridViewTextBoxColumn.HeaderText = "CloId";
            this.cloIdDataGridViewTextBoxColumn.Name = "cloIdDataGridViewTextBoxColumn";
            this.cloIdDataGridViewTextBoxColumn.Width = 130;
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
            // buttonAddRubric
            // 
            this.buttonAddRubric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAddRubric.Location = new System.Drawing.Point(419, 293);
            this.buttonAddRubric.Name = "buttonAddRubric";
            this.buttonAddRubric.Size = new System.Drawing.Size(96, 39);
            this.buttonAddRubric.TabIndex = 11;
            this.buttonAddRubric.Text = "Add";
            this.buttonAddRubric.UseVisualStyleBackColor = true;
            this.buttonAddRubric.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdateRubric
            // 
            this.btnUpdateRubric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdateRubric.Location = new System.Drawing.Point(593, 394);
            this.btnUpdateRubric.Name = "btnUpdateRubric";
            this.btnUpdateRubric.Size = new System.Drawing.Size(96, 39);
            this.btnUpdateRubric.TabIndex = 12;
            this.btnUpdateRubric.Text = "Update";
            this.btnUpdateRubric.UseVisualStyleBackColor = true;
            this.btnUpdateRubric.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeleteRubric
            // 
            this.btnDeleteRubric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeleteRubric.Location = new System.Drawing.Point(795, 394);
            this.btnDeleteRubric.Name = "btnDeleteRubric";
            this.btnDeleteRubric.Size = new System.Drawing.Size(96, 39);
            this.btnDeleteRubric.TabIndex = 13;
            this.btnDeleteRubric.Text = "Delete";
            this.btnDeleteRubric.UseVisualStyleBackColor = true;
            this.btnDeleteRubric.Click += new System.EventHandler(this.btnDeleteRubric_Click);
            // 
            // cloTableAdapter
            // 
            this.cloTableAdapter.ClearBeforeFill = true;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // Rubric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 721);
            this.Controls.Add(this.btnDeleteRubric);
            this.Controls.Add(this.btnUpdateRubric);
            this.Controls.Add(this.buttonAddRubric);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboCLOId);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelRubricId);
            this.Controls.Add(this.labelRubricDetail);
            this.Controls.Add(this.labelCLOId);
            this.Controls.Add(this.UpperPanel);
            this.Controls.Add(this.SideNav);
            this.Name = "Rubric";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rubric";
            this.Load += new System.EventHandler(this.Rubric_Load);
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            this.SideNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Label UpperNavText;
        private System.Windows.Forms.Button btnLogoText;
        private System.Windows.Forms.Panel SideNav;
        private System.Windows.Forms.Button btnStudentResult;
        private System.Windows.Forms.Button btnmanagerubriclevel;
        private System.Windows.Forms.Button btnmanageassessment;
        private System.Windows.Forms.Button btnmanagerubrics;
        private System.Windows.Forms.Button btnmanageclo;
        private System.Windows.Forms.Button btnmanagestudent;
        private System.Windows.Forms.Label labelCLOId;
        private System.Windows.Forms.Label labelRubricDetail;
        private System.Windows.Forms.Label labelRubricId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboCLOId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddRubric;
        private System.Windows.Forms.Button btnUpdateRubric;
        private System.Windows.Forms.Button btnDeleteRubric;
        private ProjectBDataSet3 projectBDataSet3;
        private System.Windows.Forms.BindingSource cloBindingSource;
        private ProjectBDataSet3TableAdapters.CloTableAdapter cloTableAdapter;
        private System.Windows.Forms.BindingSource cloBindingSource1;
        private ProjectBDataSet1 projectBDataSet1;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSet1TableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloIdDataGridViewTextBoxColumn;
    }
}