using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Methods
{
    internal class SearchStudentByID
    {

        public void searchStudentByID()
        {
            using (var context = new StudentDBEntities())
            {
                Console.Write("Enter Student ID: ");
                int id = int.Parse(Console.ReadLine());

                var student = context.Students.FirstOrDefault(s => s.StudentID == id);

                if (student != null)
                {
                    Console.WriteLine($"ID: {student.StudentID} | {student.FirstName} {student.LastName} | Age: {student.Age} | Gender: {student.Gender} | Email: {student.Email}");
                }
                else
                {
                    Console.WriteLine("❌ Student not found.");
                }
            }
        }
    }
}
