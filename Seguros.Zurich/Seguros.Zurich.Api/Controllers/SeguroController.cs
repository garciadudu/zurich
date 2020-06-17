using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Seguros.Zurich.Aplicacao.Interfaces;
using Seguros.Zurich.AplicacaoDTO.DTO;

namespace Seguros.Zurich.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeguroController : ControllerBase
    {
        private readonly IApplicationServiceSeguro _applicationServiceSeguro;
        private readonly ILogger<SeguroController> _logger;

        public SeguroController(IApplicationServiceSeguro applicationServiceSeguro, ILogger<SeguroController> logger)
        {
            _applicationServiceSeguro = applicationServiceSeguro ?? throw new ArgumentNullException(nameof(applicationServiceSeguro));
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<SeguroDTO>> Get()
        {
            return await _applicationServiceSeguro.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<SeguroDTO> Get(int id)
        {
            return await _applicationServiceSeguro.GetByIdAsync(id);
        }

        [HttpGet]
        [Route("~/api/seguro/cpf")]
        public async Task<SeguroDTO> Get(string cpf)
        {
            return await _applicationServiceSeguro.GetByCPFAsync(cpf);
        }


        [HttpPost]
        [ProducesResponseType(typeof(SeguroDTO), StatusCodes.Status200OK)]
        public IActionResult Post([FromBody] SeguroDTO Seguro)
        {
            try
            {
                if (Seguro == null)
                    return NotFound();

                _applicationServiceSeguro.Add(Seguro);
                return Ok("Seguro cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Put(int id, [FromBody] SeguroDTO Seguro)
        {
            try
            {
                if (Seguro == null)
                    return NotFound();

                _applicationServiceSeguro.Update(Seguro);

                return Ok("Seguro atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpDelete()]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var seguro = await _applicationServiceSeguro.GetByIdAsync(id);
                if (seguro is null)
                    return NotFound();


                seguro = new SeguroDTO
                {
                    Id = id
                };

                _applicationServiceSeguro.Remove(seguro);
                return Ok("Seguro removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}