//namespace D09_PII
//{
//    internal class Program
//    {
//        public static List<int> FindOdd(List<int> Lst)
//        {
//            List<int> oLst = new();
//            for (int i = 0; i < Lst?.Count; i++)
//                if (Lst[i] % 2 == 1)
//                    oLst.Add(i);
//            return oLst;
//        }

//        public static List<int> FindEven(List<int> Lst)
//        {
//            List<int> oLst = new();
//            for (int i = 0; i < Lst?.Count; i++)
//                if (Lst[i] % 2 == 0)
//                    oLst.Add(i);
//            return oLst;
//        }

//        public static List<int> FindDivBy7(List<int> Lst)
//        {
//            List<int> oLst = new();
//            for (int i = 0; i < Lst?.Count; i++)
//                if (Lst[i] % 7 == 0)
//                    oLst.Add(i);
//            return oLst;
//        }


//        static void Main(string[] args)
//        {
//            List<int> iLst = Enumerable.Range(0, 100).ToList();

//            List<int> Lst2;

//            Lst2 = FindOdd(iLst);

//            Lst2 = FindEven(iLst);

//            Lst2 = FindDivBy7(iLst);

//            foreach (var item in Lst2)
//                Console.Write($"{item} , ");
//            Console.WriteLine();


//        }
//    }
//}
