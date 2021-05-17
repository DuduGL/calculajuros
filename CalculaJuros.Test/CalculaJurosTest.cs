using CalculaJuros.Model;
using CalculaJuros.Services.Implementations;
using CalculaJuros.Services.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Xunit;

namespace CalculaJuros.Test
{
    [TestClass]
    public class CalculaJurosTest
    {
        public readonly ICalculaJurosService calculaJurosService;

        public CalculaJurosTest()
        {
            ExternalAPIUrls externalAPIUrls = new ExternalAPIUrls()
            {
                TaxaJurosAPIUrl = "https://localhost:5001"
            };
            IOptions<ExternalAPIUrls> externalAPIUrlsOptions = Options.Create(externalAPIUrls);
            calculaJurosService = new CalculaJurosService(externalAPIUrlsOptions);
        }

        [Theory]
        [InlineData(10, 3, 10.3)]
        [InlineData(20, 4, 20.81)]
        [InlineData(50, 5, 52.55)]
        [InlineData(100, 6, 106.15)]
        public async Task Valor_Passado_Deve_Retornar_Juros_Corretos(decimal valor, int meses, decimal juros)
        {
            //act
            decimal retornoJuros = await calculaJurosService.CalculaJuros(valor, meses);

            //assert
            Assert.AreEqual(retornoJuros, juros);
        }
    }
}
