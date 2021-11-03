
using Microsoft.AspNetCore.Mvc;
using ProjetoExemplo.Api.Controllers;
using ProjetoExemplo.Business.Interfaces;

namespace ProjetoExemplo.Api.V1.Controllers
{

    [Route("api/[controller]")]    
    public class ClienteController : MainController
    {        
        public ClienteController(INotificador notificador) 
            : base(notificador)
        {
        }
    }
}