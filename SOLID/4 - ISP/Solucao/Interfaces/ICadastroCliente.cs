﻿namespace SOLID.ISP.Solucao
{
    /// <summary>
    /// Solução do ISP (Interface segregation principle - Princípio da segregação de interfaces,
    /// define que as interfaces devem ser segregadas por contexto, evitando interfaces com
    /// várias responsabilidades, forçando seus clientes a implementarem métodos que não utilizam,
    /// deixando - os vazios.
    /// </summary>
    public interface ICadastroCliente : ICadastro
    {
        void ValidarDados();
        void EnviarEmail();
    }
}
