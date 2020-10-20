using System;

namespace DesignPatterns.FactoryMethod
{
    public abstract class DBFactory
    {
        public static DBFactory Database(DataBase database)
        {
            if (database == DataBase.SqlServer)
                return new SqlFactory();

            if (database == DataBase.Oracle)
                return new OracleFactory();

            throw new ApplicationException("Banco de dados não reconhecido");
        }

        public abstract DBConnector CreateConnector(string connectionString);
    }
}