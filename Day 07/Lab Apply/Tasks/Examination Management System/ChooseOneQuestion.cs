using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_Management_System
{
    public class ChooseOneQuestion : Question
    {
        public ChooseOneQuestion(string body, int marks, AnswerList answers, Answer correctAnswer)
            : base(QuestionType.SMCQ, body, marks, answers, (AnswerList)correctAnswer) { }
        public override bool CheckAnswer(AnswerList studentAnswer)
        {
            if (studentAnswer.Count != 1) throw new ArgumentException("studentAnswer.Count must == 1");
            return studentAnswer[0].Equals(CorrectAnswers[0]);
        }
        public override void Display()
        {
            Console.WriteLine($"{Body}\t\t\t[{Marks}.00 Marks]");
            Console.WriteLine($"{new string(' ', Body.Length)}\t\t\t<{GetQuestionTypeDisplay(Header)}>");
            for (var id = 0; id < Answers.Count; id++)
                Console.WriteLine(Answers[id]);
        }
    }
}
