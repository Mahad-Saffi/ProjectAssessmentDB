using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectAssessmentDB
{
    public partial class Student : Form
    {
        string connectionString = ConnString.connectionString;
        public Student()
        {
            InitializeComponent();
        }

        private void UpperNavText_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private int MapStatusToInteger(string statusText)
        {
            // Assuming "active" maps to 1 and "inactive" maps to 0
            if (statusText.ToLower() == "active")
            {
                return 1;
            }
            else if (statusText.ToLower() == "inactive")
            {
                return 2;
            }
            else
            {
                // Handle invalid status values here
                throw new ArgumentException("Invalid status value");
            }
        }


        private void Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBMidProjectDataSet.Student' table. You can move, or remove it, as needed.
            //   this.studentTableAdapter.Fill(this.dBMidProjectDataSet.Student);
            LoadDataIntoGrid();

        }

        private void SideNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmanagestudent_Click(object sender, EventArgs e)
        {

        }

        private void btnLogoText_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void btnmanagerubriclevel_Click(object sender, EventArgs e)
        {
            RubricLevel rubricLevel = new RubricLevel();
            rubricLevel.Show();
            this.Hide();
        }

        private void btnmanageassessment_Click(object sender, EventArgs e)
        {
            ManageAssessments assessments = new ManageAssessments();
            assessments.Show();
            this.Hide();
        }

        private void btnmanagerubrics_Click(object sender, EventArgs e)
        {
            Rubric rubric = new Rubric();
            rubric.Show();
            this.Hide();
        }

        private void btnmanageclo_Click(object sender, EventArgs e)
        {
            CLO clo = new CLO();
            clo.Show();
            this.Hide();
        }

        private void btnStudentResult_Click(object sender, EventArgs e)
        {
            StudentResult studentResult = new StudentResult();
            studentResult.Show();
            this.Hide();
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string query = "UPDATE Student SET FirstName = @FirstName, LastName = @LastName, RegistrationNumber = @RegistrationNumber, Contact = @Contact, Email = @Email, Status = @Status WHERE Id = (SELECT Id FROM Student WHERE RegistrationNumber = @RegistrationNumber)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.Add(new SqlParameter("@FirstName", textFirstname.Text));
                    command.Parameters.Add(new SqlParameter("@LastName", textLastname.Text));
                    command.Parameters.Add(new SqlParameter("@RegistrationNumber", textRegNo.Text));
                    command.Parameters.Add(new SqlParameter("@Contact", textContact.Text));
                    command.Parameters.Add(new SqlParameter("@Email", textEmail.Text));
                    command.Parameters.Add(new SqlParameter("@Status", MapStatusToInteger(comboStatus.Text)));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student Updated Successfully");
                    RefreshGrid();
                    textFirstname.Text = "";
                    textLastname.Text = "";
                    textRegNo.Text = "";
                    textContact.Text = "";
                    textEmail.Text = "";
                    comboStatus.Text = "";
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (connection.State == ConnectionState.Open)
                    {
                        string query = "DELETE FROM Student WHERE Id = (SELECT Id FROM Student WHERE FirstName = @FirstName AND LastName = @LastName AND Email = @Email AND Contact = @Contact AND RegistrationNumber = @RegistrationNumber)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@FirstName", textFirstname.Text));
                            command.Parameters.Add(new SqlParameter("@LastName", textLastname.Text));
                            command.Parameters.Add(new SqlParameter("@RegistrationNumber", textRegNo.Text));
                            command.Parameters.Add(new SqlParameter("@Contact", textContact.Text));
                            command.Parameters.Add(new SqlParameter("@Email", textEmail.Text));

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Student Deleted Successfully");
                                RefreshGrid();
                                textFirstname.Text = "";
                                textLastname.Text = "";
                                textRegNo.Text = "";
                                textContact.Text = "";
                                textEmail.Text = "";
                                comboStatus.Text = "";
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


        
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string query = "INSERT INTO Student(FirstName, LastName, RegistrationNumber, Contact, Email, Status) VALUES (@FirstName, @LastName, @RegistrationNumber, @Contact, @Email, @Status)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.Add(new SqlParameter("@FirstName", textFirstname.Text));
                    command.Parameters.Add(new SqlParameter("@LastName", textLastname.Text));
                    command.Parameters.Add(new SqlParameter("@RegistrationNumber", textRegNo.Text));
                    command.Parameters.Add(new SqlParameter("@Contact", textContact.Text));
                    command.Parameters.Add(new SqlParameter("@Email", textEmail.Text));
                    command.Parameters.Add(new SqlParameter("@Status", MapStatusToInteger(comboStatus.Text)));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student Added Successfully");
                    RefreshGrid();
                    textFirstname.Text = "";
                    textLastname.Text = "";
                    textRegNo.Text = "";
                    textContact.Text = "";
                    textEmail.Text = "";
                    comboStatus.Text = "";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textFirstname.Text = row.Cells[1].Value.ToString();
                textLastname.Text = row.Cells[2].Value.ToString();
                textContact.Text = row.Cells[3].Value.ToString();
                textEmail.Text = row.Cells[4].Value.ToString();
                textRegNo.Text = row.Cells[5].Value.ToString();

                if (row.Cells[6].Value.ToString() == "1")
                {
                    comboStatus.Text = "Active";
                }
                else
                {
                    comboStatus.Text = "Inactive";
                }
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

                    string query = "SELECT * FROM Student";

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

    }
}
