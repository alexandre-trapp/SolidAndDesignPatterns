namespace SOLID.ISP.Violacao
{
    /// <summary>
    /// Violação do ISP (Interface segregation principle - Princípio da segregação de interfaces,
    /// define que as interfaces devem ser segregadas por contexto, evitando interfaces com
    /// várias responsabilidades, forçando seus clientes a implementarem métodos que não utilizam,
    /// deixando - os vazios.
    /// </summary>
    public class CadastroCliente : ICadastro
    {
        public void EnviarEmail()
        {
            // Enviar email para o cliente
        }

        public void SalvarBanco()
        {
            // Insert na tabela Cliente
        }

        public void ValidarDados()
        {
            // Validar CPF, Email
        }
    }
}
