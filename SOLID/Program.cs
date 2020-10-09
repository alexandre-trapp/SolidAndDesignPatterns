using System;
using SOLID.OCP.Solucao_Extension_Methods;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - OCP");
            Console.WriteLine("2 - LSP");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    CaixaEletronico.Operacoes();
                    break;
                case '2':
                    LSP.Violacao.CalculoArea.Calcular();
                    LSP.Solucao.CalculoArea.Calcular();

                    break;
                default: 
                    break;
            }
        }
    }
}
