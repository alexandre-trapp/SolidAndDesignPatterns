namespace DesignPatterns.Structural.Facade.CrossCutting
{
    public interface IPayPalGateway
    {
        bool CommitTransaction(string cardHashKey, string orderId, decimal amount);
        string GetCardHashKey(string serviceKey, string creditCard);
        string GetPayPalServiceKey(string apiKey, string encriptionKey);
    }
}
