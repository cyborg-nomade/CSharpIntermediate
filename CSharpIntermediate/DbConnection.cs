using System;

namespace CSharpIntermediate
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("ORACLE OPENED CONNECTION");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("ORACLE CLOSED CONNECTION");
        }
    }
    public abstract class DbConnection
    {
        private string ConnectionString { get; }
        private TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString, TimeSpan timeout)
        {
            if (!String.IsNullOrEmpty(connectionString))
            {
                ConnectionString = connectionString;
            }

            Timeout = timeout;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}