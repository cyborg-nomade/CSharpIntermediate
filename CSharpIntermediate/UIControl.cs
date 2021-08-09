using System;
using System.Drawing;

namespace CSharpIntermediate
{
    public class UIControl
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {

        }

        public void Focus()
        {
            Console.WriteLine("Received focus.");
        }
    }
}