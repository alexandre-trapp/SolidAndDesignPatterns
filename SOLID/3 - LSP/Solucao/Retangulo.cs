namespace SOLID.LSP.Solucao
{
    /// <summary>
    /// Solução do LSP (Liskov Substitution principle - Princípio da substituição de Liskov
    /// verifica, na herança, se uma subclasse pode ser substituída pela sua superClasse,
    /// sem ter problemas de abstração, herança nessa substituição.
    /// </summary>
    public class Retangulo : Paralelogramo
    {
        public Retangulo(int altura, int largura) 
            : base(altura, largura)
        {

        }
    }
}
