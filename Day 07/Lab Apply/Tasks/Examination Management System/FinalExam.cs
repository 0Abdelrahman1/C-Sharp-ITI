using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_Management_System
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, List<Question> questions, Subject subject, ExamMode mode = ExamMode.Queued) 
            : base(time, questions, subject, mode) {}

        public override object Clone()
        {
            return new FinalExam(this.Time, this.Questions, this.Subject, this.Mode);
        }
        public override void ShowExam()
        {
            foreach (Question question in Questions)
            {
                question.Display();
                Console.WriteLine("-------------------------------------------------------");
            }
        }
    }
}
