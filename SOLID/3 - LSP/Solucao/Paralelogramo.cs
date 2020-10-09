namespace SOLID.LSP.Solucao
{
    /// <summary>
    /// Solução do LSP (Liskov Substitution principle - Princípio da substituição de Liskov
    /// verifica, na herança, se uma subclasse pode ser substituída pela sua superClasse,
    /// sem ter problemas de abstração, herança nessa substituição.
    /// </summary>
    public abstract class Paralelogramo
    {
        protected Paralelogramo(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double Altura { get; private set; }
        public double Largura { get; private set; }
        public double Area { get { return Altura * Largura; } }
    }
}
