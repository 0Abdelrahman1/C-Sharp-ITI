using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace D08
{
    public class Point2D : IComparable
    {
        public int X { get; init; }
        public int Y { get; init; }

        public int CompareTo(object? obj)
        /// +ver : this > obj , -ver : this < obj , 0: this == obj
        {
            if ((obj is Point2D Right) && (Right != null))
            {
                if (X == Right.X)
                    return Y.CompareTo(Right.Y);
                return X.CompareTo(Right.X);
            }
            return 1;
        }

        public override bool Equals(object obj)
        {
            Point2D Right = obj as Point2D; ///evaluate to null if Casting Fails , No Exceptions will be thrown

            if (Right == null) return false;

            if (this.GetType() != Right.GetType()) return false;

            if (Object.ReferenceEquals(this, Right)) return true;

            return X == Right.X && Y == Right.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

    }
}
