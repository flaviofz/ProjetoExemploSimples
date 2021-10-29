using Microsoft.AspNetCore.Mvc;

namespace ProjetoExemplo.Api.Controllers
{
    public abstract class MainController : ControllerBase
    {
        protected ActionResult CustomResponse(object result = null)
        {
            return Ok(
                new
                {
                    success = true,
                    data = result
                }
            );

            // return BadRequest(
            //     new
            //     {
            //         success = false,
            //         erros = Lista
            //     }
            // );
        }
    }
}