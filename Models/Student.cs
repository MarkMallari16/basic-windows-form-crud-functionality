namespace FirstWinForm.Models
{
    public class Student
    {
        private int studentId;
        private string firstName, lastName;
        private string age;
        private string course;
        public int StudentId
        {
            get => studentId;
            set => studentId = value;
        }
        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }
        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }
        public string Age
        {
            get => age;
            set => age = value;
        }

        public string Course
        {
            get => course;
            set => course = value;
        }
    }
}
