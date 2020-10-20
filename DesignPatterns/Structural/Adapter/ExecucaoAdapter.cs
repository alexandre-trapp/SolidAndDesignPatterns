using DesignPatterns.Structural.Adapter;

namespace DesignPatterns.Adapter
{
    public class ExecucaoAdapter
    {
        public static void Executar()
        {
            var pagamentoPadrao = new TransacaoService(new Logger());
            pagamentoPadrao.RealizarTransacao();

            var pagamentoLogCustom = new TransacaoService(new LogAdapter(new LogNetMasterService()));
            pagamentoLogCustom.RealizarTransacao();
        }
    }
}