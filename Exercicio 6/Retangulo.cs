using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloRetangulo
{
    class Retangulo
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoApiso { get; set; }
        public double LadoBpiso { get; set; }
        public double LadoArodape { get; set; }
 

        public void MudaLado(double altret, double largret)
        {
            Console.WriteLine("Insira a altura do local");
            LadoA = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a largura do local");
            LadoB = double.Parse(Console.ReadLine());
            Console.WriteLine("Valores alterados.");
            return;
        }
        public string RetornaLado(double altret, double largret)
        {
            string a = LadoA + " " + LadoB;
            return a;
        }
        public double AreaCalc(double altret, double largret)
        {
            return LadoA * LadoB;
        }
        public double PerimetroCalc(double altret, double largret)
        {
            return (2 * (largret * altret));
        }
        public double AreaPis(double altpis, double largpis)
        {
            return LadoApiso * LadoBpiso;
        }
    }
}
    