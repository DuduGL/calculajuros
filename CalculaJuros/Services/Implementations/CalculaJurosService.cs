using CalculaJuros.Model;
using CalculaJuros.Services.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculaJuros.Services.Implementations
{
    public class CalculaJurosService : ICalculaJurosService
    {
        private readonly ExternalAPIUrls externalAPIUrls;
        static readonly HttpClient client = new HttpClient();

        public CalculaJurosService(IOptions<ExternalAPIUrls> ExternalAPIUrlsAccessor)
        {
            externalAPIUrls = ExternalAPIUrlsAccessor.Value;
        }

        public async Task<decimal> CalculaJuros(decimal valor, int mes)
        {
            decimal taxa = await ConsultaJuros();
            double calcTaxa = (double)valor * Math.Pow((double)(1 + taxa), mes);
            decimal valorTotal = decimal.Round((decimal)calcTaxa, 2);
            return Convert.ToDecimal(valorTotal);
        }

        private async Task<decimal> ConsultaJuros()
        {
            HttpResponseMessage response = await client.GetAsync($"{externalAPIUrls.TaxaJurosAPIUrl}/taxaJuros");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return Convert.ToDecimal(responseBody);
        }
    }
}
