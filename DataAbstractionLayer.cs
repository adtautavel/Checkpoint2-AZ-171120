using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Checkpoint2_AZ_171120_DAL
{
    internal class DataAbstractionLayer
    {
        private static SqlConnection _connection = new SqlConnection();

        internal static void Open(SqlConnectionStringBuilder stringBuilder)
        {
            _connection.ConnectionString = stringBuilder.ConnectionString;
            _connection.Open();
        }

        internal static void Close()
        {
            _connection.Close();
        }

        internal static IEnumerable<Student> SelectAllStudents()
        {
            SqlCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT * FROM Students";
            SqlDataReader reader = command.ExecuteReader();
            List<Student> Students = new List<Student>();
            while (reader.Read()) 
            {
                Student Student = new Student
                {
                    StudentId = reader.GetInt32(0),
                    StudentFirstName = reader.GetString(1),
                    StudentLastName = reader.GetString(2),
                    FK_PromotionId = reader.GetInt32(3),
                };
                Students.Add(Student);
            }
            reader.Close();
            return Students;
        }

        internal static Student SelectStudentByLastName(string lastName)
        {
            IEnumerable<Student> listStudent = SelectAllStudents();
            Student student = new Student();
            bool studentFound = false;
            while(!studentFound)
            {
                foreach (Student studenti in listStudent)
                {
                    if (studenti.StudentLastName == lastName)
                    {
                        student = studenti;
                        studentFound = true;
                    }
                }
            }
            return student;

            /* ------- Bug au niveau de la requête -----------
             * SqlCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT * FROM Students WHERE (StudentLastName = @lastName)";
            command.Parameters.AddWithValue("@lastName", lastName);
            SqlDataReader reader = command.ExecuteReader();
            Student student = new Student
            {
                StudentId = reader.GetInt32(0),
                StudentFirstName = reader.GetString(1),
                StudentLastName = reader.GetString(2),
                FK_PromotionId = reader.GetInt32(3),
            };
            reader.Close();
            */

        }
    }
}