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
    public partial class ManageAssessments : Form
    {
        public int tempId = 0;

        string connectionString = ConnString.connectionString;
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
            ManageAssessments assessments = new ManageAssessments();
            assessments.Show();
            this.Hide();
        }

        private void btnmanageassessment_Click(object sender, EventArgs e)
        {

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

        private void ManageAssessments_Load(object sender, EventArgs e)
        {
            RefreshGrid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                tempId = Convert.ToInt32(row.Cells[0].Value);
                txtassesmentTitle.Text = row.Cells[1].Value.ToString();
                txtassesmentMarks.Text = row.Cells[3].Value.ToString();
                txtassesmentWeightage.Text = row.Cells[4].Value.ToString();
            }
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            LoadDataIntoGrid();
        }

        //To Load the data to grid after refresh
        private void LoadDataIntoGrid()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Assessment";

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

        private void btnAddassessment_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            try
            {
                string query = "INSERT INTO Assessment (Title, DateCreated, TotalMarks, TotalWeightage) VALUES ('" + txtassesmentTitle.Text + "', '" + DateTime.Now + "', '" + txtassesmentMarks.Text + "', '" + txtassesmentWeightage.Text + "')";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Assessment Added Successfully");
                RefreshGrid();
                txtassesmentTitle.Text = "";
                txtassesmentMarks.Text = "";
                txtassesmentWeightage.Text = "";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndeleteassessment_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (connection.State == ConnectionState.Open)
                    {
                        string query = "DELETE FROM Assessment WHERE Id = (SELECT Id FROM Assessment WHERE Title = @Title AND TotalMarks = @TotalMarks AND TotalWeightage = @TotalWeightage)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@Title", txtassesmentTitle.Text));
                            command.Parameters.Add(new SqlParameter("@TotalMarks", txtassesmentMarks.Text));
                            command.Parameters.Add(new SqlParameter("@TotalWeightage", txtassesmentWeightage.Text));

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Assessment Deleted Successfully");
                                RefreshGrid();
                                txtassesmentTitle.Text = "";
                                txtassesmentMarks.Text = "";
                                txtassesmentWeightage.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("No matching student found to delete.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error in connection");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnupdateassessment_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if(connection.State == ConnectionState.Open)
                    {
                        string query = "UPDATE Assessment SET Title = @Title, TotalMarks = @TotalMarks, TotalWeightage = @TotalWeightage WHERE Id = @Id";
                        using(SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@Id", tempId));
                            command.Parameters.Add(new SqlParameter("@Title", txtassesmentTitle.Text));
                            command.Parameters.Add(new SqlParameter("@TotalMarks", txtassesmentMarks.Text));
                            command.Parameters.Add(new SqlParameter("@TotalWeightage", txtassesmentWeightage.Text));

                            command.ExecuteNonQuery();

                            MessageBox.Show("Assessment Updated Successfully");
                            RefreshGrid();
                            txtassesmentTitle.Text = "";
                            txtassesmentMarks.Text = "";
                            txtassesmentWeightage.Text = "";
                        }
                    }

                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
