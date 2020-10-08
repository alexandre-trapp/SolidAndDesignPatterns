namespace SOLID.OCP.Solucao_Extension_Methods
{
    /// <summary>
    /// Solução do OCP (Open/Closed principle - Princípio de aberto/fechado, uma classe
    /// deve estar fechada para modificação e aberta para extensão)
    /// com Extension methods
    /// </summary>
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            // Logica de negocio para debito em conta investimento
            return debitoConta.FormatarTransacao();
        }
    }
}
