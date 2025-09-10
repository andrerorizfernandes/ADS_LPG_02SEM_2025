using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exemplos de construtores
            Cliente c1 = new Cliente();
            Cliente c2 = new Cliente("dsfsdfsdf");
            c2.MetodoQualquer();

            Fornecedor f1 = new Fornecedor();
            f1.SaldoDevedor += 20;
            Console.WriteLine("O saldo devedor é " + f1.SaldoDevedor);
        }
    }
}
