namespace D07_PI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TypeOneA A01 = new() { Name = "ahmed", Salary = 5000 };
            //A01.DoSomeWork();
            #region Interface Ex01

            //ISeries MySeries; ///valid 
            ////MySeries = new ISeries(); //Not Valid

            //SeriesByTwo byTwo = new SeriesByTwo();

            ////SeriesEngine.IterateSeries(byTwo); ///Boxing

            ////SeriesEngine.IterateSeries(new FibSeries());

            ////MySeries = new SeriesByTwo(); ///Boxing
            ////SeriesEngine.IterateSeries(MySeries);

            ////MySeries = new FibSeries();
            ////SeriesEngine.IterateSeries(MySeries);


            //MySeries= byTwo; ///Boxing

            //for (int i = 0; i < 3; i++) byTwo.MoveNext();

            //SeriesEngine.IterateSeries(MySeries);

            //Console.WriteLine(((ISeries)byTwo).Current); ///Explicit Calling 
            #endregion

            #region Interface Ex02
            //passwordTextBox textBox = new();

            ////textBox.Redo(); //Not Accessable

            //((IRedo)(textBox)).Redo(); //Call Explicit Implementation
            //                           //

            //EditTextBox textBox2 = new EditTextBox();
            //((IRedo)textBox2).Redo();
            //((IUndoRedo)textBox2).Redo();

            //Employee E = new Employee();

            ////E.Promote(); //Not Accessable
            //((IPerson)E).Promote(2);

            //Manager M = new();
            //M.Promote(3);

            //((IPerson)M).Promote(4);
            #endregion

            #region IComparable
            //int[] Arr = { 7, 2, 4, 6, 8, 3, 5, 1, 9 };

            //Array.Sort(Arr);

            //foreach (int i in Arr) 
            //    Console.WriteLine(i);

            //Point2D[] pArr = {
            //    new (){ X = 10 , Y = 20},
            //    new (){ X = 5 , Y = 5},
            //    new (){ X = 10 , Y = 15},
            //    new (){ X = 7 , Y = 20}};

            //Array.Sort(pArr);

            //foreach ( Point2D p in pArr)
            //    Console.WriteLine(p); 
            #endregion

            int A = 7, B = 3;

            //Utility.SWAP(ref A , ref B);
            //Utility.SWAP<int>(ref A, ref B); /// Generic Method
            Utility<int>.SWAP(ref A, ref B); /// Generic class


            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");

            double D1 = 1.2345, D2 = 1234.5;

            //Utility.SWAP(ref D1, ref D2);// Type inference 
            Utility<Double>.SWAP(ref D1, ref D2);

            Console.WriteLine($"D1 :{D1}");
            Console.WriteLine($"D2 :{D2}");

            string Str1 = "ABC", Str2 = "XYZ";
            //Utility.SWAP(ref Str1, ref Str2);
            //Utility<string>.SWAP(ref Str1, ref Str2);


            Console.WriteLine($"Str1 {Str1}");
            Console.WriteLine($"Str2 {Str2}");

            Point2D P1 = new() {  X = 10 , Y = 20 } ;
            Point2D P2 = new() { X = 30, Y = 40 };

            //Utility.SWAP(ref P1, ref P2);
            Utility<Point2D>.SWAP(ref P1, ref P2);

            Console.WriteLine($"P1 {P1}");
            Console.WriteLine($"P2 {P2}");

            //Utility.SWAP(ref P1, ref D2);

            Utility<int> utility = new Utility<int>();
        }
    }
}
