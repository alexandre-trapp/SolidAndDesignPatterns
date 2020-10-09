using System;

namespace SOLID.ISP.Violacao
{
    /// <summary>
    /// Violação do ISP (Interface segregation principle - Princípio da segregação de interfaces,
    /// define que as interfaces devem ser segregadas por contexto, evitando interfaces com
    /// várias responsabilidades, forçando seus clientes a implementarem métodos que não utilizam,
    /// deixando - os vazios.
    /// </summary>
    public class CadastroProduto : ICadastro
    {
        public void EnviarEmail()
        {
            // produto não tem email, o que fazer agora?
            throw new NotImplementedException("produto não envia email, método não será implementado devido interface genérica");
        }

        public void SalvarBanco()
        {
            // insert na tabela de produto
        }

        public void ValidarDados()
        {
            // validar valor
        }
    }
}
