using FirstWinForm.Database;
using Microsoft.Data.SqlClient;

namespace FirstWinForm
{
    public partial class UpdateDeleteForm : Form
    {
        private int _id;
        private string _firstName, _lastName, _age, _course;

        public UpdateDeleteForm(int id, string firstName, string lastName, string age, string course)
        {
            InitializeComponent();

            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _course = course;

            txtBoxId.Text = id.ToString();
            txtBoxFirstName.Text = firstName;
            txtBoxLastName.Text = lastName;
            txtBoxAge.Text = age;
            txtBoxCourse.Text = course;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();

                        string query = "DELETE FROM students WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", _id);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Student deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                                conn.Close();
                            }
                            else
                            {
                                MessageBox.Show("Delete failed. Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                conn.Close();
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: ", ex.Message);
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
