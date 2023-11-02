using AppTDD;

namespace TesteAppTDD
{
    public class UnitTest1
    {
        [Theory]
        [InlineData (1, 2, 3)]
        public void TesteSoma(int num1, int num2, int resultado)
        {
            Calculadora calculadora = new Calculadora();

            int resultadoCalculado = calculadora.somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculado);
        }

        [Theory]
        [InlineData(3, 1, 2)]
        public void TesteSubtrair(int num1, int num2, int resultado)
        {
            Calculadora calculadora = new Calculadora();

            int resultadoCalculado = calculadora.subtrair(num1, num2);

            Assert.Equal(resultado, resultadoCalculado);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        public void TesteMultiplicar(int num1, int num2, int resultado)
        {
            Calculadora calculadora = new Calculadora();

            int resultadoCalculado = calculadora.multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoCalculado);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        public void TesteDividir(int num1, int num2, int resultado)
        {
            Calculadora calculadora = new Calculadora();

            int resultadoCalculado = calculadora.dividir(num1, num2);

            Assert.Equal(resultado, resultadoCalculado);
        }

        [Fact]
        public void TesteDividirPorZero() 
        {
            Calculadora calculadora = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => calculadora.dividir(3, 0));
        }

        [Fact]
        public void TesteHistorico()
        {
            Calculadora calculadora = new Calculadora();

            calculadora.somar(2, 2);
            calculadora.somar(2, 4);
            calculadora.somar(2, 6);
            calculadora.somar(2, 8);

            var Lista = calculadora.historico();

            Assert.NotEmpty(Lista);
            Assert.Equal(3, Lista.Count);
        }
    }
}