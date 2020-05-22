using System;

namespace Theory_Static
{
    // instance fields + instance methods -> anoikoun sto antikeimeno (xreiazomai antikeimeno_
    // static fields + instance methods -> anoikoun stin class (den xreiazetai antikeimeno)
    class Circle
    {
        public static double PI = 3.14; // static field

        private double radius; // instance field

        public void SetRadius(double r) // instance method
        {
            radius = r;
        }

        public double GetRadius() // instance method
        {
            return radius;
        }

        public double GetArea() // instance method
        {
            double area = PI * radius * radius;
            return area;
        }

        public double GetCircumfence() // instance method
        {
            return 2 * PI * radius;
        }

        public bool IsEqual(Circle other) // IsEqual -> instance method
        {
            return radius == other.radius;
        }

        public static bool AreEqual(Circle c1, Circle c2) // static method (DEN YPARXEI antikeimeno)
        {
            return c1.radius == c2.radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            c1.SetRadius(5);

            Circle c2 = new Circle();
            c2.SetRadius(5);

            // c1.PI den ginetai giati to PI den anoikei sto c1
            // Xrisimopoiw to onoma tis class
            Console.WriteLine($"PI is {Circle.PI}");

            Console.WriteLine($"Is c1 == c2? {c1.IsEqual(c2)}");

            // Xrisimopoiw to onoma tis class
            Console.WriteLine($"Is c1 == c2? {Circle.AreEqual(c1, c2)}");

            int result = Math.Max(10, 100);
            Console.WriteLine($"Largest number is {result}");

            Console.WriteLine($"Floor of 5.6 is {Math.Floor(5.6)}");
            Console.WriteLine($"Ceiling of 5.6 is {Math.Ceiling(5.6)}");
            Console.WriteLine($"Square root of 16 is {Math.Sqrt(16)}");
            Console.WriteLine($"2 ^ 8 is {Math.Pow(2, 8)}");
        }
    }
}
