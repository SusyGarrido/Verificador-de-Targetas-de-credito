using System;
using credito.Controllers;
using credito.Models;
using Xunit;

namespace credito.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("378282246310005",TipoTarjeta.AMERICANEXPRESS)]
        [InlineData("4556683573663799",TipoTarjeta.VISA)]
        [InlineData("5522000172587667",TipoTarjeta.MASTERCARD)]
        [InlineData("0000000000100000",TipoTarjeta.NOVALIDA)]
        public void TestValidarTarjeta(string numTarjeta,TipoTarjeta tipoTarjeta)
        {
            // Arrange
            var controller = new HomeController();
           


            // Act






            // Assert




        }
    }
}
