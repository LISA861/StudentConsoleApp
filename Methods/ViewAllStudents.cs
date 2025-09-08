using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Methods
{
    internal class ViewAllStudents
    {

        public void viewAllStudents()
        {
            using (var context = new StudentDBEntities())
            {
                var students = context.Students.ToList();
                Console.WriteLine("\nID\tFirst Name\tLast Name\tAge\tGender\tEmail");
                Console.WriteLine("-------------------------------------------------------------");
                foreach (var s in students)
                {
                    Console.WriteLine($"{s.StudentID}\t{s.FirstName}\t{s.LastName}\t{s.Age}\t{s.Gender}\t{s.Email}");
                }
            }
        }
    }
}
