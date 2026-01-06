namespace FirstWinForm.Forms
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            btnFirst.Click += btnFirst_Click;
            btnSecond.Click += btnSecond_Click;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPage1)
            {
                MessageBox.Show("First tab button clicked");
            }
            else if (tabControl.SelectedTab == tabPage2)
            {
                MessageBox.Show("Second tab button clicked");
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage1;
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage2;
        }


    }
}
