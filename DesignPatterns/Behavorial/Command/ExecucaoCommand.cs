using System;

namespace DesignPatterns.Behavorial.Command
{
    public class ExecucaoCommand
    {
        public static void Executar()
        {
            var user = new Usuario();

            user.Adicionar(operador: '+', valor: 100);
            Console.ReadKey();

            user.Adicionar(operador: '+', valor: 50);
            Console.ReadKey();

            user.Adicionar(operador: '+', valor: 10);
            Console.ReadKey();

            user.Adicionar(operador: '+', valor: 2);
            Console.ReadKey();

            user.Desfazer(niveis: 4);
            Console.ReadKey();

            user.Retornar(niveis: 3);
        }
    }
}
