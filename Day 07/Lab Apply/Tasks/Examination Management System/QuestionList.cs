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

        /// <summary>
        /// 
        /// 
        /// Behavior:
        ///•	Keep default Add behavior
        ///•	Additionally:
        ///o Open a file
        ///o Append the question details
        ///o   Each QuestionList must log to a unique file
        ///o File name passed via constructor
        ///Use:
        ///•	StreamWriter
        ///•	Append mode
        ///•	Proper using statement
        ///⚠️ Each QuestionList logs to a different file.
        /// 
        /// 
        /// 
        /// </summary>
        /// <param name="question"></param>
        public void Add(Question question)
        {
            base.Add(question);
        }

    }
}
