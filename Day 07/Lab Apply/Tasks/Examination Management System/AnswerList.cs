namespace Examination_Management_System
{
    public class AnswerList
    {
        private List<Answer> Answers;
        public int Count { get; private set; }

        public AnswerList() { }
        public AnswerList(List<Answer> answers)
        {
            Answers = answers;
            Count = answers.Count;
        }

        public override bool Equals(object obj)
        {
            AnswerList that = obj as AnswerList;
            if (that == null) return false;
            return this.SequenceEqual(that);
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            foreach (Answer answer in Answers)
                hash.Add(answer);
            return hash.ToHashCode();
        }

        public override string ToString()
        {
            return $"[{string.Join('|', Answers)}]";
        }

        public bool SequenceEqual(AnswerList that)
        {
            return this.Answers.SequenceEqual(that.Answers);
        }

        public Answer GetById(int id)
        {
            return Answers.Single(ans => ans.Id == id);
        }

        public void Add(Answer answer)
        {
            answer.Id = Count;
            Answers.Add(answer);
            Answers.Sort();
            Count++;
        }

        public Answer this[int i]
        {
            get
            {
                if (i < 0 || i >= Answers.Count) throw new IndexOutOfRangeException();
                return Answers[i];
            }
        }
    }
}