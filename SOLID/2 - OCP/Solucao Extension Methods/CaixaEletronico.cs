using System;

namespace SOLID.OCP.Solucao_Extension_Methods
{
    public static class CaixaEletronico
    {
        public static void Operacoes()
        {
            MenuOperacoes();

            var opcao = Console.ReadKey();
            var retorno = string.Empty;

            var debitoConta = DadosDebito();

            switch (opcao.KeyChar)
            {
                case '1':
                    Console.WriteLine("Efetuando operação em conta corrente");
                    retorno = debitoConta.DebitarContaCorrente();
                    break;

                case '2':
                    Console.WriteLine("Efetuando operação em conta poupança");
                    retorno = debitoConta.DebitarContaPoupanca();
                    break;

                case '3':
                    Console.WriteLine("Efetuando operação em conta investimento");
                    retorno = debitoConta.DebitarContaInvestimento();
                    break;
            }

            RetornoTransacao(retorno);
        }

        private static void MenuOperacoes()
        {
            Console.Clear();

            Console.WriteLine("Caixa Eletrônico - SOLIC OCP com extensions methods");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine();
            Console.WriteLine("1 - Saque conta corrente");
            Console.WriteLine("2 - Saque conta poupança");
            Console.WriteLine("3 - Saque conta investimento");
        }

        private static DebitoConta DadosDebito()
        {
            Console.WriteLine();
            Console.WriteLine(".................................");
            Console.WriteLine();
            
            Console.WriteLine("Digite o número da conta");
            var conta = Console.ReadLine();

            Console.WriteLine("Digite o valor do saque");
            var valor = Convert.ToDecimal(Console.ReadLine());

            var debitoConta = new DebitoConta()
            {
                NumeroConta = conta,
                Valor = valor
            };

            return debitoConta;
        }

        private static void RetornoTransacao(string retorno)
        {
            Console.WriteLine();
            Console.WriteLine("Sucesso! Transação: " + retorno);
            Console.ReadKey();
        }
    }
}
