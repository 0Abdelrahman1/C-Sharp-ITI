//using System.Threading.Channels;

//namespace StoreConsoleAPP
//{
//    public record Order(int Items , decimal Cost);

//    internal class Program
//    {

//        //public static decimal CalcDiscount(Order order) => order switch
//        //{
//        //    { Items: > 10, Cost: > 1000 } => 0.1M,
//        //    { Items: >5 , Cost: >500 } => 0.05M,
//        //    _ => 0.01M
//        //};




//        public static decimal CalcDiscount(Order order) => order switch
//        {
//            (  > 10,  > 1000M ) => 0.1M,
//            (  > 5,  > 500M ) => 0.05M,
//            _ => 0.01M
//        };

//        static void Main(string[] args)
//        {
//            int? X = 12;

//            if ( X is int i)
//                Console.WriteLine(i);
//            else
//                Console.WriteLine("NULL");



//            string WaterState(int Temp) => Temp switch
//            {
//                ((>32) and (<212)) => "Liquid",
//                <32 => "Solid",
//                //>212 => "gas" ,
//                32 => "Solid/Liquid Transition",
//                212=> "Liquid/gas Transition",
//                _ => "Gas"
//            };


          


//        }

//        public static void TellTheType(object Obj)
//        {
//            switch(Obj)
//            {
//                case int i when i > 100: Console.WriteLine("Int Greater then 1000"); break;
//                case string S when S.Length > 10: Console.WriteLine("String Lenght > 10"); break;
//                case DateTime time: Console.WriteLine(time.ToString());break;
//                case bool Flag when Flag == true: Console.WriteLine("True");break;
//            };
//        }





//        public static string PerformanceOperation(string Command) =>
//            Command switch
//            {
//                "System Check" => "System Check Operation",
//                "Start Check"=> "Call Start Checkup",
//                _ => "Call Normal Check" //Default
//            };


//        public static T MidPoint<T> (IEnumerable<T> sequence)
//        {
//            if (sequence is null) throw new("Input is Null");
//            if (sequence is List<T> lst) return lst[lst.Count / 2];
//            else
//            {
//                int HalfLen = sequence.Count() / 2 - 1;
//                if (HalfLen > 0)   
//                    return sequence.Skip(HalfLen).First();
//            }
//            return default;
//        }

//        public static void Demo (Object Obj)
//        {
//            if (Obj is null) return;
            
//            //if (Obj is string Str)

//            if (Obj is string { Length :>4} Str)
//                Console.WriteLine(Str);
//        }

//    }
//}
