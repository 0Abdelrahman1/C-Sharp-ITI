using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace D10
{
    internal struct Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public override string ToString() => $"({X},{Y},{Z})";

        public static bool operator == (Location Left , Location Right)
            => Left.X == Right.X && Left.Y == Right.Y && Left.Z == Right.Z ;

        public static bool operator !=(Location Left, Location Right)
            => Left.X != Right.X || Left.Y != Right.Y || Left.Z != Right.Z;

        public static Location operator -(Location Left, Location Right)
            => new()
            {
                X = Left.X - Right.X,
                Y = Left.Y - Right.Y,
                Z = Left.Z - Right.Z
            };
    }
}
