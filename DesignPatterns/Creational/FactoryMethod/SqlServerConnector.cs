using DesignPatterns.FactoryMethod;
using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class SqlServerConnector : DBConnector
    {
        public SqlServerConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override Connection Connect()
        {
            Console.WriteLine("conectando ao Sql Server Db");

            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
