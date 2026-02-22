namespace D04_PII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Properties
            Employee Emp = new(101, "Ali", 5000);

            Emp.ID = -20; ///Setting

            Console.WriteLine(Emp.ID); /// Getting

            Emp.SetName("Ahmed Ali"); /// Setter

            int R = Emp.GetName().Length; ///Getter

            Emp.Salary = 500; ///Set

            Console.WriteLine(Emp.Salary);
            ///Get

            Console.WriteLine(Emp.Taxes);

            //Emp.Taxes = 15;

            Console.WriteLine(Emp);
            #endregion

            #region Indexer
            //PhoneBook phoneBook = new PhoneBook(5);

            //phoneBook.SetEntry(0, "ABC", 123);
            //phoneBook.SetEntry(1, "XYZ", 456);
            //phoneBook.SetEntry(2, "KLM", 789);

            //phoneBook[3, "DEF"] = 5684;

            //phoneBook["ABC"] = 321; ///Set

            //Console.WriteLine(
            //    //phoneBook.GetNumber("XYZ")
            //    phoneBook["XYZ"] ///Get
            //    );

            //for (int i = 0; i < phoneBook.Size; i++)
            //    Console.WriteLine(phoneBook[i]); 
            #endregion

        }
    }
}
