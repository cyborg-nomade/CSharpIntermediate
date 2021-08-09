using System;

namespace CSharpIntermediate
{
    public class SqlConnection : DbConnection
    {
        public override void CloseConnection()
        {
            Console.WriteLine("SQL SERVER CLOSED CONNECTION");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("SQL SERVER OPENED CONNECTION");
        }

        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

    }
}