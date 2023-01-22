using Microsoft.AspNetCore.Mvc;

namespace InjecaoDependenciaTeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperacaoController : ControllerBase
    {
        private readonly IOperacaoTransient _transient;
        private readonly IOperacaoScoped _scoped;
        private readonly IOperacaoSingleton _singleton;
        public OperacaoController(
            IOperacaoTransient transient,
            IOperacaoScoped scoped,
            IOperacaoSingleton singleton)
        {
            _transient = transient;
            _scoped = scoped;
            _singleton = singleton;
        }

        [HttpGet("InjecaoViaConstrutor")]
        public IActionResult Construtor(
            [FromServices] IOperacaoTransient transiente,
            [FromServices] IOperacaoScoped scoped,
            [FromServices] IOperacaoSingleton singleton)
        {
            return Ok(new
            {
                Transient1 = _transient.Id,
                Transient2 = transiente.Id,
                Scoped1 = _scoped.Id,
                Scoped2 = scoped.Id,
                Singleton1 = _singleton.Id,
                Singleton2 = singleton.Id
            });
        }
    }
}