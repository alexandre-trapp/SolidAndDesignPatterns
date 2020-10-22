namespace DesignPatterns.Behavorial.Observer
{
    // concrete subject
    public class PapelBovespa : Investimento
    {
        public PapelBovespa(string simbolo, decimal valor) 
            : base(simbolo, valor)
        {
        }
    }
}
