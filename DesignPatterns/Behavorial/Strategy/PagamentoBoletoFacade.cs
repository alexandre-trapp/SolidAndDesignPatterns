using System;
using System.Linq;
using DesignPatterns.Structural.Facade.Domain;

namespace DesignPatterns.Behavorial.Strategy
{
    public class PagamentoBoletoFacade : IPagamentoBoletoFacade
    {
        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);

            Console.WriteLine($"Iniciando pagamento via boleto - Valor R$ {pagamento.Valor}");

            pagamento.Status = "Pago via boleto";
            return pagamento;
        }
    }
}
