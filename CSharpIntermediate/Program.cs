using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("Press enter to stop");
            Console.ReadLine();
            stopwatch.Stop();

            stopwatch.Start();

            Console.WriteLine("Press enter to stop");
            Console.ReadLine();
            stopwatch.Stop();
        }
    }
}
