using System;

namespace DesignPatterns.Behavorial.Command
{
    internal class Calculadora
    {
        private int _valorAtual;

        public void Operacao(char operador, int valor)
        {
            switch (operador)
            {
                case '+': _valorAtual += valor; break;
                case '-': _valorAtual -= valor; break;
                case '*': _valorAtual *= valor; break;
                case '/': _valorAtual /= valor; break;
            }

            Console.WriteLine($"(dado {operador} {valor}) - Valor atual = {_valorAtual}");
        }
    }
}
