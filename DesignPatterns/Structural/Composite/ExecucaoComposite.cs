namespace DesignPatterns.Structural.Composite
{
    public static class ExecucaoComposite
    {
        public static void Executar()
        {
            var validacaoCadastro = new Mensagem("O cadastro não foi realizado!");

            var usuarioFormErro = new Mensagem("O usuário informou um nome inválido");

            var tamanhoNomeForm = new InputFormMessage("O nome precisa possuir mais de 2 caracteres");
            var nomeEmBrancoOuVazioForm = new InputFormMessage("O nome não pode estar em branco ou possuir números");

            usuarioFormErro.AdicionarFilha(tamanhoNomeForm);
            usuarioFormErro.AdicionarFilha(nomeEmBrancoOuVazioForm);

            validacaoCadastro.AdicionarFilha(usuarioFormErro);

            var domainUsuarioErro = new Mensagem("Problemas ao processar o cadastro do usuário");

            var cpfUsuarioDomain = new DomainMessage("O CPF informado está em uso por outra pessoa!");
            var emailUsuarioDomain = new DomainMessage("O e-mail informado está em uso por outro usuário!");

            domainUsuarioErro.AdicionarFilha(cpfUsuarioDomain);
            domainUsuarioErro.AdicionarFilha(emailUsuarioDomain);

            validacaoCadastro.AdicionarFilha(domainUsuarioErro);

            var msgNivel1 = new Mensagem("Nível 1");
            var msgNivel2 = new Mensagem("Nível 2");
            var msgNivel3 = new Mensagem("Nível 3");
            var msgNivel4 = new Mensagem("Nível 4");
            var msgNivel5 = new Mensagem("Nível 5");

            msgNivel4.AdicionarFilha(msgNivel5);
            msgNivel3.AdicionarFilha(msgNivel4);
            msgNivel2.AdicionarFilha(msgNivel3);
            msgNivel1.AdicionarFilha(msgNivel2);

            validacaoCadastro.AdicionarFilha(msgNivel1);

            validacaoCadastro.ExibirMensagens(nivelMensagem: 2);
        }
    }
}
