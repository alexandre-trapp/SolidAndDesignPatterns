using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite
{
    public class Mensagem : IMessage, IEnumerable<IMessage>
    {
        public string _message { get; set; }
        private readonly List<IMessage> _lista = new List<IMessage>();

        public Mensagem(string message)
        {
            _message = message;
        }

        public void AdicionarFilha(IMessage mensagemFilha)
        {
            _lista.Add(mensagemFilha);
        }

        public void RemoverFilha(IMessage mensagemFilha)
        {
            _lista.Remove(mensagemFilha);
        }

        public IMessage ObterFilha(int index)
        {
            return _lista[index];
        }

        public IMessage ObterFilha(string message)
        {
            return _lista.First(m => m._message == message);
        }

        public IEnumerator<IMessage> GetEnumerator()
        {
            return ((IEnumerable<IMessage>)_lista).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<IMessage>)_lista).GetEnumerator();
        }

        public void ExibirMensagens(int nivelMensagem)
        {
            Console.WriteLine(new string('-', nivelMensagem) + _message);

            foreach (var mensagem in _lista)
                mensagem.ExibirMensagens(nivelMensagem + 2);
        }
    }
}