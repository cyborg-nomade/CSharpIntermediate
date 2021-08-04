using System.Diagnostics.SymbolStore;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text { Width = 100 };
            text.Copy();
        }
    }
}
