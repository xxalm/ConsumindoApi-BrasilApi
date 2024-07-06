using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace IntegracaoBrasilApi.Controller {

    [ApiController]
    [Route("api/v1/[controller]")]
    public class EnderecoController : ControllerBase {

        public readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpGet("busca/{cep}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> BuscarEndereco([FromRoute] string cep){
            
            var response = await _enderecoService.BuscarEndereco(cep);

            if (response.CodigoHttp == HttpStatusCode.OK) {
                return Ok(response.DadosRetorno);
            } else {
                return StatusCode((int) response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}