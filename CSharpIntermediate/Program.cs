using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1990, 1, 1));
            Console.WriteLine(person.Age);
        }
    }
}
