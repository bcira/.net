namespace SchoolSystem
{
    public class Classroom : IAddable
    {
        

        public string? Name { get; set; }

        public Teacher? Teacher { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();
        public void Add(Student student)
        {
            Students.Add(student);
            Console.WriteLine($"{student.Name} is added in {Name} classroom");

            if (Teacher != null)
            {
                Teacher.Add(student);
            }
        }
    }
}
