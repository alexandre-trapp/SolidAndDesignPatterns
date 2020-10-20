namespace DesignPatterns.Structural.Adapter
{
    // client
    public class TransacaoService
    {
        private readonly ILogger _logger;

        public TransacaoService(ILogger logger)
        {
            _logger = logger;
        }

        public void RealizarTransacao()
        {
            // transação
            _logger.Log("Transação realizada (log padrão)");
        }

    }
}
