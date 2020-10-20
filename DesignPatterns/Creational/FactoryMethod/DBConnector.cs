namespace DesignPatterns.FactoryMethod
{
    // abstract product
    public abstract class DBConnector
    {
        protected string ConnectionString { get; set; }

        protected DBConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public abstract Connection Connect();
    }
}