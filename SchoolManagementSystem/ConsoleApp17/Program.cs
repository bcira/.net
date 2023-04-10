using SchoolSystem;
public class Program
{
    static void Main(string[] args)
    {
        School school = new School();
        Student student = new Student();

        Console.WriteLine("Welcome to the School Management System!");

        bool isExit = false;

        while (!isExit)
        {
            Console.WriteLine("Select an option:\n" +

                "1. Add classroom\n" +
                "2. Add teacher\n" +
                "3. Add student\n" +
                "4. Assign a teacher to a classroom\n" +
                "5. Search for a teacher\n" +
                "6. List teachers\n" +
                "7. List students\n" +
                "8. List classrooms\n" +
                "9. Submit a homework\n" +
                "10. Assign a student to a classroom\n" +
                "0. Exit\n");


            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    school.AddClassroom();
                    break;

                case 2:
                    school.AddTeacher();
                    break;

                case 3:
                    school.AddPerson(school.Students);
                    Console.WriteLine("Student is added to system successfully. \n");
                    break;

                case 4:
                    school.AssignTeacher();
                    break;

                case 5:
                    school.SearchTeacher();
                    break;

                case 6:
                    school.ListTeachers();
                    break;

                case 7:
                    school.ListStudents();
                    break;

                case 8:
                    school.ListClassrooms();
                    break;

                case 9:
                    student.SubmitHomework(student);
                    break;

                case 10:
                    school.AssignStudent();
                    break;

                case 0:
                    isExit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
