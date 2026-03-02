namespace Task1
{
    internal class Point(double x, double y, double z) : IComparable<Point>, ICloneable
    {
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public double Z { get { return z; } set { z = value; } }

        public Point() : this(default, default, default) { }
        public Point(double x) : this(x, default, default) { }
        public Point(double x, double y) : this(x, y, default) { }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public static implicit operator string (Point p)
        {
            return p.ToString(); 
        }

        public void TryRead()
        {
            string[] xyz;
            do
            {
                Console.WriteLine("Enter 3D Point , format: \"(x, y, z)\"");
                xyz = Console.ReadLine().Split(new char[] {'(', ')', ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            } while (!double.TryParse(xyz[0], out x) || !double.TryParse(xyz[1], out y) || !double.TryParse(xyz[2], out z));
        }

        public void Read()
        {
            string[] xyz;
        start:
            Console.WriteLine("Enter 3D Point , format: \"(x, y, z)\"");
            xyz = Console.ReadLine().Split(new char[] { '(', ')', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                x = double.Parse(xyz[0]);
                y = Convert.ToDouble(xyz[1]);
                z = Convert.ToDouble(xyz[2]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("******Try Again*******");
                Console.WriteLine();
                goto start;
            }
        }
        public override bool Equals(object? obj)
        {
            Point that = obj as Point;
            if (that == null) return false;
            if (that.GetType() != this.GetType()) return false;
            
            return this.X == that.X && this.Y == that.Y && this.Z == that.Z;
        }

        public int CompareTo(Point? other)
        {
            if (this.X != other.X) return this.X.CompareTo(other.X);
            return this.Y.CompareTo(other.Y);
        }
        public object Clone()
        {
            return new Point() { X = this.X, Y = this.Y, Z = this.Z };
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point P1 = new() { X = 100, Y = 2, Z = 3 }, P2 = new() { X = 10, Y = 20, Z = 30 };
            Point[] ps = [P1, P2];
            ps.Sort();
            foreach (Point p in ps) Console.WriteLine(p);
            Console.WriteLine();
            Console.WriteLine();

            P1.TryRead();
            P2.Read();

            // == compares references, not values — will print NEQ even for identical coordinates
            Console.WriteLine(P1 == P2 ? "EQ" : "NEQ");

            // Equals compares values — will print EQ if coordinates match
            Console.WriteLine(P1.Equals(P2) ? "EQ" : "NEQ");

            P1 = P2;
            // Now same reference — == prints EQ
            Console.WriteLine(P1 == P2 ? "EQ" : "NEQ");


        }
    }
}
