using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1990, 8, 28));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
