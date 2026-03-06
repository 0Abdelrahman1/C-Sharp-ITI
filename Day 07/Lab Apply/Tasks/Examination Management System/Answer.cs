using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Examination_Management_System
{
    public class Answer : IComparable<Answer>
    {
        public int Id { get; set; }
        public string Text { get; init; }

        public Answer(string text)
        {
            Text = text;
        }

        public static explicit operator AnswerList(Answer obj)
        {
            return new([obj]);
        }

        public override string ToString()
        {
            return $"{'a' + Id}. {Text}";
        }

        public override bool Equals(object obj)
        {
            Answer that = obj as Answer;
            if (that == null) return false;
            return that.Id == Id && that.Text == Text;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Text);
        }

        public int CompareTo(Answer other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}
