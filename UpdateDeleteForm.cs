using FirstWinForm.Models;
using FirstWinForm.Repositories;

namespace FirstWinForm
{
    public partial class UpdateDeleteForm : Form
    {
        private Student _student;

        public UpdateDeleteForm(Student student)
        {
            InitializeComponent();
            _student = student;
            InitializeCourseComboBox();

            //Filled only the inputs
            txtBoxId.Text = student.StudentId.ToString();
            txtBoxFirstName.Text = student.FirstName;
            txtBoxLastName.Text = student.LastName;
            txtBoxAge.Text = student.Age;

            int courseIndex = cbCourse.Items.IndexOf(student.Course);

            if (courseIndex >= 0)
            {
                cbCourse.SelectedIndex = courseIndex;
            }

        }
        private void InitializeCourseComboBox()
        {
            cbCourse.Items.Add("Select Course");
            cbCourse.Items.Add("BSIT");
            cbCourse.Items.Add("BSCS");
            cbCourse.Items.Add("BSCE");
            cbCourse.Items.Add("BSIS");

            cbCourse.SelectedIndex = 0;
            cbCourse.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                StudentRepository repo = new StudentRepository();

                if (repo.Delete(_student.StudentId))
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
            _student.StudentId = Convert.ToInt32(txtBoxId.Text);
            _student.FirstName = txtBoxFirstName.Text;
            _student.LastName = txtBoxLastName.Text;
            _student.Age = txtBoxAge.Text;
            _student.Course = cbCourse.Text;

            StudentRepository repo = new StudentRepository();

            if (repo.Update(_student))
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
