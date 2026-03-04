namespace D10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball();

            Player P11 = new() { Name = "P11", Team = "T01" };
            Player P12 = new() { Name = "P12", Team = "T01" };
            Player P21 = new() { Name = "P21", Team = "T02" };
            Player P22 = new() { Name = "P22", Team = "T02" };
            Player P23 = new() { Name = "P23", Team = "T02" };


            Referee R01 = new() { Name = "R01" };

            ball.Location = new() { X = 10, Y = 10, Z = 10 };

            ///Subscribtion , Registration 
            ///Add To Publisher Invocation List , Pointer to Subsc. CallBackMethod
            //ball.LocationChanged += new Action(P11.Run);
            ball.LocationChanged += new Action<Location>(P11.Run);
            ball.LocationChanged += P12.Run;
            ball.LocationChanged += P21.Run;
            ball.LocationChanged += P22.Run;
            ball.LocationChanged += R01.Look;
            //ball.LocationChanged += () => Console.WriteLine("Adhock CallBackMethod");
            ball.LocationChanged += D => Console.WriteLine($"Anonymous Method {D}");


            ball.Location = new() { X = 20, Y = 30, Z = 40 };

            ///UnRegistration
            ball.LocationChanged -= P22.Run;

            ball.LocationChanged += P23.Run;
            Console.WriteLine("After Substitution");
            ball.Location = new() { X = 50, Y = 50, Z = 50 };



        }
    }
}
