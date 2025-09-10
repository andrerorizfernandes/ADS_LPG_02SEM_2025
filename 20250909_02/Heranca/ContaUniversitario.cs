using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class ContaUniversitario : Conta
    {
        public int NIS { get; set; }
        
        public override void Saca(double valor)
        {
            this.Saldo -= valor + 0.20;
        }

        public ContaUniversitario()
        {
            this.Saldo = 100;
        }
    }
}
