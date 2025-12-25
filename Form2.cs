using FirstWinForm.Models;
using FirstWinForm.Repositories;
namespace FirstWinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadStudents();
            cbCourse.Items.Add("Select Course");
            cbCourse.Items.Add("BSIT");
            cbCourse.Items.Add("BSCS");
            cbCourse.Items.Add("BSCE");
            cbCourse.Items.Add("BSIS");

            cbCourse.SelectedIndex = 0;

            cbCourse.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void LoadStudents()
        {
            StudentRepository repo = new StudentRepository();
            dataTblGridStudent.DataSource = repo.GetAll();
            dataTblGridStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTblGridStudent.Columns["StudentId"].HeaderText = "Student ID";
            dataTblGridStudent.Columns["FirstName"].HeaderText = "First Name";
            dataTblGridStudent.Columns["LastName"].HeaderText = "Last Name";
        }
        private void ResetAllInputs()
        {
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxAge.Clear();
        }
        private bool HasValidations()
        {
            if (string.IsNullOrWhiteSpace(txtBoxFirstName.Text))
            {
                MessageBox.Show("First name is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBoxLastName.Text))
            {
                MessageBox.Show("First name is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBoxAge.Text))
            {
                MessageBox.Show("Age is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxAge.Focus();
                return false;
            }


            int age = Convert.ToInt32(txtBoxAge.Text);

            if (age < 1 || age > 120)
            {
                MessageBox.Show("Age must be realistic", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxAge.Focus();
                return false;
            }

            if (cbCourse.SelectedIndex == 0)
            {
                MessageBox.Show("Course is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCourse.Focus();
                return false;
            }

            return true;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {

            if (!HasValidations())
            {
                return;
            }

            Student student = new Student
            {
                FirstName = txtBoxFirstName.Text,
                LastName = txtBoxLastName.Text,
                Age = txtBoxAge.Text,
                Course = cbCourse.Text
            };

            StudentRepository repo = new StudentRepository();

            if (repo.Add(student))
            {
                MessageBox.Show("Student successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudents();
                ResetAllInputs();
            }
        }

        private void dataTblGridStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataTblGridStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataTblGridStudent_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataTblGridStudent.Rows[e.RowIndex];

                int studentId = Convert.ToInt32(row.Cells["StudentId"].Value);
                string firstName = row.Cells["FirstName"].Value.ToString();
                string lastName = row.Cells["LastName"].Value.ToString();
                string age = row.Cells["Age"].Value.ToString();
                string course = row.Cells["Course"].Value.ToString();

                UpdateDeleteForm updateForm = new UpdateDeleteForm(studentId, firstName, lastName, age, course);
                updateForm.ShowDialog();

                LoadStudents();
            }
        }

        private void txtBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
