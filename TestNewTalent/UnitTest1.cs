using NewTalents;



namespace TestNewTalent
{
	public class UnitTest1
	{

		public Calculadora construirClasse()
		{
			string data = "14/09/2022";
			Calculadora calc = new Calculadora("14/09/2022");

			return calc;

		}
		
		[Theory]
		[InlineData (1, 2, 3)]
		[InlineData (4, 5, 9)]
		public void TestSomar(int val1, int val2, int resultado)
		{
			Calculadora calc = construirClasse();

			int resultadoCalculadora = calc.somar(val1, val2);

			Assert.Equal(resultado, resultadoCalculadora);
		}


		[Theory]
		[InlineData(2, 1, 1)]
		[InlineData(5, 4, 1)]
		public void TestSubtrair(int val1, int val2, int resultado)
		{
			Calculadora calc = construirClasse();

			int resultadoCalculadora = calc.subtrair(val1, val2);

			Assert.Equal(resultado, resultadoCalculadora);
		}

		[Theory]
		[InlineData(1, 2, 2)]
		[InlineData(4, 5, 20)]
		public void TestMultiplicar(int val1, int val2, int resultado)
		{
			Calculadora calc = construirClasse();

			int resultadoCalculadora = calc.multiplicar(val1, val2);

			Assert.Equal(resultado, resultadoCalculadora);
		}


		[Theory]
		[InlineData(6, 2, 3)]
		[InlineData(5, 5, 1)]
		public void TestDividir(int val1, int val2, int resultado)
		{
			Calculadora calc = construirClasse();

			int resultadoCalculadora = calc.dividir(val1, val2);

			Assert.Equal(resultado, resultadoCalculadora);
		}

		[Fact]
		public void testardivisaoPorZero()
		{
			Calculadora calc = construirClasse();

			Assert.Throws<DivideByZeroException>(
				() => calc.dividir(3,0)
				);
		}

		[Fact]
		public void testarHistorico()
		{
			Calculadora calc = construirClasse();

			calc.somar(1, 2);
			calc.somar(2, 8);
			calc.somar(3, 7);
			calc.somar(4, 1);

			var lista = calc.historico();

			Assert.NotEmpty(lista);
			Assert.Equal(3, lista.Count);
		}

	}
}