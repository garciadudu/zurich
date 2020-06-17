using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Seguros.Zurich.Site.Infraestrutura.Services.Seguro;
using Seguros.Zurich.Site.Models;

namespace Seguros.Zurich.Site.Controllers
{
    public class SeguroController : Controller
    {
        private readonly ISeguroService _seguroService;
        private readonly ILogger<SeguroController> _logger;

        public SeguroController(ISeguroService seguroService, ILogger<SeguroController> logger)
        {
            _seguroService = seguroService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Media()
        {
            return View();
        }


        public async Task<IActionResult> Listar()
        {
            return Json(await _seguroService.ListarAsync());
        }

        public async Task<IActionResult> ObterId(int id)
        {
            return Json(await _seguroService.ObterAsync(id));
        }


        public async Task Cadastrar([FromBody] SeguroViewModel seguro)
        {
            await _seguroService.CadastrarAsync(seguro);
        }

        [HttpPut]
        public async Task Atualizar([FromBody] SeguroViewModel seguro)
        {
            await _seguroService.AtualizarAsync(seguro);
        }

        public async Task Remover(int id)
        {
            await _seguroService.ExcluirAsync(id);
        }

    }
}