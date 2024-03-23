using System;
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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void btnmanagestudent_Click(object sender, EventArgs e)
        {

        }

        private void UpperNavText_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogoText_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void SideNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmanagerubriclevel_Click(object sender, EventArgs e)
        {

        }

        private void btnmanageassessment_Click(object sender, EventArgs e)
        {

        }

        private void btnmanagerubrics_Click(object sender, EventArgs e)
        {

        }

        private void btnmanageclo_Click(object sender, EventArgs e)
        {

        }

        private void UpperPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentAttendance studentAttendance = new StudentAttendance();
            studentAttendance.Show();
            this.Hide();
        }
    }
}
