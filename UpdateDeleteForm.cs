namespace FirstWinForm
{
    public partial class UpdateDeleteForm : Form
    {
        private int id;
        private string firstName, lastName, age, course;

        public UpdateDeleteForm(int id, string firstName, string lastName, string age, string course)
        {
            InitializeComponent();
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.course = course;
        }
    }
}
