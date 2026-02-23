namespace D05
{
    internal class Program
    {
        static void Main ()
        {
            // Console.WriteLine(Point.Counter);

            #region Class , Object , this , static Ex01
            //Point P1; ///Zero Bytes allocated in Heap 

            //P1 = new Point(10,10);

            //Object O1 = P1;

            //P1.SetX(20);
            ///Point::SetX(P1 , 20)

            //Point P2 ;

            ////P2 = P1;
            /////two Reference to the same object , Same Idnetity , same state 

            ////P2 = new Point(P1);
            ////P2 new Object with new identity , same state as P1

            ////P2.SetX(40);

            //Console.WriteLine($"P1 {P1.GetHashCode()}");
            //Console.WriteLine($"P2 {P2.GetHashCode()}");

            //Console.WriteLine(P1);
            //Console.WriteLine(P2);


            #endregion

            #region Operator Overloading
            //Point P1 = new() {  X =10 , Y =20 };
            //Point P2=new() { X =30 , Y =40 };

            //Point P3;
            //Point P4;
            ////P3 = Point.Sum(P1,P2);
            ////P3 = P1 + P2;
            //////P3 = Point.Operator+ (P1 ,P2);
            //////P3 = P1 + 7;

            ////P1 += P2;//P1 = P1 + P2;

            //P3 = ++P1;

            //P4 = P2++;

            //if ( P1 == P3)
            //    Console.WriteLine("EQ");
            //else
            //    Console.WriteLine("NEQ");

            //String Str = (string)P1; ///Explicit Casting
            ////Str = P2; //not valid

            //int R = P1; ///implicit Casting
            //R = (int)P2;

            //Console.WriteLine(P1);
            //Console.WriteLine(P2);
            //Console.WriteLine(P3);
            //Console.WriteLine(P4);
            //Console.WriteLine(Point.Counter);

            //Employee E = new Employee() { ID = 104, Name = "Ahmed Ali", Salary = 7000 };

            //Person P = (Person)E; 
            #endregion

            #region Static class , ctor 
            //Console.WriteLine(Utility.InchToCm(100));

            ////Utility U1 = new();//{ X = 1, Y = 2 };
            ////Utility U2 = new();// { Y = 3, X = 4 };

            //Console.WriteLine(Utility.InchToCm(10));

            //Console.WriteLine(Utility.CircleArea(50)); 
            #endregion

            GEngine G01;//= new GEngine(123456);
            GEngine G02;//= new GEngine(456789);

            //G01 = GEngine.GetObject();
            //G02 = GEngine.GetObject();

            G01 = GEngine.SingleTon;
            G02 = GEngine.SingleTon;

            Console.WriteLine(G01.GetHashCode());
            Console.WriteLine(G02.GetHashCode());


            #region Exception Handeling
            //try
            //{
            //    //DoSomeWork();
            //    DoSomeProtectiveWork();
            //}
            //catch //System.Exception
            //{
            //    Console.WriteLine("Inside Main General Catch ");
            //} 
            #endregion
        }

        public static void DoSomeProtectiveWork()
        {
            int  X , Y , Z;

            do
            {
                Console.WriteLine("Enter First Number");
            } while (!int.TryParse(Console.ReadLine(), out X));

            do
            {
                Console.WriteLine("Enter Second Number , greater Than  Zero");
            } while ((!int.TryParse(Console.ReadLine(), out Y)) || (Y <= 0));

            Z = X / Y;
            Console.WriteLine(Z);

            int[] Arr = [1, 2, 3, 4, 5];

            if (5 < Arr?.Length) Arr[5] = 20;



        }

        public static void DoSomeWork ()
        {

            try
            {
                int X , Y , Z;

                X = int.Parse(Console.ReadLine());
                Y = Convert.ToInt32(Console.ReadLine());

                if (Y <0) throw new NegativeArgumentException();

                Z = X / Y;

                Console.WriteLine($"Z = {Z}");

                int[] Arr = [ 1, 2, 3, 4, 5 ];

                Arr[5] = 20;
                
                Console.WriteLine("End of Try");

            }
            catch (DivideByZeroException ex)
            {

            }
            catch (FormatException Ex)
            {

            }
            catch (NegativeArgumentException Ex)
            { 
            }
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            finally
            {
                Console.WriteLine("Inside Finally");
            }
            Console.WriteLine("After Try/Catch");

        }


        static void OldMain(string[] args)
        {
            #region Primary Ctor , init Only , readonly , Automatic Properties 
            //Employee E1 = new Employee();
            //E1.ID = 101;
            //E1.Name = "Ahmed Ali";
            //E1.Salary = 10_000;

            //Employee E1 = new Employee() { ID = 101, Name = "Ahmed Ali", Salary = 10_000 };///Object Initializer

            //Employee E2 = new Employee() { Name = "Sayed Ali" };
            //E2.Name = "Mona ";
            ////E2.ID = 202;
            //Console.WriteLine(E2);

            //Employee emp = new Employee(101, "Ahmed Ali", 10_000); 
            #endregion
        }
    }
}
