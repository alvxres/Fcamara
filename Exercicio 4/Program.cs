using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double m2;
            bool valido = true;
            Console.WriteLine("Insira os metros quadrados a serem pintados");
            string m1 = Console.ReadLine();
            valido = double.TryParse(m1, out m2);
            while(valido == false)
                {
                Console.WriteLine("Erro. Coloque apenas números");
                    Console.WriteLine("Insira os metros quadrados a serem pintados");
                    string teste = Console.ReadLine();
                    valido = double.TryParse(Console.ReadLine(), out m2);
                }
            int contador=0;
            
            
            m2 = m2 / 3;
            do
            {
                m2 = m2 - 18;
                contador++;
            } while (m2 >= 18);
            if (m2 > 0)
            {
                contador++;

            }
            double preço = contador * 80;
            Console.WriteLine("O número de latas a serem compradas é " + contador + ", totalizando: " + preço + " reais.");
            Console.ReadKey();

        }
    }
}
