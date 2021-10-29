using System.Collections.Generic;
using ProjetoExemplo.Business.Notifications;

namespace ProjetoExemplo.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        void AdicionarNotificacao(Notificacao notificacao);
        List<Notificacao> ObterNotificacoes();
    }
}