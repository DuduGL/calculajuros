using CalculaJuros.Services.Implementations;
using CalculaJuros.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace CalculaJuros.Test
{
    [TestClass]
    public class ShowCodeTest
    {
        public readonly IShowCodeService showCodeService;

        public ShowCodeTest()
        {
            showCodeService = new ShowCodeService();
        }

        [TestMethod]
        public void ShowMeTheCode_Deve_Retornar_URL_Correta()
        {
            //act
            string code = showCodeService.ShowMeTheCode();

            //assert
            Assert.Equals(code, "https://github.com/DuduGL?tab=repositories");
        }
    }
}
