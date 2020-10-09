namespace SOLID.LSP.Violacao
{
    /// <summary>
    /// Violação do LSP (Liskov Substitution principle - Princípio da substituição de Liskov
    /// verifica, na herança, se uma subclasse pode ser substituída pela sua superClasse,
    /// sem ter problemas de abstração, herança nessa substituição.
    /// </summary>
    public class Retangulo
    {
        public virtual double Altura { get; set; }
        public virtual double Largura { get; set; }
        public double Area { get { return Altura * Largura; } }
    }
}
