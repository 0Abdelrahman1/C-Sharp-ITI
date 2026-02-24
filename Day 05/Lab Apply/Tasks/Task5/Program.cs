using System.Runtime.CompilerServices;

namespace Task5
{
    internal class Program
    {
        public class Duration
        {
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }

            public override string ToString()
            {
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            }

            public override bool Equals(object? obj)
            {
                Duration that = obj as Duration;
                if (that == null) return false;
                if (this.GetType() != that.GetType()) return false;

                return this.Hours == that.Hours && this.Minutes == that.Minutes && this.Seconds == that.Seconds;
            }

            public override int GetHashCode()
            {
                return 2 * base.GetHashCode();
            }

            public Duration(int Hours = default, int Minutes = default, int Seconds = default)
            {
                this.Seconds = Hours * 3600 + Minutes * 60 + Seconds;
                this.Hours = this.Seconds / 3600;
                this.Minutes = this.Seconds / 60 % 60;
                this.Seconds = this.Seconds % 60;
            }
            public Duration(int seconds) : this(Seconds: seconds) { }

            public static Duration operator+(Duration l, Duration r)
            {
                return new Duration(l.Hours + r.Hours, l.Minutes + r.Minutes, l.Seconds + r.Seconds);
            }
            public static Duration operator+(Duration d, int seconds)
            {
                return new Duration(d.Hours, d.Minutes, d.Seconds + seconds);
            }
            public static Duration operator+(int seconds, Duration d)
            {
                return new Duration(d.Hours, d.Minutes, d.Seconds + seconds);
            }
            public static Duration operator++(Duration d)
            {
                return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
            }
            public static Duration operator--(Duration d)
            {
                if (d.Hours == 0 && d.Minutes == 0) return new Duration(d.Hours, 59, d.Seconds);
                return new Duration(d.Hours, d.Minutes - 1, d.Seconds);
            }
            public static Duration operator-(Duration d)
            {
                return new Duration(-d.Hours, -d.Minutes, -d.Seconds);
            }
            public static bool operator<(Duration l, Duration r)
            {
                if (l.Hours != r.Hours) return l.Hours < r.Hours;
                if (l.Minutes != r.Minutes) return l.Minutes < r.Minutes;
                return l.Seconds < r.Seconds;
            }
            public static bool operator >(Duration l, Duration r)
            {
                if (l.Hours != r.Hours) return l.Hours > r.Hours;
                if (l.Minutes != r.Minutes) return l.Minutes > r.Minutes;
                return l.Seconds > r.Seconds;
            }
            public static bool operator <=(Duration l, Duration r)
            {
                return !(l > r);
            }
            public static bool operator >=(Duration l, Duration r)
            {
                return !(l < r);
            }
            public static implicit operator bool(Duration d)
            {
                return d.Hours != 0 || d.Minutes != 0 || d.Seconds != 0;
            }
            public static explicit operator DateTime (Duration d)
            {
                return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, d.Hours, d.Minutes, d.Seconds);
            }
        }
        static void Main(string[] args)
        {
            Duration D = new Duration(1, 10, 15);
            Console.WriteLine(D.ToString());
            //Output: Hours: 1, Minutes: 10 , Seconds: 15

            Duration D1 = new Duration(3600);
            Console.WriteLine(D1.ToString());
            //Output: Hours: 1, Minutes: 0 , Seconds: 0

            Duration D2 = new Duration(7800);
            Console.WriteLine(D2.ToString());
            //Output: Hours: 2, Minutes: 10 , Seconds: 0

            Duration D3 = new Duration(666);
            Console.WriteLine(D3.ToString());
            //Output: Minutes: 11 , Seconds: 6

            D3 = D1 + D2;
            D3 = D1 + 7800;
            D3 = 666 + D3;
            D3 = D1++; //(Increase One Minute);
            D3 = --D2; //(Decrease One Minute)
            D1 = D2;
            if (D1 > D2) ;
            if (D1 <= D2) ;
            if (D1) ;
            DateTime Obj = (DateTime)D1;
            Console.WriteLine((DateTime)new Duration(23, 0, 0));
        }
    }
}
