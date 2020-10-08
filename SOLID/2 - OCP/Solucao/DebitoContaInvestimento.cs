namespace SOLID.OCP.Solucao
{
    /// <summary>
    /// Solução do OCP (Open/Closed principle - Princípio de aberto/fechado, uma classe
    /// deve estar fechada para modificação e aberta para extensão)
    /// </summary>
    public class DebitoContaInvestimento : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Debita da conta investimento
            // Isentar as taxas
            return FormatarTransacao();
        }
    }
}
