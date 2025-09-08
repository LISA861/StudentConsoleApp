using System;
using System.Data.SqlClient;


namespace StudentManager.Methods
{
    internal class AddStudent
    {

        public void addStudent()
        {
            using (var context = new StudentDBEntities())
            {
                Console.Write("First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Gender: ");
                string gender = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                var student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Gender = gender,
                    Email = email
                };

                context.Students.Add(student);
                context.SaveChanges();
                Console.WriteLine("✅ Student added successfully!");
            }
        }
    }
}
