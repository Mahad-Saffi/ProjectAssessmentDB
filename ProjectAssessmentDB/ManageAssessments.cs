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
    public partial class ManageAssessments : Form
    {
        public ManageAssessments()
        {
            InitializeComponent();
        }

        private void labelAssesmentTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnaddComponent_Click(object sender, EventArgs e)
        {
            AssessmentComponent assessmentComponent = new AssessmentComponent();
            assessmentComponent.Show();
            this.Hide();
        }
    }
}
