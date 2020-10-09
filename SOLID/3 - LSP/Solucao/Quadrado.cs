using System;

namespace SOLID.LSP.Solucao
{
    /// <summary>
    /// Solução do LSP (Liskov Substitution principle - Princípio da substituição de Liskov
    /// verifica, na herança, se uma subclasse pode ser substituída pela sua superClasse,
    /// sem ter problemas de abstração, herança nessa substituição.
    /// </summary>
    public class Quadrado : Paralelogramo
    {
        public Quadrado(int altura, int largura)
            : base(altura, largura)
        {
            if (largura != altura)
                throw new ArgumentException("A altura e largura do quadrado precisam ser iguais.");
        }
    }
}
