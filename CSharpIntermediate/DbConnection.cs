using System;

namespace CSharpIntermediate
{
    public abstract class DbConnection
    {
        private string ConnectionString { get; }
        private TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (!String.IsNullOrEmpty(connectionString))
            {
                ConnectionString = connectionString;
            }

            Timeout = new TimeSpan(0, 20, 0);
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}