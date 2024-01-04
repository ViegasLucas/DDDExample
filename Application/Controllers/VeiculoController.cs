using Domain.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    public class VeiculoController : ControllerBase
    {
        [HttpPost("CadastrarVeiculo")]
        public IActionResult PostAsync([FromBody] VeiculoCommand command)
        {
            return Ok();
        }

        public IActionResult Simularaluguel()
        {
            return Ok();
        }
        public IActionResult alugarVeiculo()
        {
            return Ok();
        }
    }
}
