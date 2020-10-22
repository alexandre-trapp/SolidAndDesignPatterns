using System;
using DesignPatterns.Structural.Facade.Domain;
using DesignPatterns.Structural.Facade.CrossCutting;

namespace DesignPatterns.Behavorial.Strategy
{
    public static class PagamentoFactory
    {
        public static IPagamento CreatePagamento(MeioPagamento meioPagamento)
        {
            switch (meioPagamento)
            {
                case MeioPagamento.CartaoCredito:
                    return new PagamentoCartaoCreditoService(
                                new PagamentoCartaoCreditoFacade(
                                    new PayPalGateway(),
                                    new ConfigurationManager()));

                case MeioPagamento.Boleto:
                    return new PagamentoBoletoService(new PagamentoBoletoFacade());

                case MeioPagamento.Transferencia:
                    return new PagamentoTransferenciaService(new PagamentoTransferenciaFacade());

                default:
                    throw new ApplicationException("Meio de pagamento não conhecido");
            }
        }
    }
}
