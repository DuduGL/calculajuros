using CalculaJuros.Services.Implementations;
using CalculaJuros.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace CalculaJuros.Test
{
    [TestClass]
    public class CalculaJurosTest
    {
        public readonly ICalculaJurosService calculaJurosService;

        public CalculaJurosTest()
        {
            calculaJurosService = new CalculaJurosService();
        }

        [Theory]
        [InlineData(10, 3, 10)]
        [InlineData(20, 4, 10)]
        [InlineData(50, 5, 10)]
        [InlineData(100, 6, 10)]
        public void Valor_Passado_Deve_Retornar_Juros_Correto(decimal valor, int meses, decimal juros)
        {
            //act


            //assert

        }
    }
}
