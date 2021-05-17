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
    public class ShowCodeController : ControllerBase
    {
        public readonly IShowCodeService showCodeService;

        public ShowCodeController(IShowCodeService _showCodeService)
        {
            showCodeService = _showCodeService;
        }

        [HttpGet]
        [Route("showmethecode")]
        public string ShowMeTheCode()
        {
            return showCodeService.ShowMeTheCode();
        }
    }
}
