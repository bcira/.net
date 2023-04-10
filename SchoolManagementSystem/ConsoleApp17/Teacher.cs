namespace SchoolSystem
{
    public class Teacher : Person, IAddable
    {
        public string? Subject { get; set; }
        public void Add(Student student)
        {
            Console.WriteLine($"{Name} is added to class");
        }
    }
}
