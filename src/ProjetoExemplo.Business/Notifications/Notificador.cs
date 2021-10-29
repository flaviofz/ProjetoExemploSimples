using System.Collections.Generic;
using System.Linq;

namespace ProjetoExemplo.Business.Notifications
{
    public class Notificador
    {
        private List<Notificacao> _notificacoes;

        public Notificador()
        {
            _notificacoes = new List<Notificacao>();
        }

        public void AdicionarNotificacao(Notificacao notificacao) 
            => _notificacoes.Add(notificacao);

        public List<Notificacao> ObterNotificacoes()
            => _notificacoes;

        public bool TemNotificacao()
            => _notificacoes.Any();
    }
}