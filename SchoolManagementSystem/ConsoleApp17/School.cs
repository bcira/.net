namespace SchoolSystem
{
    public class School
    {
        public List<Classroom> Classrooms { get; set; } = new List<Classroom>();
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public List<Student> Students { get; set; } = new List<Student>();



        public void AddPerson<T>(List<T> list) where T : Person, new()
        {
            Console.Write("Enter the name: ");
            string? name = Console.ReadLine();

            T person = new T { Name = name };

            list.Add(person);

        }


        public void AssignTeacher()
        {
            Console.WriteLine("Assign a teacher to a classroom: ");
            ListTeachers();

            int teacherIndex = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Select a classroom to assign the teacher: ");
            ListClassrooms();

            int classroomIndex = int.Parse(Console.ReadLine()) - 1;

            Classrooms[classroomIndex].Teacher = Teachers[teacherIndex];

            Console.WriteLine("Teacher is assigned to the classroom successfully. \n");

        }

        public void ListTeachers()
        {
            if (Teachers.Count == 0)
            {
                Console.WriteLine("There is no teacher in the system!");

                return;
            }

            else
            {
                Console.WriteLine("List of the teachers: \n");

            }


            for (int i = 0; i < Teachers.Count; i++)
            {
                Console.WriteLine($"{i + 1}{Teachers[i].Name}, {Teachers[i].Subject}");
            }
        }

        public void ListStudents()
        {
            if (Students.Count == 0)
            {
                Console.WriteLine("There is no student in the system! \n");
                return;

            }
            else
            {

                Console.WriteLine("List of the students: \n");

            }


            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine($"{i + 1} {Students[i].Name}");
            }
        }

        public void ListClassrooms()
        {
            if (Classrooms.Count == 0)
            {
                Console.WriteLine("There is no classroom in the system! \n");
            }

            else
            {
                Console.WriteLine("List of the Classrooms: \n");

            }

            for (int i = 0; i < Classrooms.Count; i++)
            {
                if (Classrooms[i].Teacher == null)
                {
                    Console.WriteLine($"{i + 1} {Classrooms[i].Name}, No teacher is assigned");
                }

                else
                {
                    Console.WriteLine($"{i + 1} {Classrooms[i].Name}, Teacher: {Classrooms[i].Teacher.Name}");
                }
            }
        }


        public void SearchTeacher()
        {
            if (Classrooms.Count == 0)
            {
                Console.WriteLine("There are no classroom in the system! Please add a classroom");
                return;
            }

            Console.Write("Enter the name of the classroom: ");
            string? classroomName = Console.ReadLine();

            Classroom classroom = Classrooms.Find(c => c.Name == classroomName);

            if (classroom == null)
            {
                Console.WriteLine("There is no class with this name! \n");
                return;
            }

            if (classroom.Teacher == null)
            {
                Console.WriteLine($"No teacher assigned to this classroom! \n");
                return;
            }
            else
            {
                Console.WriteLine($"Teacher of the {classroomName} classroom is {classroom.Teacher.Name}");
            }
        }

        public void AssignStudent()
        {
            if (Classrooms.Count == 0)
            {
                Console.WriteLine("There are no classroom in the system! Please add a classroom");
                return;
            }

            else
            {
                Console.WriteLine("Select a classroom: ");
                ListClassrooms();
                int classroomIndex = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine("Select a student to add to this class: ");
                ListStudents();
                int studentIndex = int.Parse(Console.ReadLine()) - 1;

                Classrooms[classroomIndex].Add(Students[studentIndex]);

                Console.WriteLine("Student is added to class successfully. \n");

            }
        }



        public void AddClassroom()
        {
            Console.Write("Enter the name of classroom: ");
            string? classroomName = Console.ReadLine();

            Classroom classroom = new Classroom { Name = classroomName };
            Classrooms.Add(classroom);
            Console.WriteLine("Classroom is added to the system successfully.\n");

        }

        public void AddTeacher()
        {
            AddPerson(Teachers);
            Console.Write("Enter subject of the teacher: ");
            string? subject = Console.ReadLine();

            Teachers[Teachers.Count - 1].Subject = subject;
            Console.WriteLine($"Teacher is added to the system successfully. \n");
        }


    }

}



