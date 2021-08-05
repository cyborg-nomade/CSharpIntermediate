using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Amazon;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            // UPCASTING
            /*Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);*/

            //StreamReader streamReader = new StreamReader(new MemoryStream());

            /*var list = new ArrayList
            {
                1,
                "Uriel",
                new Text()
            };

            var anotherList = new List<Shape>();*/


            // DOWNCASTING
            //Shape shape = new Text();
            //Text text = (Text)shape;

        }
    }
}
