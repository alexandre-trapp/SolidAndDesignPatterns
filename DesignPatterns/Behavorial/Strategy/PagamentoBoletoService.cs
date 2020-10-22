using System;
using System.Linq;
using DesignPatterns.Structural.Facade.Domain;

namespace DesignPatterns.Behavorial.Strategy
{
    public class PagamentoBoletoService : IPagamento
    {
        private readonly IPagamentoBoletoFacade _pagamentoBoletoFacade;

        public PagamentoBoletoService(IPagamentoBoletoFacade pagamentoBoletoFacade) => 
            _pagamentoBoletoFacade = pagamentoBoletoFacade;

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);
            Console.WriteLine("Iniciando pagamento via boleto - Valor R$ " + pagamento.Valor);

            _pagamentoBoletoFacade.RealizarPagamento(pedido, pagamento);

            pagamento.Status = "Pago via boleto";
            return pagamento;
        }
    }
}
