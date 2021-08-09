using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("conn-string");
            var oracleConnection = new OracleConnection("conn-string");

            sqlConnection.OpenConnection();
            sqlConnection.CloseConnection();
            oracleConnection.OpenConnection();
            oracleConnection.CloseConnection();


        }
    }
}
