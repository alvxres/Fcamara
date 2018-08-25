using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de horas trabalhadas");
            double hora = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do salário mínimo");
            double salmin = double.Parse(Console.ReadLine());
            double valhora = ((salmin)/0.10);
            double salbrut = (hora * valhora);
            double salfinal = (salbrut - 0.03);
            Console.WriteLine("O valor do salário a receber é: {0}", salfinal.ToString("F2"));
            Console.ReadKey();


        }
    }
}
