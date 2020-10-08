using System;
using System.Linq;

namespace SOLID.OCP.Solucao_Extension_Methods
{
    /// <summary>
    /// Solução do OCP (Open/Closed principle - Princípio de aberto/fechado, uma classe
    /// deve estar fechada para modificação e aberta para extensão)
    /// com Extension methods
    /// </summary>
    public class DebitoConta
    {
        public string NumeroConta { get; set; }
        public decimal Valor { get; set; }
        public string NumeroTransacao { get; set; }

        public string FormatarTransacao()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            var random = new Random();

            NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            // Numero de transação formatado
            return NumeroTransacao;
        }
    }
}
