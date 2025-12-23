
using FirstWinForm.Database;
using FirstWinForm.Models;
using Microsoft.Data.SqlClient;
using System.Data;
namespace FirstWinForm.Repositories
{
    public class StudentRepository
    {
        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();

            string query = "SElECT * FROM students";

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            StudentId = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            Age = reader.GetInt32(3),
                            Course = reader.GetString(4),
                        });


                    }
                }

                return students;

            }
        }

        public bool Add(Student student)
        {
            string query = @"INSERT INTO students(first_name,last_name,age,course) VALUES (@firstName,@lastName,@age,@course)";

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = student.FirstName;
                cmd.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = student.LastName;
                cmd.Parameters.Add("@age", SqlDbType.NVarChar).Value = student.Age;
                cmd.Parameters.Add("@course", SqlDbType.NVarChar).Value = student.Course;

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;

            }
        }
    }
}
