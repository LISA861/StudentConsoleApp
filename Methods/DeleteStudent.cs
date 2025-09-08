using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Methods
{
    internal class DeleteStudent
    {

        public void deleteStudent()
        {
            using (var context = new StudentDBEntities())
            {
                Console.Write("Enter Student ID to delete: ");
                int id = int.Parse(Console.ReadLine());

                var student = context.Students.FirstOrDefault(s => s.StudentID == id);

                if (student == null)
                {
                    Console.WriteLine("❌ Student not found.");
                    return;
                }

                context.Students.Remove(student);
                context.SaveChanges();
                Console.WriteLine("✅ Student deleted successfully!");
            }
        }
    }
}

