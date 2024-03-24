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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Rubric_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet3.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet3.Clo);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
