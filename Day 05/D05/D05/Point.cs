using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace D05
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        static int counter;
        public static int Counter { get { return counter; } }

        ///if no User Defined ctor exists , Compiler will generate 
        ///public Point() {} 
        ///if any user defined ctor exists with ANY signature , compiler will no longer generate parameterless ctor

        //public void SetX ( int _X)
        //{ X = _X; }
        ///Native Code
        ///public static void SetX ( Point this , int _X) { this.X = _X;}


        #region Operator Overloading
        //Operator overlading must be Static Member Function
        //Can't overload Assignment Operator (=)
        //can't explicitly overload compound operators (+= , -= .... )
        public static bool operator true (Point P) {  return P.X !=0 ||  P.Y !=0; }
        public static bool operator false(Point P) { return P.X == 0 && P.Y == 0; }


        public static explicit operator string (Point p) { return p.ToString (); }

        public static implicit operator  int (Point p) {  return Convert.ToInt32( Math.Sqrt (p.X * p.X + p.Y * p.Y)); }

        public static bool operator == (Point Left, Point Right) ///Requires != Operator
        { return Left.X == Right.X && Left.Y == Right.Y; }

        public static bool operator !=(Point Left, Point Right) 
        { return Left.X != Right.X || Left.Y != Right.Y; }

        public static Point operator ++ (Point P) ///both Pre , Post versions
        {
            return new Point() {  X = P.X+1 , Y = P.Y+1 };
        }

        public static Point operator +(Point L, int R) { return new Point() { X = L.X + R, Y = L.Y + R }; }

        public static Point operator + ( Point Left , Point Right )
        {
            ///Not Valid
            //X++; // this.X++
            //Y++;
            return new Point() { X = Left.X + Right.X, Y = Left.Y + Right.Y };
        }
        #endregion

        public Point(int _x=0, int _y=0)
        {
            X = _x;
            Y = _y;
            counter++;
        }
        ///Copy Ctor
        public Point(Point OldP)
        {
            X = OldP.X;
            Y = OldP.Y;
            counter++;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
