using System;

namespace Exercise01
{
    class Circle
    {
        private double radius;

        public void SetRadius(double r)
        {
            radius = r;
        }

        public double GetRadius()
        {
            return radius;
        }

        public double GetArea()
        {
            double area = 3.14 * radius * radius;
            return area;
        }

        public double GetCircumfence()
        {
            return 2 * 3.14 * radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Circle c2 = new Circle();

            Console.WriteLine($"Radius of circle c1 is {c1.GetRadius()}");

            c1.SetRadius(5);
            
            Console.WriteLine($"Radius of circle c1 is {c1.GetRadius()}");
            Console.WriteLine($"Radius of circle c2 is {c2.GetRadius()}");

            Console.WriteLine($"Area of circle c1 is {c1.GetArea()}");
            Console.WriteLine($"Circumfence of circle c1 is {c1.GetCircumfence()}");

            c2.SetRadius(10);

            if (c1.GetRadius() >= c2.GetRadius())
            {
                Console.WriteLine("c1 is bigger or equal");
            }
            else
            {
                Console.WriteLine("c2 is bigger");
            }
        }
    }
}
