namespace DesignPatterns.Structural.Composite
{
    public interface IMessage
    {
        string _message { get; set; }
        void ExibirMensagens(int nivelMensagem);
    }
}
