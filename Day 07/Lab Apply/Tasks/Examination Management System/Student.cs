namespace Examination_Management_System
{
    public class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        
        public Student(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public void OnExamStarted()
        {
            Console.WriteLine($"Hey {Name}, Exam Started");
        }
    }
}