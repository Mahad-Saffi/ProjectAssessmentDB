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
    public partial class StudentAttendance : Form
    {
        string connectionString = ConnString.connectionString;
        public StudentAttendance()
        {
            InitializeComponent();
        }

        private void StudentAttendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet2.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet2.Student);
            // TODO: This line of code loads data into the 'projectBDataSet7.StudentAttendance' table. You can move, or remove it, as needed.
            this.studentAttendanceTableAdapter.Fill(this.projectBDataSet7.StudentAttendance);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnattendancesave_Click(object sender, EventArgs e)
        {
            InsertDateIntoAttendanceClass();
            InsertAttendance(sender, e);
            
        }

        private void InsertDateIntoAttendanceClass()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(ConnString.connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO ClassAttendance(AttendanceDate) VALUES(@AttendanceDate)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AttendanceDate", dateTimePicker1.Value.Date);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertAttendance(object sender, EventArgs e)
        {
            int temp = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (comboStatusAttendance.Text == "Present")
                    {
                        temp = 1;
                    }
                    else if (comboStatusAttendance.Text == "Absent")
                    {
                        temp = 2;
                    }
                    else if (comboStatusAttendance.Text == "Leave")
                    {
                        temp = 3;
                    }
                    else if (comboStatusAttendance.Text == "Late")
                    {
                        temp = 4;
                    }
        
                    string query = "Insert INTO StudentAttendance(StudentId,AttendanceId,AttendanceStatus) VALUES(@StudentId,@AttendanceId,@AttendanceStatus)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentId", comboStudentId.SelectedValue);
                    command.Parameters.AddWithValue("@AttendanceId", GetAttendanceId());
                    command.Parameters.AddWithValue("@AttendanceStatus", temp);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Attendance Saved Successfully");
                    StudentAttendance_Load(sender, e);
                    
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int GetAttendanceId()
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id FROM ClassAttendance WHERE AttendanceDate = @AttendanceDate";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AttendanceDate", dateTimePicker1.Value.Date);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                }
                connection.Close();
            }
            return id;
        }

        private void comboStatusAttendance_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtStudentIdAttendance_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
