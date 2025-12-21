namespace FirstWinForm
{
    public partial class Form1 : Form
    {
        private string username = "Mark";
        private string password = "Mark123";

        public Form1()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputUsername = txtBoxUsername.Text;
            string inputPassword = txtBoxPassword.Text;

            if (username.Equals(inputUsername) && password.Equals(inputPassword))
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK);

                Form2 form2 = new Form2();
                form2.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK);
            }
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = !cbPassword.Checked;
        }
    }
}
