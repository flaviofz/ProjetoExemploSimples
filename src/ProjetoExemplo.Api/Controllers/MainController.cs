using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjetoExemplo.Business.Interfaces;

namespace ProjetoExemplo.Api.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        private readonly INotificador _notificador;

        protected MainController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected bool OperacaoValida()
        {
            return !_notificador.TemNotificacao();
        }

        protected ActionResult CustomResponse(object result = null)
        {
            if (OperacaoValida())
            {
                return Ok(
                    new
                    {
                        success = true,
                        data = result
                    }
                );
            }

            return BadRequest(
                new
                {
                    success = false,
                    erros = _notificador.ObterNotificacoes().Select(n => n.Mensagem)
                }
            );
        }
    }
}