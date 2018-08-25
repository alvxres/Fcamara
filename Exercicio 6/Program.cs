using System;

namespace ModeloRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double QtPiso, AreaLocal, AreaPiso, QtRodape ;
            Retangulo r = new Retangulo();
            Console.WriteLine("Insira a comprimento do local");
            r.LadoA = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a largura do local");
            r.LadoB = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o comprimento do piso");
            r.LadoApiso = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o largura do piso");
            r.LadoBpiso = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o comprimento do rodapé");
            r.LadoArodape = double.Parse(Console.ReadLine());


            AreaLocal = r.AreaCalc(r.LadoA, r.LadoB);
            AreaPiso = r.AreaPis(r.LadoApiso, r.LadoBpiso);

            QtPiso = AreaLocal / AreaPiso;

            QtRodape = ((r.LadoA / r.LadoArodape) * 2) + ((r.LadoB / r.LadoArodape) * 2);











            Console.WriteLine("A quantidade necessária de pisos/rodapés necessária para a área informada é{0},{1}: ", QtPiso, QtRodape);


            Console.ReadKey();
        }
    }
}
