using System;

namespace Exercise01
{
    class Circle
    {
        // declare private field
        private double radius;

        // declare public method SetRadius
        public void SetRadius(double r)
        {
            radius = r;
        }

        // declare public method GetRadius
        public double GetRadius()
        {
            return radius;
        }

        // declare public method GetArea
        public double GetArea()
        {
            // calculate result in a local variable and return the variable
            double area = 3.14 * radius * radius;
            return area;
        }

        public double GetCircumfence()
        {
            // return result immediately
            return 2 * 3.14 * radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // declare and instatiate variables of type Circle
            Circle c1 = new Circle();
            Circle c2 = new Circle();

            // call public method GetRadius to get the radius of circle c1
            Console.WriteLine($"Radius of circle c1 is {c1.GetRadius()}");

            // call public method SetRadius to change the radius of circle c1
            c1.SetRadius(5);

            // radius of circle c1 has changed, but circle c2 is not affected
            // every object has its own values!
            Console.WriteLine($"Radius of circle c1 is {c1.GetRadius()}");
            Console.WriteLine($"Radius of circle c2 is {c2.GetRadius()}");

            // call public methods GetArea and GetCircumefence
            Console.WriteLine($"Area of circle c1 is {c1.GetArea()}");
            Console.WriteLine($"Circumfence of circle c1 is {c1.GetCircumfence()}");

            // methods can be used everywhere
            c2.SetRadius(10);
            
            if (c1.GetRadius() > c2.GetRadius())
            {
                Console.WriteLine("Circle c1 is bigger than circle c2");
            }
            else if (c1.GetRadius() < c2.GetRadius())
            {
                Console.WriteLine("Circle c2 is bigger than circle c1");
            }
            else
            {
                Console.WriteLine("Circles c1 and c2 are equal");
            }
        }
    }
}
