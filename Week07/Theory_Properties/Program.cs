using System;

namespace Theory_Properties
{
    // Ta properties kai oi methodoi voithoun sto "encapsulation" tis leitourgias tis class

    class Circle
    {
        public static double PI { get; } // static property (read-only)

        // Automatically Implemented Property -> Auto Property
        public double X { get; private set; } // O compiler tha ftiaxei monos tou to private field x
        public double Y { get; private set; } // kai to private field y

        // field
        private double radius;

        // Property
        public double Radius 
        {
            // Kaleitai otan kanw anaktisi mesw tou onomatos
            get
            {
                return radius;
            }
            // Kaleitai otan kanw anathesi mesw tou =
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                radius = value;
            }
        }

        public double Circumefence
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }

        static Circle()
        {
            PI = 3.14;
        }

        // Overloading
        // Constructors can be overloaded
        public Circle()
        {

        }

        public Circle(double r)
        {
            Radius = r;
        }

        public Circle(double r, double x, double y)
        {
            Radius = r;
            X = x;
            Y = y;
        }

        public void Move(double dx, double dy)
        {
            X = X + dx;
            Y = Y + dy;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(); // call the default constructor
            c1.Radius = 10;
            Console.WriteLine($"{c1.Radius}");

            // antiparavoli me int
            int x;
            x = 10;
            Console.WriteLine($"{x}");

            // antiparavoli me an to radius itan public
            //c1.radius = 20;
            //Console.WriteLine($"{c1.radius}");

            c1.Radius = 20;
            Console.WriteLine($"{c1.Radius}");

            Console.WriteLine($"Circumfence is {c1.Circumefence}");

            // c1.X = 50; // thelw na to apagoreusw
            c1.Move(50, 0);


            // CONSTRUCTORS
            Circle c2 = new Circle(); // default constructor
            Console.WriteLine($"C2 | X: {c2.X} Y: {c2.Y} Radius: {c2.Radius}");

            Circle c3 = new Circle(10); // constructor with 1 parameter
            Console.WriteLine($"C3 | X: {c3.X} Y: {c3.Y} Radius: {c3.Radius}");

            Circle c4 = new Circle(5, 3, 2); // constructor with 3 parameter
            Console.WriteLine($"C4 | X: {c4.X} Y: {c4.Y} Radius: {c4.Radius}");

        }
    }
}
