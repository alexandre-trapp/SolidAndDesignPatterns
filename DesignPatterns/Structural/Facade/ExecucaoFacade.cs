using System;
using System.Collections.Generic;
using DesignPatterns.Structural.Facade.CrossCutting;
using DesignPatterns.Structural.Facade.Domain;

namespace DesignPatterns.Structural.Facade
{
    public class ExecucaoFacade
    {
        public static void Executar()
        {
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

            var pagamento = new Pagamento
            {
                CartaoCredito = "1111 2222 3333 4444"
            };

            // Resolva com DI
            var pagamentoService = new PagamentoCartaoCreditoService(
                                        new PagamentoCartaoCreditoFacade(
                                            new PayPalGateway(),
                                            new ConfigurationManager()));

            var pagamentoResult = pagamentoService.RealizarPagamento(pedido, pagamento);

            Console.WriteLine(pagamentoResult.Status);
        }
    }
}
