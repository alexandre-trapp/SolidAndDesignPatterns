namespace SOLID.DIP.Violacao
{
    /// <summary>
    /// Violação do DIP (Dependency inversion principle - Princípio da inversão de dependência)
    /// onde módulos de alto nível não devem depender de módulos de baixo nível
    /// </summary>
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados do cliente inválidos";

            // violação! dependendo da implementação concreta do repositório (baixo nível), 
            // se a implementação mudar, a classe clienteService pode ter que mudar também, o que não é bom
            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            // violação! dependendo da classe concreta do serviços de email (baixo nível), 
            // se a implementação mudar, a classe clienteService pode ter que mudar também.
            EmailServices.Enviar("trapp@trapp.com", cliente.Email.Endereco, "Bem vindo", "Bem vindo ao treinamento de SOLID do trapp");

            return "Cliente cadastrado com sucesso.";
        }
    }
}
