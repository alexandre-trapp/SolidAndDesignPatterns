namespace SOLID.SRP.Solucao
{
    /// <summary>
    /// Solução do SRP (Single responsability principle - Princípio da responsabilidade única)
    /// </summary>
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados do cliente inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailServices.Enviar("trapp@trapp.com", cliente.Email.Endereco, "Bem vindo", "Bem vindo ao treinamento de SOLID do trapp");

            return "Cliente cadastrado com sucesso.";
        }
    }
}
