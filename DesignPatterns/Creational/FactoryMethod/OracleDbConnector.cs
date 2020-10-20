using DesignPatterns.FactoryMethod;
using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class OracleDbConnector : DBConnector
    {
        public OracleDbConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override Connection Connect()
        {
            Console.WriteLine("conectando ao Oracle Db");

            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
