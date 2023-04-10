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

     
    }
}
