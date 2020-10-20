using System;

namespace DesignPatterns.Structural.Adapter
{
    public interface ILogger
    {
        void Log(string message);
        void LogError(Exception exception);
    }
}