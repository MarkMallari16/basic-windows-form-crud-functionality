using FirstWinForm.Models;
using FirstWinForm.Repositories;

namespace FirstWinForm
{
    public partial class UpdateDeleteForm : Form
    {
        private Student student;

        public UpdateDeleteForm(int id, string firstName, string lastName, string age, string course)
        {
            InitializeComponent();

            student = new Student
            {
                StudentId = id,
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Course = course
            };

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
                StudentRepository repo = new StudentRepository();

                if (repo.Delete(student.StudentId))
                {
                    MessageBox.Show("Student deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Delete failed. Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            StudentRepository repo = new StudentRepository();

            if (repo.Update(student))
            {
                MessageBox.Show("Student updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Update failed. Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
