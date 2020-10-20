using DesignPatterns.Creational.FactoryMethod;

namespace DesignPatterns.FactoryMethod
{
    public class SqlFactory : DBFactory
    {
        public override DBConnector CreateConnector(string connectionString)
        {
            return new SqlServerConnector(connectionString);
        }
    }
}