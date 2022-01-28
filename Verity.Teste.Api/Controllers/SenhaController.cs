using Microsoft.AspNetCore.Mvc;
using System;
using Verity.Avaliacao.Api.Services.Interface;
using Verity.Avaliacao.Model;

namespace Verity.Teste.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SenhaController : ControllerBase
    {
        private ISenhaService _senhaService;

        public SenhaController(ISenhaService senhaService)
        {
            _senhaService = senhaService;
        }

        [HttpPost()]
        public ActionResult<string> Post([FromBody] String caracteres)
        {
            try
            {
                SenhaModel senha = new SenhaModel(caracteres);
                bool response = _senhaService.ValidaSenha(senha);

                return !response ? (ActionResult)UnprocessableEntity("Senha invalida") : Ok("Senha valida");
            }
            catch (Exception exception)
            {
                return UnprocessableEntity(exception);
            }
        }
    }
}
