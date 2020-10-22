using System;
using System.Linq;
using DesignPatterns.Structural.Facade.Domain;

namespace DesignPatterns.Behavorial.Strategy
{
    public class PagamentoTransferenciaService : IPagamento
    {
        private readonly IPagamentoTransferenciaFacade _pagamentoTransferenciaFacade;

        public PagamentoTransferenciaService(IPagamentoTransferenciaFacade pagamentoTransferenciaFacade) => 
            _pagamentoTransferenciaFacade = pagamentoTransferenciaFacade;

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);
            Console.WriteLine("Iniciando pagamento via transferência - Valor R$ " + pagamento.Valor);

            pagamento.ConfirmacaoTransferencia = _pagamentoTransferenciaFacade.RealizarTransferencia();
            pagamento.Status = "Pago via transferência";
            return pagamento;
        }
    }
}
