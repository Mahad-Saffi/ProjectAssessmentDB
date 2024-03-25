using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAssessmentDB
{
    public partial class StudentResult : Form
    {
        public StudentResult()
        {
            InitializeComponent();
        }

        private void btnLogoText_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
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

        }

        private void StudentResult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet8.StudentResult' table. You can move, or remove it, as needed.
            this.studentResultTableAdapter.Fill(this.projectBDataSet8.StudentResult);
            // TODO: This line of code loads data into the 'projectBDataSet6.RubricLevel' table. You can move, or remove it, as needed.
            this.rubricLevelTableAdapter.Fill(this.projectBDataSet6.RubricLevel);
            // TODO: This line of code loads data into the 'projectBDataSet1.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet1.Rubric);
            // TODO: This line of code loads data into the 'projectBDataSet5.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet5.AssessmentComponent);
            // TODO: This line of code loads data into the 'projectBDataSet.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.projectBDataSet.Assessment);
            // TODO: This line of code loads data into the 'projectBDataSet2.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet2.Student);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                e.RowIndex.ToString();
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                comboStudent.Text = row.Cells[0].Value.ToString();
                comboAssessmentComponent.Text = row.Cells[1].Value.ToString();
                comboRubricLevel.Text = row.Cells[2].Value.ToString();
                comboRubricDetail.Text = row.Cells[6].Value.ToString();
                comboRubricLevelId.Text = row.Cells[7].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnString.connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO StudentResult(StudentId, AssessmentComponentId, RubricMeasurementId, EvaluationDate) VALUES(@StudentId, @AssessmentComponent, @RubricMeasurementId, @EvaluationDate)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@StudentId", comboStudent.SelectedValue);
                    cmd.Parameters.AddWithValue("@AssessmentComponent", comboAssessmentComponent.SelectedValue);
                    cmd.Parameters.AddWithValue("@RubricMeasurementId", comboRubricLevelId. SelectedValue);
                    cmd.Parameters.AddWithValue("@EvaluationDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@MarksObtained", MarksObtained());
                    cmd.Parameters.AddWithValue("@Assessment", comboAssessmentComponent.SelectedValue);
                    cmd.Parameters.AddWithValue("@RubricDetail", comboRubricDetail.SelectedValue);
                    cmd.Parameters.AddWithValue("@RubricLevelId", comboRubricLevelId.SelectedValue);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Inserted Successfully");
                    StudentResult_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int MarksObtained()
        {
            int marks = 0;
            int totalMarks = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnString.connectionString))
                {
                    connection.Open();
                    string query = "SELECT TotalMarks FROM AssessmentComponent WHERE Id = @Id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", comboAssessmentComponent.SelectedValue);

                    totalMarks = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            marks = Convert.ToInt32(Convert.ToInt32(comboRubricLevel.Text) / 4.0) * totalMarks;

            return marks;
        }
    }
}
