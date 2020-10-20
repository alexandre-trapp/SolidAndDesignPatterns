using System;

namespace DesignPatterns.FactoryMethod
{
    public class ExecucaoFactoryMethod
    {
        public static void Executar()
        {
            var sqlConn = DBFactory.Database(DataBase.SqlServer)
                                   .CreateConnector("minhaCSSql")
                                   .Connect();

            sqlConn.Execute("select * from tabelaSql");
            sqlConn.Close();

            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

            var oracleConn = DBFactory.Database(DataBase.Oracle)
                                   .CreateConnector("minhaCSOracle")
                                   .Connect();

            sqlConn.Execute("select * from dual");
            sqlConn.Close();
        }
    }
}