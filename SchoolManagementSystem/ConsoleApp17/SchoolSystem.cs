namespace SchoolSystem
{
    public interface IAddable
    {
        void Add(Student student);

    }

    public abstract class Person
    {
        public string? Name { get; set; }

    }


}
