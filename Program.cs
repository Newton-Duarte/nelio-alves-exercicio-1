using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("----------Exercicio 1: Some dois números----------");
            Console.WriteLine("Informe o primeiro número");
            int n1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe o segundo número");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine("SOMA = " + soma);

            System.Console.WriteLine("----------Exercicio 2: calcule a área de um círculo----------");
            double PI = 3.14159;
            System.Console.WriteLine("Informe o valor do raio do círculo");
            double raio = double.Parse(Console.ReadLine());
            double area = PI * raio * raio;

            System.Console.WriteLine($"A={area.ToString("F4")}");

            System.Console.WriteLine("----------Exercicio 3: calcule a diferença----------");
            Console.WriteLine("Informe o primeiro número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro número");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o quarto número");
            int d = int.Parse(Console.ReadLine());

            int diferenca = a * b - c * d;

            System.Console.WriteLine($"DIFERENÇA = {diferenca}");

            System.Console.WriteLine("----------Exercicio 4: calcule o salário----------");
            System.Console.WriteLine("Informe o número do funcionário");
            int numeroFuncionario = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o número de horas trabalhadas");
            double horasTrabalhadas = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o valor da sua hora");
            double valorHora = double.Parse(Console.ReadLine());

            double salario = horasTrabalhadas * valorHora;

            System.Console.WriteLine($"NUMBER = {numeroFuncionario}");
            System.Console.WriteLine($"SALARY = {salario.ToString("C2", CultureInfo.CurrentCulture)}");

            System.Console.WriteLine("----------Exercicio 5: calcule o valor a ser pago----------");
            System.Console.WriteLine("Informe o número do produto 1");
            int p1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"Informe a quantidade do produto {p1}");
            int q1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"Informe o valor unitário do produto {p1}");
            double v1 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o número do produto 2");
            int p2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"Informe a quantidade do produto {p2}");
            int q2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"Informe o valor unitário do produto {p2}");
            double v2 = double.Parse(Console.ReadLine());

            double total = (q1 * v1) + (q2 * v2);

            System.Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2")}");
        }
    }
}