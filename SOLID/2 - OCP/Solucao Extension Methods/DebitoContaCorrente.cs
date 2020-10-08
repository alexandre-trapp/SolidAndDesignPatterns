namespace SOLID.OCP.Solucao_Extension_Methods
{
    /// <summary>
    /// Solução do OCP (Open/Closed principle - Princípio de aberto/fechado, uma classe
    /// deve estar fechada para modificação e aberta para extensão)
    /// com Extension methods
    /// </summary>
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            // Logica de negocio para debito em conta corrente
            return debitoConta.FormatarTransacao();
        }
    }
}
