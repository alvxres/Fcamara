using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int entradaA, entradaB, num, i, ctr;

            do {
                Console.WriteLine("Digite o início do intervalo");
                entradaA = int.Parse(Console.ReadLine());
            } while (entradaA <= 1);
            do {
                Console.WriteLine("Digite o fim do intervalo");
                entradaB = int.Parse(Console.ReadLine());
            } while (entradaB <= entradaA);
            int[] primos = new int[entradaB];
            for (num = entradaA; num <= entradaB; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");
            Console.ReadKey();
        }
       
    }
}

