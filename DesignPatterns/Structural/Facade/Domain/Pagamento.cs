namespace DesignPatterns.Structural.Facade.Domain
{
    public class Pagamento
    {
        public decimal Valor { get; set; }
        public string Status { get; set; }
        public MeioPagamento MeioPagamento { get; set; }
        public string CartaoCredito { get; set; }
        public string Boleto { get; set; }
        public string TransferenciaBancaria { get; set; }

    }
}