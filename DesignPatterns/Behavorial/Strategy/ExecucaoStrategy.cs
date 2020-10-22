using System;
using System.Collections.Generic;
using DesignPatterns.Structural.Facade.Domain;
using DesignPatterns.Structural.Facade.CrossCutting;

namespace DesignPatterns.Behavorial.Strategy
{
    public static class ExecucaoStrategy
    {
        public static void Executar()
        {
            //forma simples

            var produtos = new List<Produto>
            {
                new Produto { Nome = "Tenis adidas", Valor = new Random().Next(500)},
                new Produto { Nome = "Camisa avengers", Valor = new Random().Next(500)},
                new Produto { Nome = "Raquete tênis", Valor = new Random().Next(500)},
            };

            var pedido = new Pedido
            {
                Id = Guid.NewGuid(),
                Produtos = produtos
            };

            var meioPagamentoCredito = new Pagamento
            {
                CartaoCredito = "1111 2222 3333 4444",
                MeioPagamento = MeioPagamento.CartaoCredito
            };

            var meioPagamentoBoleto = new Pagamento
            {
                MeioPagamento = MeioPagamento.Boleto
            };

            var meioPagamentoTransferencia = new Pagamento
            {
                MeioPagamento = MeioPagamento.Transferencia
            };

            var pedidoCredito = new PedidoService(
                                    new PagamentoCartaoCreditoService(
                                        new PagamentoCartaoCreditoFacade(
                                            new PayPalGateway(),
                                            new ConfigurationManager())));

            var pagamentoCredito = pedidoCredito.RealizarPagamento(pedido, meioPagamentoCredito);
            Console.WriteLine(pagamentoCredito.Status);

            Console.WriteLine("--------------------------------------------------------------");

            var pedidoBoleto = new PedidoService(
                                    new PagamentoBoletoService(
                                        new PagamentoBoletoFacade()));

            var pagamentoBoleto = pedidoBoleto.RealizarPagamento(pedido, meioPagamentoBoleto);
            Console.WriteLine(pagamentoBoleto.Status);

            Console.WriteLine("--------------------------------------------------------------");

            var pedidoTransferencia = new PedidoService(
                                    new PagamentoTransferenciaService(
                                        new PagamentoTransferenciaFacade()));

            var pagamentoTransferencia = pedidoTransferencia.RealizarPagamento(pedido, meioPagamentoTransferencia);
            Console.WriteLine(pagamentoTransferencia.Status);

            Console.WriteLine("--------------------------------------------------------------");

            //forma mais rebuscada
            var pedidoCredito2 = new PedidoService(PagamentoFactory.CreatePagamento(meioPagamentoCredito.MeioPagamento));
            var pagamentoCredito2 = pedidoCredito2.RealizarPagamento(pedido, meioPagamentoCredito);
            Console.WriteLine(pagamentoCredito2.Status);

            Console.WriteLine("--------------------------------------------------------------");

            var pedidoBoleto2 = new PedidoService(PagamentoFactory.CreatePagamento(meioPagamentoBoleto.MeioPagamento));
            var pagamentoBoleto2 = pedidoBoleto2.RealizarPagamento(pedido, meioPagamentoBoleto);
            Console.WriteLine(pagamentoBoleto2.Status);

            Console.WriteLine("--------------------------------------------------------------");

            var pedidoTransferencia2 = new PedidoService(PagamentoFactory.CreatePagamento(meioPagamentoTransferencia.MeioPagamento));
            var pagamentoTransferencia2 = pedidoTransferencia2.RealizarPagamento(pedido, meioPagamentoTransferencia);
            Console.WriteLine(pagamentoTransferencia2.Status);

            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}
