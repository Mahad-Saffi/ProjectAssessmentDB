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
    public partial class CLO : Form
    {

        string connectionString = "Data Source=DESKTOP-VCJSKBS;Initial Catalog=ProjectB;Integrated Security=True;";
            //"Server=DESKTOP-VCJSKBS\\SQLEXPRESS;;Database=ProjectB;Trusted_Connection=True;";

        public CLO()
        {
            InitializeComponent();
        }

        private void labelcloname_Click(object sender, EventArgs e)
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

        }

        private void btnmanagerubrics_Click(object sender, EventArgs e)
        {
            ManageAssessments assessments = new ManageAssessments();
            assessments.Show();
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

        private void txtcloname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncloadd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string query = "INSERT INTO Clo(Name,DateCreated,DateUpdated) VALUES (@Name, @DateCreated, @DateUpdated)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.Add(new SqlParameter("@Name", txtcloname.Text));
                    command.Parameters.Add(new SqlParameter("@DateCreated", DateTime.Today.Date));
                    command.Parameters.Add(new SqlParameter("@DateUpdated", DateTime.Today.Date));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student Added Successfully");
                    RefreshGrid();
                    txtcloname.Text = "";

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

                    string query = "SELECT * FROM Clo";

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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                TextID.Text = row.Cells[0].Value.ToString();
                txtcloname.Text = row.Cells[1].Value.ToString();

            }
        }
        private void btncloupdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string query = "UPDATE Clo SET Name = @Name,DateUpdated = @DateUpdated WHERE Id= @Id";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.Add(new SqlParameter("@Name", txtcloname.Text));
                    command.Parameters.Add(new SqlParameter("@Id", TextID.Text));
                    command.Parameters.Add(new SqlParameter("@DateUpdated", DateTime.Today.Date));


                    int rowsAffected = command.ExecuteNonQuery();   
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("CLO Updated Successfully");
                        RefreshGrid();
                        txtcloname.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No matching CLO found to update.");
                    }

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

        private void btnclodelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (connection.State == ConnectionState.Open)
                    {
                        string query = "DELETE FROM Clo WHERE Id = (SELECT Id FROM Clo WHERE Name = @Name )";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@Name", txtcloname.Text));


                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Student Deleted Successfully");
                                RefreshGrid();
                                txtcloname.Text = "";

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

        private void TextID_TextChanged(object sender, EventArgs e)
        {

        }

        private void CLO_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
