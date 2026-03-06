using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_Management_System
{
    public abstract class Question
    {
        public QuestionType Header { get; init; }
        public string Body { get; init; }
        public int Marks 
        {   
            get;
            init
            {
                if (value <= 0) throw new ArgumentException("Marks must be > 0");
                field = value;
            }
        }
        public AnswerList Answers { get; init; }
        public AnswerList CorrectAnswers { get; init; }

        protected Question(QuestionType header, string body, int marks, AnswerList answers, AnswerList correctAnswers)
        {
            Header = header;
            Body = body;
            Marks = marks;
            Answers = answers;
            CorrectAnswers = correctAnswers;
        }

        public abstract void Display();
        public abstract bool CheckAnswer(AnswerList studentAnswer);

        public static string GetQuestionTypeDisplay(QuestionType type) => type switch
        {
            QuestionType.TF => "True/False Question",
            QuestionType.SMCQ => "Choose Only One Correct Answer",
            QuestionType.MMCQ => "Choose All Correct Answers",
            _ => throw new ArgumentOutOfRangeException(nameof(type))
        };
        public override string ToString() => $"{{ Header:{Header}, Body:{Body}, Marks:{Marks}, Answers:[{string.Join('|', Answers)}], Correct Answers:[{string.Join('|', CorrectAnswers)}] }}";
        public override bool Equals(object obj)
        {
            Question that = obj as Question;
            if (that == null) return false;
            return this.Header == that.Header && this.Body == that.Body && this.Marks == that.Marks && this.Answers.Equals(that.Answers) && this.CorrectAnswers.Equals(that.CorrectAnswers);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
