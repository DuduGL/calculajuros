using CalculaJuros.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaJuros.Services.Implementations
{
    public class ShowCodeService : IShowCodeService
    {
        public string ShowMeTheCode()
        {
            return codeUrl;
        }

        private string codeUrl => "https://github.com/DuduGL?tab=repositories";
    }
}
