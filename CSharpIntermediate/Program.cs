using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            //var command = new DbCommand(new SqlConnection("conn-string"), "hey");
            var command = new DbCommand(new OracleConnection("conn-string"), "hey");
            command.Execute();
        }
    }
}
