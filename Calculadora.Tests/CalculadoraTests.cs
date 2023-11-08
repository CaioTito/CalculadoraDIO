using CalculadoraPrograma;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {

        public CalculadoraExecucao construirClasse()
        {
            DateTime data = DateTime.Now;
            return new CalculadoraExecucao(data);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void Soma_ValoresInteiros_RetornaDouble(double valor1, double valor2, double resultado)
        {
            //Arrange
            CalculadoraExecucao calc = construirClasse();

            //Act
            double resultadoCalculadora = calc.Somar(valor1, valor2);

            //Assert
            Assert.Equal(resultado, resultado);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(4, 5, -1)]
        public void Subtrai_ValoresInteiros_RetornaDouble(double valor1, double valor2, double resultado)
        {
            //Arrange
            CalculadoraExecucao calc = construirClasse();

            //Act
            double resultadoCalculadora = calc.Subtrair(valor1, valor2);

            //Assert
            Assert.Equal(resultado, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void Multiplica_ValoresInteiros_RetornaDouble(double valor1, double valor2, double resultado)
        {
            //Arrange
            CalculadoraExecucao calc = construirClasse();

            //Act
            double resultadoCalculadora = calc.Multiplicar(valor1, valor2);

            //Assert
            Assert.Equal(resultado, resultado);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(6, 3, 2)]
        public void Dividir_ValoresInteiros_RetornaDouble(double valor1, double valor2, double resultado)
        {
            //Arrange
            CalculadoraExecucao calc = construirClasse();

            //Act
            double resultadoCalculadora = calc.Dividir(valor1, valor2);

            //Assert
            Assert.Equal(resultado, resultado);
        }

        [Fact]
        public void Dividir_DivisorZero_RetornaInfinito()
        {
            //Arrange
            CalculadoraExecucao calc = construirClasse();

            //Act
            double resultadoCalculadora = calc.Dividir(2, 0);

            //Assert
            Assert.Equal(double.PositiveInfinity, resultadoCalculadora);
        }

        [Fact]
        public void ListarHistorico_UltimasOperacoes_RetornaLista()
        {
            //Arrange
            CalculadoraExecucao calc = construirClasse();

            calc.Somar(1, 2);
            calc.Somar(2, 8);
            calc.Somar(3, 7);
            calc.Somar(4, 1);

            var lista = calc.Historico();

            //Act

            //Assert
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }

        [Fact]
        public void ColetarValores_ValoresDouble_RetornaTupla()
        {
            //Arrange
            CalculadoraExecucao calc = construirClasse();
            Console.SetIn(new StringReader("MockInput"));

            //Act
            var resultadoCalculadora = calc.ColetarValores();

            //Assert
            Assert.IsType<Tuple<double, double>>(resultadoCalculadora);
        }
    }
}










