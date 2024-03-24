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
    public partial class RubricLevel : Form
    {
        string connectionString = ConnString.connectionString;
        public RubricLevel()
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

        }

        private void btnStudentResult_Click(object sender, EventArgs e)
        {
            StudentResult studentResult = new StudentResult();
            studentResult.Show();
            this.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                    string query = "SELECT * FROM RubricLevel";

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
        private void RubricLevel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet1.Rubric);
            RefreshGrid();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                comboRubricId.Text = row.Cells[1].Value.ToString();
                txtRubricDetail.Text = row.Cells[2].Value.ToString();
                comboRubricLevel.Text = row.Cells[3].Value.ToString();

            }
        }
        private void btnaddRubricLevel_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                
                if (connection.State == ConnectionState.Open)
                {
                    int temp = 0;
                    string query = "INSERT INTO RubricLevel(RubricId, Details, MeasurementLevel) VALUES (@RubricId, @Details, @MeasurementLevel)";
                    SqlCommand command = new SqlCommand(query, connection);

                    if (comboRubricLevel.Text == "Exceptional")
                    {
                        temp = 4;
                    }
                    else if (comboRubricLevel.Text == "Good")
                    {
                        temp = 3;
                    }
                    else if (comboRubricLevel.Text == "Fair")
                    {
                        temp = 2;
                    }
                    else if (comboRubricLevel.Text == "Unsatisfactory")
                    {
                        temp = 1;
                    }
                    command.Parameters.Add(new SqlParameter("@RubricId", comboRubricId.Text));
                    command.Parameters.Add(new SqlParameter("@Details", txtRubricDetail.Text));
                    command.Parameters.Add(new SqlParameter("@MeasurementLevel", temp));

                    command.ExecuteNonQuery();
                    MessageBox.Show("Record Added Successfully");
                    RefreshGrid();
                    comboRubricId.Text = "";
                    txtRubricDetail.Text = "";
                    comboRubricLevel.Text = "";

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

        private void txtRubricDetail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRubricLevelDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (connection.State == ConnectionState.Open)
                    {
                        string query = "DELETE FROM RubricLevel WHERE RubricId = @RubricId AND Details = @Details AND MeasurementLevel = @MeasurementLevel";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@RubricId", comboRubricId.Text));
                            command.Parameters.Add(new SqlParameter("@Details", txtRubricDetail.Text));
                            command.Parameters.Add(new SqlParameter("@MeasurementLevel", comboRubricLevel.Text));

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record Deleted Successfully");
                                RefreshGrid();
                                comboRubricId.Text = "";
                                txtRubricDetail.Text = "";
                                comboRubricLevel.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Error deleting record");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting data: " + ex.Message);
            }
        }

        private void btnRubricLevelUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnString.connectionString))
                {
                    connection.Open();
                    int temp = 0;

                    if (connection.State == ConnectionState.Open)
                    {
                        string query = "UPDATE RubricLevel SET Details = @Details, MeasurementLevel = @MeasurementLevel WHERE RubricId = @RubricId";

                        SqlCommand command = new SqlCommand(query, connection);
                        if (comboRubricLevel.Text == "Exceptional")
                        {
                            temp = 4;
                        }
                        else if (comboRubricLevel.Text == "Good")
                        {
                            temp = 3;
                        }
                        else if (comboRubricLevel.Text == "Fair")
                        {
                            temp = 2;
                        }
                        else if (comboRubricLevel.Text == "Unsatisfactory")
                        {
                            temp = 1;
                        }
                        command.Parameters.AddWithValue("@Details", txtRubricDetail.Text);
                        command.Parameters.AddWithValue("@MeasurementLevel", temp);
                        command.Parameters.AddWithValue("@RubricId", comboRubricId.SelectedValue);
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Data Updated Successfully");
                        RubricLevel_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
        }
    }
}

