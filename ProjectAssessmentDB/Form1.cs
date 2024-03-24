﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAssessmentDB
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnmanagestudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
            this.Hide();
        }

        private void btnmanageclo_Click(object sender, EventArgs e)
        {
            CLO clo = new CLO();
            clo.Show();
            this.Hide();
        }

        private void btnmanagerubrics_Click(object sender, EventArgs e)
        {
            Rubric rubric = new Rubric();
            rubric.Show();
            this.Hide();
        }

        private void btnmanageassessment_Click(object sender, EventArgs e)
        {
            ManageAssessments assessments = new ManageAssessments();
            assessments.Show();
            this.Hide();
        }

        private void btnmanagerubriclevel_Click(object sender, EventArgs e)
        {
            RubricLevel rubricLevel = new RubricLevel();
            rubricLevel.Show();
            this.Hide();
        }

        private void btnStudentResult_Click(object sender, EventArgs e)
        {
            StudentResult studentResult = new StudentResult();
            studentResult.Show();
            this.Hide();
        }

        private void SideNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpperPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpperNavText_Click(object sender, EventArgs e)
        {

        }

        private void btnLogoText_Click(object sender, EventArgs e)
        {

        }

        
    }
}
