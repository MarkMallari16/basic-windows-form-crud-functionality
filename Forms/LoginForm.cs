namespace FirstWinForm
{
    public partial class LoginForm : Form
    {
        private string username = "Mark";
        private string password = "Mark123";

        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputUsername = txtBoxUsername.Text;
            string inputPassword = txtBoxPassword.Text;

            if (username.Equals(inputUsername) && password.Equals(inputPassword))
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashboardForm form2 = new DashboardForm();
                form2.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = !cbPassword.Checked;
        }
    }
}
