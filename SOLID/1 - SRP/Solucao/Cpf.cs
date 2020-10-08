using System;

namespace SOLID.SRP.Solucao
{
    /// <summary>
    /// Solução do SRP (Single responsability principle - Princípio da responsabilidade única)
    /// </summary>
    public class Cpf
    {
        public string Numero { get; set; }

        public bool Validar()
        {
            return Numero.Length == 11;
        }
    }
}