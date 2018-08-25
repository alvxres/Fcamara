    using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1000.00, x = 1.5;
            salario = (salario * x);
            //Usei o I de 7 para 18 para representar o decorrer dos anos

            for (int i = 7; i < 18; i++)
            {
                salario = (salario * (x * 2));
            }

            Console.WriteLine("Em 2018, o salário do funcionário será de {0}", salario.ToString("F2"));

            Console.ReadKey();

        }
    }
}
