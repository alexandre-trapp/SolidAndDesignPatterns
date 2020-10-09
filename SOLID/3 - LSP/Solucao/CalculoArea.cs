using System;

namespace SOLID.LSP.Solucao
{
    /// <summary>
    /// Solução do LSP (Liskov Substitution principle - Princípio da substituição de Liskov
    /// verifica, na herança, se uma subclasse pode ser substituída pela sua superClasse,
    /// sem ter problemas de abstração, herança nessa substituição.
    /// </summary>
    public static class CalculoArea
    {
        public static void Calcular()
        {
            var quadrado = new Quadrado(altura: 10, largura: 10);
            var ret = new Retangulo(altura: 10, largura: 5);

            ObterAreaParalelogramo(quadrado);
            ObterAreaParalelogramo(ret);
        }

        private static void ObterAreaParalelogramo(Paralelogramo paralelogramo)
        {
            Console.Clear();
            Console.WriteLine("Solução");
            Console.WriteLine();
            Console.WriteLine($"Calculo da área do paralelogramo - {(paralelogramo is Quadrado ? "quadrado" : "retangulo")}");
            Console.WriteLine();
            Console.WriteLine(paralelogramo.Altura + " * " + paralelogramo.Largura);
            Console.WriteLine();
            Console.WriteLine(paralelogramo.Area);
            Console.ReadKey();
        }
    }
}
