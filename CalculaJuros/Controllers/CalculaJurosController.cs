using CalculaJuros.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaJuros.Controllers
{
    [ApiController]
    [Route("")]
    public class CalculaJurosController : ControllerBase
    {
        public readonly ICalculaJurosService calculaJurosService;

        public CalculaJurosController(ICalculaJurosService _calculaJurosService)
        {
            calculaJurosService = _calculaJurosService;
        }

        [HttpGet]
        [Route("calculaJuros")]
        public async Task<decimal> CalcularJuros(decimal valor, int meses)
        {
            return await calculaJurosService.CalculaJuros(valor, meses);
        }
    }
}
