using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Examination_Management_System
{
    public class QuestionList : List<Question>
    {
        public string path;

        public QuestionList(string path) { this.path = path; }

        public new void Add(Question question)
        {
            base.Add(question);

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(path, append: true))
            {
                writer.WriteLine(question.ToString());
            }
        }

    }
}
