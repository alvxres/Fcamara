using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class ContaCorrente
    {
        int numconta { get; set; }
        String nomecorrentista { get; set; }
        double saldo { get; set; }  

        public void Construtor(int numconta, String nomecorrentista, double saldo)
        {
            numconta = 12345;
            nomecorrentista = "José de Tal";
            saldo = 0.00;
        }
        public string Alterarnome()
        { return nomecorrentista; }
        public double Deposito(double valordeposito)
        { return saldo + valordeposito; }
        public double Saque(double saque)
        { return saldo - saque; }

       
    }
}
