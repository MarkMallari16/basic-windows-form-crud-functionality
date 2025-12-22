using System.Data;

namespace FirstWinForm
{
    public partial class Form2 : Form
    {
        private DataTable table;
        private int id;
        public static Dictionary<int, string[]> students = new Dictionary<int, string[]>();

        public Form2()
        {
            InitializeComponent();
            InitializeDataTable();
        }

        private void InitializeDataTable()
        {
            table = new DataTable();

            table.Columns.Add("Student ID", typeof(int));
            table.Columns.Add("Student Name", typeof(string));
            table.Columns.Add("Student Age", typeof(string));
            table.Columns.Add("Student Course", typeof(string));

            dataTblGridStudent.DataSource = table;
            dataTblGridStudent.AllowUserToAddRows = false;
            dataTblGridStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataTblGridStudent.MultiSelect = false;
            dataTblGridStudent.CellClick += dataTblGridStudent_CellClick;
        }

        private void ResetAllInputs()
        {
            txtBoxID.Clear();
            txtBoxName.Clear();
            txtBoxAge.Clear();
            txtBoxCourse.Clear();
        }
        private bool DisplayValidations()
        {
            if (string.IsNullOrEmpty(txtBoxID.Text) || string.IsNullOrEmpty(txtBoxName.Text) ||
                string.IsNullOrEmpty(txtBoxAge.Text) || string.IsNullOrEmpty(txtBoxCourse.Text))
            {
                MessageBox.Show("Please fill all inputs.");
                return false;
            }


            if (!int.TryParse(txtBoxID.Text, out _))
            {
                MessageBox.Show("ID must be a number.");
                return false;
            }

            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!DisplayValidations())
            {
                return;
            }

            int id = Convert.ToInt32(txtBoxID.Text);
            string name = txtBoxName.Text;
            string age = txtBoxAge.Text;
            string course = txtBoxCourse.Text;

            string[] studentInfo = { name, age, course };



            students.Add(id, studentInfo);

            table.Rows.Add(id, name, age, course);
            id++;
            MessageBox.Show("Students Successfully Added.", "Success");

            ResetAllInputs();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dataTblGridStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            int id = Convert.ToInt32(txtBoxID.Text);
            string name = txtBoxName.Text;
            string age = txtBoxAge.Text;
            string course = txtBoxCourse.Text;

            if (!students.ContainsKey(id))
            {
                MessageBox.Show("Student not found.");
                return;
            }

            DataGridViewRow row = dataTblGridStudent.SelectedRows[0];

            row.Cells["Student Name"].Value = name;
            row.Cells["Student Age"].Value = age;
            row.Cells["Student Course"].Value = course;

            MessageBox.Show("Students Successfully Update.", "Success");

            ResetAllInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataTblGridStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            int id = Convert.ToInt32(txtBoxID.Text);

            if (students.ContainsKey(id))
            {
                if (MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                students.Remove(id);


                DataRow rowToDelete = table.AsEnumerable()
                                            .FirstOrDefault(r => r.Field<int>("Student ID") == id);
                if (rowToDelete != null)
                {
                    table.Rows.Remove(rowToDelete);
                }

                MessageBox.Show($"Students Successfully Delete {id}.", "Success");

                ResetAllInputs();
            }
            else
            {
                MessageBox.Show("Student not found.");
                return;
            }
        }

        private void dataTblGridStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtBoxID.ReadOnly = true;

            DataGridViewRow row = dataTblGridStudent.Rows[e.RowIndex];
            txtBoxID.Text = row.Cells[0].Value?.ToString() ?? "";
            txtBoxName.Text = row.Cells[1].Value?.ToString() ?? "";
            txtBoxAge.Text = row.Cells[2].Value?.ToString() ?? "";
            txtBoxCourse.Text = row.Cells[3].Value?.ToString() ?? "";

        }
    }
}
