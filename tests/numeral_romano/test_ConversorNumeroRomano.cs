using NumeroRomano.Conversor;
using Xunit;

namespace tests
{
    public class TestConversorDeNumeroRomano
    {
        [Fact]
        public void deveEntenderOSimboloI()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int simboloConvertido = romano.Converter("I");

            Assert.Equal(1, simboloConvertido);
        }

        [Fact]
        public void deveEntenderOSimboloV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int simboloConvertido = romano.Converter("V");

            Assert.Equal(5, simboloConvertido);
        }

        [Fact]
        public void deveEntenderOSimboloII()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int simboloConvertido = romano.Converter("II");

            Assert.Equal(2, simboloConvertido);
        }

        [Fact]
        public void deveEntenderOSimboloXXII()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int simboloConvertido = romano.Converter("XXII");

            Assert.Equal(22, simboloConvertido);
        }

        [Fact]
        public void deveEntenderOSimboloIX()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int simboloConvertido = romano.Converter("IX");

            Assert.Equal(9, simboloConvertido);
        }

        [Fact]
        public void deveEntenderOSimboloXXIV(){
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int simboloConvertido = romano.Converter("XXIV");

            Assert.Equal(24, simboloConvertido);
        }
    }
}
