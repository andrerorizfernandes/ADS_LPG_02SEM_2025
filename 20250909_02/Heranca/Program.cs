using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente cl = new Cliente();

            //classe pai
            Conta c = new Conta();
            c.Titular = cl;
            c.Numero = 123;
            c.Deposita(1000);
            c.Saca(100);
            Console.WriteLine(c.Saldo);

            //classe filha
            ContaPoupanca cp = new ContaPoupanca();
            cp.Titular = cl;
            cp.Numero = 444;
            cp.Deposita(1000);
            cp.Saca(100);
            Console.WriteLine(cp.Saldo);

            ContaUniversitario cx = new ContaUniversitario();
            cx.NIS = 123456789;
            cx.Deposita(1000);
            cx.Saca(100);
            Console.WriteLine(cx.Saldo);
        }
    }
}
