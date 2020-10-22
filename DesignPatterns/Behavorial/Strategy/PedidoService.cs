using DesignPatterns.Structural.Facade.Domain;

namespace DesignPatterns.Behavorial.Strategy
{
    public class PedidoService
    {
        private readonly IPagamento _pagamento;

        public PedidoService(IPagamento pagamento) => 
            _pagamento = pagamento;

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento) =>
            _pagamento.RealizarPagamento(pedido, pagamento);
    }
}
