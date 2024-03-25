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
    public partial class Rubric : Form
    {
        public Rubric()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnString.connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Rubric SET Details = @Details, CloId = @CloId WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Details", textBox1.Text);
                    command.Parameters.AddWithValue("@CloId", comboCLOId.SelectedValue);
                    command.Parameters.AddWithValue("@Id", textBox2.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Data Updated Successfully");
                    Rubric_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnString.connectionString))
                {
                    string query = "INSERT INTO Rubric (Details, CloId, Id) VALUES (@Details, @CloId, @Id)";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Details", textBox1.Text);
                    command.Parameters.AddWithValue("@CloId", comboCLOId.SelectedValue);
                    command.Parameters.AddWithValue("@Id", textBox2.Text);
                    
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Data Inserted Successfully");
                    Rubric_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Rubric_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet1.Rubric);
            // TODO: This line of code loads data into the 'projectBDataSet3.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet3.Clo);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteRubric_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnString.connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Rubric WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", textBox2.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Data Deleted Successfully");
                    Rubric_Load(sender, e);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                comboCLOId.Text = row.Cells[2].Value.ToString();
                Rubric_Load(sender, e);
            }
        }

        private void btnmanagestudent_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.Show();
            this.Hide();
        }

        private void btnmanageclo_Click(object sender, EventArgs e)
        {
            CLO cLO = new CLO();
            cLO.Show();
            this.Hide();
        }

        private void btnmanagerubrics_Click(object sender, EventArgs e)
        {
            
        }

        private void btnmanageassessment_Click(object sender, EventArgs e)
        {
            ManageAssessments manageAssessments = new ManageAssessments();
            manageAssessments.Show();
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
    }
}
