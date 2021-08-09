using System;

namespace CSharpIntermediate
{
    public class DbCommand
    {
        private DbConnection Connection { get; }
        private string Instruction { get; }

        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection != null)
            {
                Connection = connection;
            }

            if (!string.IsNullOrEmpty(instruction))
            {
                Instruction = instruction;
            }
        }

        public void Execute()
        {
            Connection.OpenConnection();
            Console.WriteLine(Instruction);
            Connection.CloseConnection();
        }
    }
}