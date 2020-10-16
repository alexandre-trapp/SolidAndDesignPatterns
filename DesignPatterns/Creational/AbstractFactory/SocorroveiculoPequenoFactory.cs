using DesignPatterns.Abstractfactory;

namespace DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// Concrete factory
    /// </summary>
    public class SocorroveiculoPequenoFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoCreator.Criar(Porte.Pequeno);
        }

        public override Veiculo Criarveiculo(string modelo, Porte porte)
        {
            return VeiculoCreator.Criar(modelo, porte);
        }
    }
}
