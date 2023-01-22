using Microsoft.AspNetCore.Mvc;

namespace InjecaoDependenciaTeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperacaoController : ControllerBase
    {
        private readonly IOperacao _operacao;
        public OperacaoController(IOperacao operacao)
        {
            _operacao = operacao;
        }

        [HttpGet("InjecaoViaConstrutor")]
        public IActionResult Construtor()
        {
            return Ok(_operacao.Id);
        }
    }
}