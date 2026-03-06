using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Examination_Management_System
{
    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int Time {  get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; }
        public Dictionary<Question, AnswerList> QuestionAnswerDictionary { get; set; }
        public Subject Subject { get; set; }
        public ExamMode Mode { get; set; }

        protected Exam(int time, List<Question> questions, Subject subject, ExamMode mode = ExamMode.Queued)
        {
            Time = time;
            NumberOfQuestions = questions.Count;
            Questions = questions;
            Subject = subject;
            Mode = mode;
        }

        public abstract void ShowExam();
        public virtual void Start()
        {
            QuestionAnswerDictionary.Clear();
            Mode = ExamMode.Starting;
            Subject.NotifyStudents();
        }
        public virtual void Finish()
        {
            foreach (Question question in Questions)
            {
                question.Display();
                Console.Write($"Student Answers: {QuestionAnswerDictionary[question]}\n");
            }
        }
        public virtual int CorrectExam()
        {
            int totalMarks = 0;
            foreach (var q in Questions)
                if (q.Answers.Equals(QuestionAnswerDictionary[q]))
                    totalMarks += q.Marks;
            return totalMarks;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Time:{Time}\tNumber of Questions:{NumberOfQuestions}\tSubject:{Subject}\t");
            foreach (var q in Questions)
                sb.Append(q.ToString());

            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            Exam that = obj as Exam;
            if (that == null || Questions.Count != that.Questions.Count) return false;
            foreach (var q in Questions)
                if (!that.Questions.Contains(q))
                    return false;
            return true;
        }
        public override int GetHashCode()
        {
            var hash = new HashCode();
            foreach (var q in Questions)
                hash.Add(q.GetHashCode());
            return hash.ToHashCode();
        }

        public abstract object Clone();

        public int CompareTo(Exam that)
        {
            if (this.Time != that.Time) return this.Time.CompareTo(that.Time);
            return this.NumberOfQuestions.CompareTo(that.NumberOfQuestions);
        }
    }
}
