namespace SOLID.OCP.Solucao_Extension_Methods
{
    /// <summary>
    /// Solução do OCP (Open/Closed principle - Princípio de aberto/fechado, uma classe
    /// deve estar fechada para modificação e aberta para extensão)
    /// com Extension methods
    /// </summary>
    public static class DebitoContaPoupanca
    {
        public static string DebitarContaPoupanca(this DebitoConta debitoConta)
        {
            // Logica de negocio para debito em conta poupanca
            return debitoConta.FormatarTransacao();
        }
    }
}
