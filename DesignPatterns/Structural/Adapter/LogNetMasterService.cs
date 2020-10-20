using System;

namespace DesignPatterns.Structural.Adapter
{
    // adaptee class
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogException(Exception exception)
        {
            Console.WriteLine("log customizado erro - " + exception.Message);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine("log customizado padrão - " + message);
        }
    }
}
