using FirstWinForm.Database;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FirstWinForm
{
    public partial class Form2 : Form
    {
        private DataTable table;

        public Form2()
        {
            InitializeComponent();
            InitializeDataTable();

        }

        private void InitializeDataTable()
        {
            table = new DataTable();

            table.Columns.Add("Student ID", typeof(int));
            table.Columns.Add("Student First Name", typeof(string));
            table.Columns.Add("Student Last Name", typeof(string));
            table.Columns.Add("Student Age", typeof(string));
            table.Columns.Add("Student Course", typeof(string));

            dataTblGridStudent.DataSource = table;
            dataTblGridStudent.AllowUserToAddRows = false;
            dataTblGridStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataTblGridStudent.MultiSelect = false;
            dataTblGridStudent.CellDoubleClick += dataTblGridStudent_CellClick;

            LoadStudents();
        }

        private void LoadStudents()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM students", conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataTblGridStudent.DataSource = dt;

                    dataTblGridStudent.Columns["id"].HeaderText = "Student ID";
                    dataTblGridStudent.Columns["first_name"].HeaderText = "Student First Name";
                    dataTblGridStudent.Columns["last_name"].HeaderText = "Student Last Name";
                    dataTblGridStudent.Columns["age"].HeaderText = "Student Age";
                    dataTblGridStudent.Columns["course"].HeaderText = "Student Course";
                    dataTblGridStudent.Columns["created_at"].HeaderText = "Created At";
                    dataTblGridStudent.Columns["updated_at"].HeaderText = "Updated At";

                    dataTblGridStudent.AllowUserToAddRows = false;
                    dataTblGridStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataTblGridStudent.MultiSelect = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }
        private void ResetAllInputs()
        {
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxAge.Clear();
            txtBoxCourse.Clear();
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

            if (string.IsNullOrWhiteSpace(txtBoxCourse.Text))
            {
                MessageBox.Show("Course is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxCourse.Focus();
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

            try
            {
                string query = "INSERT INTO Students (first_name, last_name, age, course) VALUES (@first_name, @last_name," +
               "@age, @course)";

                using (SqlConnection conn = DatabaseHelper.GetConnection())

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@first_name", txtBoxFirstName.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtBoxLastName.Text);
                    cmd.Parameters.AddWithValue("@age", txtBoxAge.Text);
                    cmd.Parameters.AddWithValue("@course", txtBoxCourse.Text);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Student added successfully!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudents();
                        ResetAllInputs();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add student.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

                int studentId = Convert.ToInt32(row.Cells["id"].Value);
                string firstName = row.Cells["first_name"].Value.ToString();
                string lastName = row.Cells["last_name"].Value.ToString();
                string age = row.Cells["age"].Value.ToString();
                string course = row.Cells["course"].Value.ToString();

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
    }
}
