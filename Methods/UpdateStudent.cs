using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Methods
{
    internal class UpdateStudent
    {

        public void updateStudent()
        {
            using (var context = new StudentDBEntities())
            {
                Console.Write("Enter Student ID to update: ");
                int id = int.Parse(Console.ReadLine());

                var student = context.Students.FirstOrDefault(s => s.StudentID == id);

                if (student == null)
                {
                    Console.WriteLine("❌ Student not found.");
                    return;
                }

                Console.Write("New First Name: ");
                student.FirstName = Console.ReadLine();

                Console.Write("New Last Name: ");
                student.LastName = Console.ReadLine();

                Console.Write("New Age: ");
                student.Age = int.Parse(Console.ReadLine());

                Console.Write("New Gender: ");
                student.Gender = Console.ReadLine();

                Console.Write("New Email: ");
                student.Email = Console.ReadLine();

                context.SaveChanges();
                Console.WriteLine("✅ Student updated successfully!");
            }
        }
    }
}
