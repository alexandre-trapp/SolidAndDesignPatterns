using System;

namespace SOLID.SRP.Solucao
{
    /// <summary>
    /// Solução do SRP (Single responsability principle - Princípio da responsabilidade única)
    /// </summary>
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Cpf Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Validar()
        {
            return Email.Validar() && Cpf.Validar();
        }
    }
}
