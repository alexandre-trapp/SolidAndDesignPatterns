using System;

namespace SOLID.LSP.Violacao
{
    /// <summary>
    /// Violação do LSP (Liskov Substitution principle - Princípio da substituição de Liskov
    /// verifica, na herança, se uma subclasse pode ser substituída pela sua superClasse,
    /// sem ter problemas de abstração, herança nessa substituição.
    /// </summary>
    public static class CalculoArea
    {
        public static void Calcular()
        {
            var quadrado = new Quadrado
            {
                Altura = 10,
                Largura = 5
            };

            ObterAreaRetangulo(quadrado);
        }

        private static void ObterAreaRetangulo(Retangulo retangulo)
        {
            Console.Clear();
            Console.WriteLine("Violação");
            Console.WriteLine();
            Console.WriteLine("Calculo da área do retângulo");
            Console.WriteLine();
            Console.WriteLine(retangulo.Altura + " * " + retangulo.Altura);
            Console.WriteLine();
            Console.WriteLine(retangulo.Area);
            Console.ReadKey();
        }
    }
}
