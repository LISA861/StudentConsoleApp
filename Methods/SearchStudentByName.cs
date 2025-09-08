using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Methods
{
    internal class SearchStudentByName
    {

        public void searchStudentByName()
        {
            using (var context = new StudentDBEntities())
            {
                Console.Write("Enter name to search: ");
                string name = Console.ReadLine();

                var results = context.Students
                    .Where(s => s.FirstName.Contains(name) || s.LastName.Contains(name))
                    .ToList();

                if (results.Any())
                {
                    foreach (var s in results)
                    {
                        Console.WriteLine($"{s.StudentID} - {s.FirstName} {s.LastName}");
                    }
                }
                else
                {
                    Console.WriteLine("❌ No students found with that name.");
                }

            }
        }
    }
}
