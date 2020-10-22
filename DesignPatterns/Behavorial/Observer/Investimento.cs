using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavorial.Observer
{
    //Subject
    public abstract class Investimento
    {
        public string _simbolo;
        private decimal _valor;
        private readonly List<IObservador> _observadores = new List<IObservador>();

        protected Investimento(string simbolo, decimal valor)
        {
            _simbolo = simbolo;
            _valor = valor;
        }

        public decimal Valor
        {
            get => _valor;
            set
            {
                if (_valor == value)
                    return;

                _valor = value;
                Notificar();
            }
        }

        public void Subscribe(IObservador observador)
        {
            _observadores.Add(observador);
            Console.WriteLine($"Notificando que {observador.Nome} está recebendo atualizações de {_simbolo}");
        }

        public void UnSubscribe(IObservador observador)
        {
            _observadores.Remove(observador);
            Console.WriteLine($"Notificando que {observador.Nome} NÂo está recebendo atualizações de {_simbolo}");
        }

        private void Notificar() 
        {
            _observadores.ForEach(investidor => 
                investidor.Notificar(this));

            Console.WriteLine();
        }
    }
}
