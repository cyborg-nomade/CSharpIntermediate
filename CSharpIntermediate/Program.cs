using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Uriel";
            Console.WriteLine(cookie["name"]);
        }
    }
}
