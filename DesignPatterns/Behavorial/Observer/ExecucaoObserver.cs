using System;

namespace DesignPatterns.Behavorial.Observer
{
    public static class ExecucaoObserver
    {
        public static void Executar()
        {
            var joao = new Observador("João");
            var alexandre = new Observador("Alexandre");
            var papa = new Observador("papa");

            var amazon = new PapelBovespa("Amazon", NextDecimal());
            var disney = new PapelBovespa("Disney", NextDecimal());

            amazon.Subscribe(joao);
            amazon.Subscribe(alexandre);

            disney.Subscribe(alexandre);
            disney.Subscribe(papa);

            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                amazon.Valor = NextDecimal();
                disney.Valor = NextDecimal();
            }
        }

        private static decimal NextDecimal()
        {
            var random = new Random();
            var r = random.Next(141421, 314160);

            return r / (decimal)100000.00;
        }
    }
}
