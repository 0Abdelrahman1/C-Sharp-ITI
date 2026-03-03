using Common;
namespace D06
{
    class TypeXY : TypeX
    {
        public TypeXY()
        {
            B = 2;
            D = 3;
            //E = 4;  ///not Accessable
            
        }
    }



    class Point3D : Point2D
    {
        public int Z { get; set;  }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Overriding System.Equals
            //Point2D P1 = new Point2D() {  X = 10 , Y = 20 } ;
            //Point2D P2 = new Point2D() { X = 10, Y = 20 };
            //Point2D P3 = P1;

            //Console.WriteLine($"P1 {P1.GetHashCode()}");
            //Console.WriteLine($"P2 {P2.GetHashCode()}");
            //Console.WriteLine($"P3 {P3.GetHashCode()}");

            //Console.WriteLine(P1.Equals(null));

            //Console.WriteLine(P1.Equals("P2"));


            //if (P1.Equals(P2))
            //    Console.WriteLine("P1 EQ P2");
            //else 
            //    Console.WriteLine("P1 NEQ P2");

            //if (P1.Equals(P3))
            //    Console.WriteLine("P1 EQ P3");
            //else
            //    Console.WriteLine("P1 NEQ P3");

            //Point3D P4 = new Point3D() { X = 10 , Y = 20 , Z = 30};

            //Console.WriteLine(P1.Equals(P4)); 
            #endregion

            #region Inheritance Ex01
            ////int X = 5;

            ////Console.WriteLine(Object.ReferenceEquals(X , X));

            ////TypeX O1 = new();
            ////O1.F = 1;   


            //Parent P = new Parent(1, 2);
            //P.X = 3;
            //P.Y = 4;

            //Console.WriteLine(P);
            ////Console.WriteLine(P.Mulxy());
            //Console.WriteLine(P.Mul());

            //Child C = new Child(5, 6, 7);
            //C.X = 8;
            //C.Y = 9;
            //C.Z = 10;

            //Console.WriteLine(C);
            ////Console.WriteLine(C.Mulxy());
            ////Console.WriteLine(C.Mulxyz());
            //Console.WriteLine(C.Mul()); // Child
            //                            //Console.WriteLine(C.Parent.Mul()); ///Not Valid
            //                            //Console.WriteLine(C.base.Mul()); ///Not Valid
            /////can't use base Keyword outside Child Class

            ////Console.WriteLine(((Parent)C).Mul()); ///Statically Binding  
            #endregion

            TypeBase BaseRef = new TypeBase(1);
            BaseRef.Show(); ///Base
            BaseRef.DynShow(); ///Base

            TypeDerived DerivedRef = new TypeDerived(2, 3);
            DerivedRef.Show(); // Derived
            DerivedRef.DynShow(); //Derived

            BaseRef = new TypeDerived(4, 5);
            BaseRef.Show(); //Base
            ///Statically , Early Binded Methods
            ///Compiler Bind Call to Funciton Body @ Compilation 
            ///Based on Reference Type Not Object Type
            
            
            
            //Dynamic Binding , Late Binding
            //Binding at Runtime by Clr based on Object Type not Reference Type
            BaseRef.DynShow(); ///Derived


            BaseRef = new TypeDerived02();
            BaseRef.DynShow();///Derived 02

            DerivedRef = new TypeDerived02();
            DerivedRef.DynShow(); ///Derived 02

            BaseRef = new TypeDerived03();
            BaseRef.DynShow(); //Derived 02

            DerivedRef = new TypeDerived03();
            DerivedRef.DynShow(); ///Derived 02

            TypeDerived03 D03 = new TypeDerived03();
            D03.DynShow(); ///Derived03

            ClassOne oneRef;
            //ClassOne TwoRef = new() ;



        }
    }
}
