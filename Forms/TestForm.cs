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

            HideTabs(tabControl);
        }

        private void HideTabs(TabControl tabControl)
        {
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
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
