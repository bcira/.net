using SchoolSystem;
using System.Collections.Generic;


namespace SchoolSystem
{
    public class Student : Person
    {
        
        public void SubmitHomework(Student student)
        {
            Console.WriteLine("Enter the name of homework: ");
            string? homework = Console.ReadLine();
            Console.WriteLine($"Homework is submitted {homework}");
        }

        public void AddStudent<T>(List<T> list) where T : Student, new()
        {
            Console.Write("Enter the name: ");
            string? name = Console.ReadLine();

            T student = new T { Name = name };

            list.Add(student);
        }

     
    }
}
