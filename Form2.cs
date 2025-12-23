using FirstWinForm.Database;
using System.Data;
using System.Data.SqlClient;

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {



            ResetAllInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


        }

        private void dataTblGridStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;


            DataGridViewRow row = dataTblGridStudent.Rows[e.RowIndex];
            txtBoxFirstName.Text = row.Cells[1].Value?.ToString() ?? "";
            txtBoxAge.Text = row.Cells[2].Value?.ToString() ?? "";
            txtBoxCourse.Text = row.Cells[3].Value?.ToString() ?? "";

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
