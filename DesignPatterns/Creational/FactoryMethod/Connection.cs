using System;

namespace DesignPatterns.FactoryMethod
{
    public class Connection
    {
        public string ConnectionString { get; set; }
        public bool Opened { get; set; }

        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Open()
        {
            Console.WriteLine("Executando comando Open");
        }

        public void Execute(string command)
        {
            Console.WriteLine("Executando comando: " + command);
        }

        public void Close()
        {
            Console.WriteLine("Executando comando Close");

        }
    }
}