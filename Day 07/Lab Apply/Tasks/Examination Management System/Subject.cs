namespace Examination_Management_System
{
    public class Subject
    {
        public string Name { get; set; }
        public List<Student> EnrolledStudents;

        public Subject(string name, List<Student> enrolledStudents)
        {
            Name = name;
            EnrolledStudents = enrolledStudents;
        }
        public void Enroll(Student student)
        {
            EnrolledStudents.Add(student);
        }
        public void NotifyStudents()
        {
            foreach (Student student in EnrolledStudents)
                student.OnExamStarted();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}