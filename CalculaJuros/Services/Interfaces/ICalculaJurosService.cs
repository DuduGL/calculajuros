using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaJuros.Services.Interfaces
{
    public interface ICalculaJurosService
    {
        Task<decimal> CalculaJuros(decimal valor, int mes);
    }
}
