﻿using System;

namespace DesignPatterns.Structural.Composite
{
    public class DomainMessage : IMessage
    {
        public string _message { get; set; }

        public DomainMessage(string message)
        {
            _message = message;
        }

        public void ExibirMensagens(int nivelMensagem) =>
            Console.WriteLine(new string('-', nivelMensagem) + _message);
    }
}
