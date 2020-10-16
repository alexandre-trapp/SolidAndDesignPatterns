using System;

namespace DesignPatterns.Abstractfactory
{
    /// <summary>
    /// produto abstrato
    /// </summary>
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public Porte Porte { get; set; }

        protected Veiculo(string modelo, Porte porte)
        {
            Modelo = modelo;
            Porte = porte;
        }
    }

    /// <summary>
    /// produto concreto
    /// </summary>
    public class VeiculoPequeno : Veiculo
    {
        public VeiculoPequeno(string modelo, Porte porte) : base(modelo, porte) { }
    }

    /// <summary>
    /// produto concreto
    /// </summary>
    public class VeiculoMedio: Veiculo
    {
        public VeiculoMedio(string modelo, Porte porte) : base(modelo, porte) { }
    }

    /// <summary>
    /// produto concreto
    /// </summary>
    public class VeiculoGrande : Veiculo
    {
        public VeiculoGrande(string modelo, Porte porte) : base(modelo, porte) { }
    }

    public static class VeiculoCreator
    {
        public static Veiculo Criar(string modelo, Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new VeiculoPequeno(modelo, porte);
                case Porte.Medio:
                    return new VeiculoMedio(modelo, porte);
                case Porte.Grande:
                    return new VeiculoGrande(modelo, porte);
                default:
                    throw new ApplicationException("Porte do veículo desconhecido.");
            }
        }
    }
}