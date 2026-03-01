using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace D07_PI
{
    public class Point2D:IComparable , IAdditionOperators<Point2D,Point2D,Point2D>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int CompareTo(object? obj) 
        /// +ver : this > obj , -ver : this < obj , 0: this == obj
        {
            if (( obj is Point2D Right) && (Right != null))
            {
                if (X == Right.X)
                    return Y.CompareTo(Right.Y);
                return X.CompareTo(Right.X);
            }
            return 1;
        }

        public override bool Equals(object obj)
        {
            //Point2D Right =(Point2D) obj;  ///UNSAFE
            //ref to Derived = Base
            #region Is Safe Casting

            ///Check return true if casting will succeed , false if not , No Exceptions will be thrown
            //if (obj is Point2D)  
            //{
            //    Point2D Right=(Point2D)obj; 

            //    return X == Right.X && Y == Right.Y;
            //}

            //if (obj is Point2D Right)
            //    return X == Right.X && Y == Right.Y;
            //else
            //    return false; 
            #endregion

            Point2D Right = obj as Point2D; ///evaluate to null if Casting Fails , No Exceptions will be thrown

            if (Right == null) return false;

            if (this.GetType() != Right.GetType()) return false;

            if (Object.ReferenceEquals(this, Right)) return true;

            return X == Right.X && Y == Right.Y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public static Point2D operator +(Point2D left, Point2D right)
        {
            return new Point2D() { X = (left?.X??0) + (right?.X??0), Y = left.Y + right.Y };
        }
    }
}
