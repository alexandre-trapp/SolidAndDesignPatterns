using DesignPatterns.Creational.AbstractFactory;
using System.Collections.Generic;

namespace DesignPatterns.Abstractfactory
{
    public class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            var veiculosSocorro = new List<Veiculo>
            {
                VeiculoCreator.Criar("Fox", Porte.Pequeno),
                VeiculoCreator.Criar("Jetta", Porte.Medio),
                VeiculoCreator.Criar("BMX X6", Porte.Grande),
            };

            veiculosSocorro.ForEach(veiculo => AutoSocorro.CriarAutoSocorro(veiculo).RealizarAtendimento());
        }
    }
}