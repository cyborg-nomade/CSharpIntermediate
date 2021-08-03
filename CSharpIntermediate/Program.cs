using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void UseOut()
        {
            var result = int.TryParse("abc", out var number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);

                //point.Move(new Point(40, 60));
                point.Move(null);
                Console.WriteLine("x:{0}, y:{1}", point.X, point.Y);

                point.Move(30, 30);
                Console.WriteLine("x:{0}, y:{1}", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred.");
            }
        }
    }
}
