using DesignPatterns.Abstractfactory;

namespace DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// Abstract factory
    /// </summary>
    public abstract class AutoSocorroFactory
    {
        public abstract Guincho CriarGuincho();
        public abstract Veiculo Criarveiculo(string modelo, Porte porte);
    }
}
