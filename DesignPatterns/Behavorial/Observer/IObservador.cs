namespace DesignPatterns.Behavorial.Observer
{
    // Observer
    public interface IObservador
    {
        string Nome { get; }
        void Notificar(Investimento investimento);
    }
}
