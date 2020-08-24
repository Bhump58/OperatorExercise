using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AreaOfCircle();
        }

        public static int Addition(int a, int b, int sum)
        {
            sum = a + b;
            return sum;
        }

        public static int Subtraction(int a, int b, int difference)
        {
            difference = a - b;
            return difference;
        }

        public static int Multiplication(int a, int b, int product)
        {
            product = a * b;
            return product;
        }

        public static int Division(int a, int b, int quotient)
        {
            quotient = a / b;
            return quotient;
        }

        public static int Modulous(int a, int b, int remainder)
        {
            remainder = a % b;
            return remainder;
        }

        public static void AreaOfCircle()
        {
            Console.WriteLine("Let's figure out the area of this circle.");
            Console.WriteLine("First let's get the radius of the circle: ");
            double r = Double.Parse(Console.ReadLine());
            Console.WriteLine("Got it, Your answer is: " + Math.PI * Math.Pow(r, 2));
            
        }


    }
}
