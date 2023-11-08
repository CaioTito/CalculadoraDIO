namespace CalculadoraPrograma
{
    public class CalculadoraExecucao
    {
        private List<string> _historico;
        private DateTime _data;

        public CalculadoraExecucao(DateTime data)
        {
            _historico = new List<string>();
            _data = data;
        }
        public double Somar(double valor1, double valor2)
        {
            double resultado = valor1 + valor2;

            AdicaoHistorico(valor1, valor2, resultado, _data);
            return resultado;
        }
        public double Subtrair(double valor1, double valor2)
        {
            double resultado = valor1 - valor2;

            AdicaoHistorico(valor1, valor2, resultado, _data);
            return resultado;
        }
        public double Multiplicar(double valor1, double valor2)
        {
            double resultado = valor1 * valor2;

            AdicaoHistorico(valor1, valor2, resultado, _data);
            return resultado;
        }
        public double Dividir(double valor1, double valor2)
        {
            double resultado = valor1 / valor2;

            AdicaoHistorico(valor1, valor2, resultado, _data);
            return resultado;
        }

        public List<string> Historico()
        {
            if (_historico.Count > 3)
                _historico.RemoveRange(3, _historico.Count - 3);
            return _historico;
        }

        public void AdicaoHistorico(double valor1, double valor2, double resultado, DateTime data)
        {
            _historico.Insert(0, $"{valor1} + {valor2} = {resultado} - {data}");
        }

        public Tuple<double, double> ColetarValores()
        {
            Console.WriteLine("Digite o primeiro valor");
            long.TryParse(Console.ReadLine(), out var valor1);
            Console.WriteLine("Digite o segundo valor");
            long.TryParse(Console.ReadLine(), out var valor2);

            Tuple<double, double> result = new Tuple<double, double>(valor1, valor2);

            return result;
        }
    }
}
