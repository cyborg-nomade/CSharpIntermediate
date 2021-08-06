using System;

namespace CSharpIntermediate
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copied shape into clipboard");
        }

        public void Select()
        {
            Console.WriteLine("Selected the shape");
        }
    }
}