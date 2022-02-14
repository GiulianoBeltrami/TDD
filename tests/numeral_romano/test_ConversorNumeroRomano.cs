using NumeroRomano.Conversor;
using Xunit;

namespace tests
{
    public class TestConversor
    {
        [Fact]
        public void deveEntenderOSimboloI()
        {
            var romano = new ConversorDeNumeroRomano();

            var simboloConvertido = romano.converter("I");

            Assert.Equal(1, simboloConvertido);
        }

        [Fact]
        public void deveEntenderOSimboloV()
        {
            var romano = new ConversorDeNumeroRomano();

            var simboloConvertido = romano.converter("V");

            Assert.Equal(5, simboloConvertido);
        }
    }
}
