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
    public partial class AssessmentComponent : Form
    {
        string connectionString = ConnString.connectionString;
        public AssessmentComponent()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            StudentResult studentResult = new StudentResult();
            studentResult.Show();
            this.Hide();
        }

        private void AssessmentComponent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet5.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter1.Fill(this.projectBDataSet5.Rubric);
            // TODO: This line of code loads data into the 'projectBDataSet4.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter1.Fill(this.projectBDataSet4.Assessment);
            // TODO: This line of code loads data into the 'projectBDataSet3.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet3.AssessmentComponent);
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            LoadDataIntoGrid();
        }
        private void LoadDataIntoGrid()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM AssessmentComponent";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells[1].Value.ToString();
                comboRubric.Text = row.Cells[2].Value.ToString();
                textBox2.Text = row.Cells[3].Value.ToString();
                comboAssessment.Text = row.Cells[6].Value.ToString();

            }
        }
        private void btnAddAssesComp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string query = "INSERT INTO AssessmentComponent(Name, RubricId, TotalMarks, DateCreated, DateUpdated, AssessmentId) VALUES (@Name, @RubricId, @TotalMarks, @DateCreated, @DateUpdated, @AssessmentId)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.Add(new SqlParameter("@Name", textBox1.Text));
                    command.Parameters.Add(new SqlParameter("@RubricId", comboRubric.Text));
                    command.Parameters.Add(new SqlParameter("@TotalMarks", textBox2.Text));
                    command.Parameters.Add(new SqlParameter("@DateCreated", DateTime.Today.Day));
                    command.Parameters.Add(new SqlParameter("@DateUpdated", DateTime.Today.Day));
                    command.Parameters.Add(new SqlParameter("@AssessmentId", comboAssessment.Text));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Record Added Successfully");
                    RefreshGrid();
                    textBox1.Text = "";
                    comboRubric.Text = "";
                    textBox2.Text = "";
                    comboAssessment.Text = "";

                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Error in connection");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboAssessment_Click(object sender, EventArgs e)
        {/*
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string query = "Select * from Assessment";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter da = new SqlDataAdapter (command);
                    DataSet ds = new DataSet();
                    da.Fill (ds);
                    command.ExecuteNonQuery();
                    connection.Close();

                    comboAssessment.DataSource = ds.Tables[0];
                    comboAssessment.DisplayMember = "Title";
                    comboAssessment.ValueMember = "Id";
                }
                else
                {
                    MessageBox.Show("Error in connection");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
        
    }
}
