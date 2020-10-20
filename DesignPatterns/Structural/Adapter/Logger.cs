using System;

namespace DesignPatterns.Structural.Adapter
{
    // target class
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("log padrão - " + message);
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine("log padrão de erro - " + exception.Message);
        }
    }
}
