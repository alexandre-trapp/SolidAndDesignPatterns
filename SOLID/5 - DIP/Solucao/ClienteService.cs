using SOLID.DIP.Solucao.Interfaces;

namespace SOLID.DIP.Solucao
{
    /// <summary>
    /// Solução do DIP (Dependency inversion principle - Princípio da inversão de dependência)
    /// onde módulos de alto nível não devem depender de módulos de baixo nível
    /// </summary>
    public class ClienteService : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;

        public ClienteService(IEmailServices emailServices,
            IClienteRepository clienteRepository)
        {
            _emailServices = emailServices;
            _clienteRepository = clienteRepository;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados do cliente inválidos";

            // Solução, dependendo da interface (abstração) do repositório (baixo nível), 
            // se a implementação do repositório mudar, a classe clienteService não muda
            _clienteRepository.AdicionarCliente(cliente);

            // solu~çao, dependendo da interface(abstração) do serviços de email (baixo nível), 
            // se a implementação de emailService mudar, a classe clienteService não muda.
            _emailServices.Enviar("trapp@trapp.com", cliente.Email.Endereco, "Bem vindo", "Bem vindo ao treinamento de SOLID do trapp");

            return "Cliente cadastrado com sucesso.";
        }
    }

    public class TesteDipInjecaoDependencia
    {
        public TesteDipInjecaoDependencia()
        {
            var clienteService = new ClienteService(new EmailServices(), new ClienteRepository());
        }
    }
}
