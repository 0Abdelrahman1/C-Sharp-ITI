using System;
using System.Collections.Generic;
using System.Text;
//using static System.Object; ///Call Static Members of Object Class Directly 

namespace D06
{
    internal class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }

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
    }
}
