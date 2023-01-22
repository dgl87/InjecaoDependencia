using Microsoft.AspNetCore.Mvc;

namespace InjecaoDependenciaTeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperacaoController : ControllerBase
    {
        public OperacaoController()
        {
        }

        [HttpGet("InjecaoViaAnotacao")]
        public IActionResult Anotacao([FromServices] IOperacao operacao)
        {
            return Ok(operacao.Id);
        }
    }
}