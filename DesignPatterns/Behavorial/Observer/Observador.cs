using System;

namespace DesignPatterns.Behavorial.Observer
{
    // Concrete observer
    internal class Observador : IObservador
    {
        public string Nome { get; }

        public Observador(string nome) =>
            Nome = nome;

        public void Notificar(Investimento investimento) =>
            Console.WriteLine($"Notificando {Nome} que {investimento._simbolo} " +
                $"teve preço alterado para {investimento.Valor}");
    }
}
