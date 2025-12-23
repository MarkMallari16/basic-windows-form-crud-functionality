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
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "UPDATE students SET first_name = @firstName, last_name = @lastName, age = @age," +
                        "course = @course WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", txtBoxId.Text);
                        cmd.Parameters.AddWithValue("@firstName", txtBoxFirstName.Text);
                        cmd.Parameters.AddWithValue("@lastName", txtBoxLastName.Text);
                        cmd.Parameters.AddWithValue("@age", txtBoxAge.Text);
                        cmd.Parameters.AddWithValue("@course", txtBoxCourse.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void txtBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
