using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;
using Model;

namespace D03_PII
{

    class Employee
    {
        public Department Department;
    }

    class Department
    {
        public string Name = null;
    }

    enum Grades
    { A , B , C , D , F}

    enum Branches:byte
    {
        SV = 101 , Mansoura , Ismailia = 204 , Assuit , Alex 
    }
    [Flags]
    enum Permissions:byte
    { Read = 0x08 , Write = 4, Execute = 0b_0000_0010 , Delete = 1 , Root = 15 , 
        SuperUser=0b_0000_1110}

    internal class Program
    {
        static void Main(string[] args)
        {

            #region Struct
            ////TypeA A;
            ////A.Z = 2;

            ////Point P1;
            /////Allocation 8 Uninitialized Bytes in Stack ;

            ////P1.SetX(5);
            ////P1.Show();

            //Point P2 = new Point(5, 10);
            /////new : for ctor Selection 
            /////Allocation 8 Bytes in STACK , use new to select which ctor to initialize
            //P2.Show();

            //Point P3 = new(5); /// Short hand version of new Point(5)
            //P3.Show();

            //Point P4 = new Point(); ///user defined parameterless ctor
            //P4.Show();

            //Point P5 = default; ///Explicit use of Generated Parameterless ctor
            //P5.Show();

            //int X = new int();
            //Console.WriteLine(X);

            //Console.WriteLine(P2.ToString());
            //Console.WriteLine(P3); 
            #endregion

            #region Enum Ex01
            //Grades MyG;

            //MyG = Grades.A;

            //if ( MyG == Grades.A)
            //    Console.WriteLine("Excellent");

            //MyG = Grades.D;

            //switch (MyG)
            //{
            //    case Grades.A:
            //    case Grades.B:
            //    case Grades.C:
            //    case Grades.D:
            //        Console.WriteLine(":)");
            //        break;
            //    case Grades.F:
            //        Console.WriteLine(":(");
            //        break;
            //    default:
            //        break;
            //}


            //Console.WriteLine(MyG); 
            #endregion

            #region Enum Ex02
            //Branches MyB = Branches.SV;

            //MyB = (Branches)4;

            //Console.WriteLine(MyB);

            //MyB = (Branches)101;

            //Console.WriteLine(MyB); 
            #endregion

            #region Enum Ex03

            //Permissions P;

            //P = Permissions.Read;
            //P^= Permissions.Write;

            //P = (Permissions)0x0F;
            //P ^= Permissions.Delete;

            //Console.WriteLine(P);

            //if (P == Permissions.Read) ; /// P == 1000
            /////P:1110
            /////&
            /////1000
            /////X000
            //if ( (P&Permissions.Read) == Permissions.Read )
            //    Console.WriteLine("Granted");
            //else
            //    Console.WriteLine("No Access"); 
            #endregion

            #region Switch Case
            //int M = int.Parse(Console.ReadLine());

            //switch (M)
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;
            //    default:
            //        Console.WriteLine("NA");
            //        break;
            //}

            //switch(M)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("31");
            //        break;
            //    case 2:
            //        Console.WriteLine("28");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("30");
            //        break;
            //}

            int Value = 3000;

            //switch(Value)
            //{
            //    case 3000:
            //        Console.WriteLine("Option 03");
            //        Console.WriteLine("Option 02");
            //        Console.WriteLine("Option 01");
            //        break;
            //    case 2000:
            //        Console.WriteLine("Option 02");
            //        Console.WriteLine("Option 01");
            //        break;
            //    case 1000:
            //        Console.WriteLine("Option 01");
            //        break;
            //}

            //switch (Value)
            //{
            //    case 3000:
            //        Console.WriteLine("Option 03");
            //        goto case 2000;
            //    case 2000:
            //        Console.WriteLine("Option 02");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("Option 01");
            //        break;
            //}

            #endregion

            //string Str = Console.ReadLine();

            //switch (Str)
            //{
            //    case "1":
            //        Console.WriteLine("Jan");
            //        break;
            //    case "2":
            //        Console.WriteLine("Feb");
            //        break;
            //    case "3":
            //        Console.WriteLine("Mar");
            //        break;
            //    case "4":
            //        Console.WriteLine("Apr");
            //        break;
            //    case "5":
            //        Console.WriteLine("May");
            //        break;
            //    case "6":
            //        Console.WriteLine("Jun");
            //        break;
            //    case "7":
            //        Console.WriteLine("Jul");
            //        break;
            //    case "8":
            //        Console.WriteLine("Aug");
            //        break;
            //    default:
            //        Console.WriteLine("NA");
            //        break;
            //}

         
        

        }

    }
}
