using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Checkpoint2_AZ_171120_DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder.DataSource = "LOCALHOST\\SQLEXPRESS";
            stringBuilder.InitialCatalog = "DB_Checkpoint2";
            stringBuilder.IntegratedSecurity = true;
            DataAbstractionLayer.Open(stringBuilder);

            //Retourne tous les étudiants en base de données
          /*  IEnumerable<Student> student = DataAbstractionLayer.SelectAllStudents();
            foreach (Student studenti in student)
            {
                Console.WriteLine(studenti.ToString());
            }
          */
            //Retourne un étudiant en fonction de son nom de famille
            Student student = DataAbstractionLayer.SelectStudentByLastName("Kraillo");
            Console.WriteLine(student.ToString());
           
            DataAbstractionLayer.Close();
        }
    }
}
