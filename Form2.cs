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
            dataTblGridStudent.CellClick += dataTblGridStudent_CellClick;

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
        private bool IsValidations()
        {
            if (string.IsNullOrEmpty(txtBoxFirstName.Text) ||
                string.IsNullOrEmpty(txtBoxAge.Text) || string.IsNullOrEmpty(txtBoxCourse.Text))
            {
                MessageBox.Show("Please fill all inputs.");
                return false;
            }


            return true;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Students (first_name, last_name, age, course) VALUES (@first_name, @last_name," +
                "@age, @course)";


            try
            {
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
                        MessageBox.Show("Student added successfully!.");
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataTblGridStudent.Rows[e.RowIndex];

                int studentId = Convert.ToInt32(row.Cells["Student ID"].Value);
                string firstName = row.Cells["Student First Name"].Value.ToString();
                string lastName = row.Cells["Student Last Name"].Value.ToString();
                string age = row.Cells["Student Age"].Value.ToString();
                string course = row.Cells["Student Course"].Value.ToString();

                UpdateDeleteForm updateDeleteForm = new UpdateDeleteForm(studentId, firstName, lastName, age, course);
                updateDeleteForm.ShowDialog();

                LoadStudents();
            }
        }
    }
}
