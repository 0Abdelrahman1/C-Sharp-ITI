namespace Examination_Management_System
{
    internal class Program
    {
        // Main is Generated
        static void Main(string[] args)
        {
            // 1. Create a Subject
            Subject csharp = new Subject("C#", []);

            // 2. Create Students and enroll them
            Student student1 = new Student("Ahmed", 1);
            Student student2 = new Student("Sara", 2);
            csharp.Enroll(student1);
            csharp.Enroll(student2);

            // 3. Create Questions
            TrueFalseQuestion q1 = new TrueFalseQuestion(
                "C# is an object-oriented language?", 5, new Answer("True"));

            AnswerList smcqAnswers = new AnswerList([
                new Answer("Python") { Id = 0 },
                new Answer("C#") { Id = 1 },
                new Answer("HTML") { Id = 2 },
                new Answer("CSS") { Id = 3 }
            ]);
            ChooseOneQuestion q2 = new ChooseOneQuestion(
                "Which is a .NET language?", 10, smcqAnswers, new Answer("C#") { Id = 1 });

            AnswerList mmcqAnswers = new AnswerList([
                new Answer("int") { Id = 0 },
                new Answer("string") { Id = 1 },
                new Answer("float") { Id = 2 },
                new Answer("div") { Id = 3 }
            ]);
            AnswerList mmcqCorrect = new AnswerList([
                new Answer("int") { Id = 0 },
                new Answer("string") { Id = 1 },
                new Answer("float") { Id = 2 }
            ]);
            ChooseAllQuestion q3 = new ChooseAllQuestion(
                "Select all C# data types:", 15, mmcqAnswers, mmcqCorrect);

            List<Question> questions = [q1, q2, q3];

            // 4. Create one PracticeExam and one FinalExam
            PracticeExam practiceExam = new PracticeExam(30, questions, csharp);
            FinalExam finalExam = new FinalExam(60, questions, csharp);

            // 5. Ask user to select exam type
            Console.WriteLine("Select Exam Type:");
            Console.WriteLine("1 - Practice");
            Console.WriteLine("2 - Final");
            Console.Write("> ");

            string choice = Console.ReadLine();
            Exam selectedExam = choice switch
            {
                "1" => practiceExam,
                "2" => finalExam,
                _ => throw new ArgumentException("Invalid choice")
            };

            // 6. Start exam → Change Mode to Starting → Trigger notification
            selectedExam.Start();

            Console.WriteLine("=======================================================");

            // Show exam and collect answers per question
            foreach (Question question in selectedExam.Questions)
            {
                question.Display();
                Console.WriteLine("-------------------------------------------------------");

                if (question.Header == QuestionType.MMCQ)
                {
                    Console.Write("Enter answer IDs (comma-separated, e.g. 0,1,2): ");
                    string[] ids = Console.ReadLine()!.Split(',');
                    List<Answer> selected = [];
                    foreach (string id in ids)
                        selected.Add(question.Answers[int.Parse(id.Trim())]);
                    selectedExam.QuestionAnswerDictionary[question] = new AnswerList(selected);
                }
                else
                {
                    Console.Write("Enter answer ID: ");
                    int answerId = int.Parse(Console.ReadLine()!);
                    selectedExam.QuestionAnswerDictionary[question] = new AnswerList([question.Answers[answerId]]);
                }

                Console.WriteLine("=======================================================");
            }

            // Finish exam
            selectedExam.Finish();
        }
    }
}
