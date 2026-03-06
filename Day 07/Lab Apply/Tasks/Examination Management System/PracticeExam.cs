using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Examination_Management_System
{
    public class PracticeExam : Exam
    {
        public PracticeExam(int time, List<Question> questions, Subject subject, ExamMode mode = ExamMode.Queued) 
            : base(time, questions, subject, mode) {}

        public override object Clone()
        {
            return new PracticeExam(this.Time, this.Questions, this.Subject, this.Mode);
        }

        public override void ShowExam()
        {
            foreach (Question question in Questions)
            {
                question.Display();
                Console.WriteLine("-------------------------------------------------------");
            }
        }
        public override void Finish()
        {
            foreach (Question question in Questions)
            {
                question.Display();
                Console.Write($"Student Answers: {QuestionAnswerDictionary[question]}\n");
                Console.Write($"Correct Answers: {question.CorrectAnswers}\n");
                Console.WriteLine("-------------------------------------------------------");
            }
            Console.WriteLine($"Final Grade: {CorrectExam()}/{Questions.Sum(q => q.Marks)} Marks");
            Mode = ExamMode.Finished;
        }
    }
}
