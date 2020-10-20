using DesignPatterns.Creational.FactoryMethod;

namespace DesignPatterns.FactoryMethod
{
    public class OracleFactory : DBFactory
    {
        public override DBConnector CreateConnector(string connectionString)
        {
            return new OracleDbConnector(connectionString);
        }
    }
}