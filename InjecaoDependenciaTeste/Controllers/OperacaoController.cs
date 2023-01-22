using Microsoft.AspNetCore.Mvc;

namespace InjecaoDependenciaTeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperacaoController : ControllerBase
    {
        private readonly IServiceProvider _provider;
        public OperacaoController(IServiceProvider provider)
        {
            _provider = provider;
        }

        //[HttpGet("InjecaoViaAnotacao")]
        //public IActionResult Anotacao([FromServices] IOperacao operacao)
        //{
        //    return Ok(operacao.Id);
        //}

        [HttpGet("InjecaoViaProvider")]
        public IActionResult Provider()
        {
            return Ok(_provider.GetRequiredService<IOperacao>());
        }
    }
}