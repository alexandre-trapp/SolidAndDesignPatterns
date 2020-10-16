using DesignPatterns.Abstractfactory;
using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// produto abstrato
    /// </summary>
    public abstract class Guincho
    {
        public Porte Porte { get; set; }

        protected Guincho(Porte porte)
        {
            Porte = porte;
        }

        public abstract void Socorrer(Veiculo veiculo);
    }

    /// <summary>
    /// produto concreto
    /// </summary>
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine($"Socorrendo carro pequeno - Modelo {veiculo.Modelo}");
        }
    }

    /// <summary>
    /// produto concreto
    /// </summary>
    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine($"Socorrendo carro médio - Modelo {veiculo.Modelo}");
        }
    }

    /// <summary>
    /// produto concreto
    /// </summary>
    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine($"Socorrendo carro grande - Modelo {veiculo.Modelo}");
        }
    }

    public static class GuinchoCreator
    {
        public static Guincho Criar(Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new GuinchoPequeno(porte);
                case Porte.Medio:
                    return new GuinchoMedio(porte);
                case Porte.Grande:
                    return new GuinchoGrande(porte);
                default:
                    throw new ApplicationException("Porte do guincho desconhecido.");
            }
        }
    }
}