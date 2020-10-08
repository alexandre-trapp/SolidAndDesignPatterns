namespace SOLID.OCP.Violacao
{
    /// <summary>
    /// Violação do OCP (Open/Closed principle - Princípio de aberto/fechado, uma classe
    /// deve estar fechada para modificação e aberta para extensão)
    /// </summary>
    public class DebitoConta
    {
        /// <summary>
        /// Esta classe viola o OCP, pois cada novo tipo de 
        /// conta que surgir, é adicionado no Enum TipoConta
        /// e adicionado um novo if na classe, então ela está sendo
        /// "modificada" ao invés de estendida
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="conta"></param>
        /// <param name="tipoConta"></param>
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Corrente)
            {
                // debita conta corrente
            }

            if (tipoConta == TipoConta.Poupanca)
            {
                // Valida aniversário da conta
                // Debita conta poupança
            }
        }
    }
}
