using System;

namespace DesignPatterns.Structural.Composite
{
    internal class InputFormMessage : IMessage
    {
        public string _message { get; set; }

        public InputFormMessage(string message)
        {
            _message = message;
        }

        public void ExibirMensagens(int nivelMensagem) => 
            Console.WriteLine(new string('-', nivelMensagem) + _message);
    }
}