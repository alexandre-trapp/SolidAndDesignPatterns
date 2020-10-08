using System;

namespace SOLID.SRP.Solucao
{
    /// <summary>
    /// Solução do SRP (Single responsability principle - Princípio da responsabilidade única)
    /// </summary>
    public class Email
    {
        public string Endereco { get; set; }

        public bool Validar()
        {
            return Endereco.Contains("@");
        }
    }
}