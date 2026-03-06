using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Examination_Management_System
{
    public class ChooseAllQuestion : Question
    {
        public ChooseAllQuestion(string body, int marks, AnswerList answers, AnswerList correctAnswers)
            : base(QuestionType.MMCQ, body, marks, answers, correctAnswers) { }
        public override bool CheckAnswer(AnswerList studentAnswer)
        {
            return studentAnswer.SequenceEqual(CorrectAnswers);
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
