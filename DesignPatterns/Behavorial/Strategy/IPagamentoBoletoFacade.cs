using DesignPatterns.Structural.Facade.Domain;

namespace DesignPatterns.Behavorial.Strategy
{
    public interface IPagamentoBoletoFacade
    {
        Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
