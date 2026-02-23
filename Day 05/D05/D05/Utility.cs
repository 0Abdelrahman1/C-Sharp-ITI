using System;
using System.Collections.Generic;
using System.Text;

namespace D05
{
    ///Container for only static members ( ctor , properties , fields , Methods )
    ///Can't Create Instance from Static clas , nor Inherit static class
    internal static class Utility
    {
        //public int X { get; set;  }
        //public int Y { get; set; }

        ///don't depend on Object State , better to be Class Method
        public static double InchToCm (double Inch) { return Inch * 2.45; }

        public static double CmToInch (double Cm) { return Cm / 2.45; }

        public static double PI { get; } = 3.14;


        //static double Pi;

        //public static double PI { get { return PI; } }

        /////Only Once , Before Class first use
        /////Can't Specify explicitly Access Modifier , must be Parameterless 
        //static Utility() ///Static Ctor
        //{
        //    Pi = 3.14;
        //    Console.WriteLine("Static Ctor");
        //}


        ///Object Ctor
        //public Utility()
        //{
        //    Console.WriteLine("Object Ctor");
        //}

        public static double CircleArea (double R)
        {
            return PI *R * R; 
        }

    }
}
