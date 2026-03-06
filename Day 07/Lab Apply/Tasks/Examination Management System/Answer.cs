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

        public Answer(string text, int id = 0)
        {
            Text = text;
            Id = id;
        }

        public static explicit operator AnswerList(Answer obj)
        {
            return new([obj]);
        }

        public override string ToString()
        {
            return $"{Id}. {Text}";
        }

        public override bool Equals(object obj)
        {
            Answer that = obj as Answer;
            if (that == null) return false;
            return that.Text == Text;
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
