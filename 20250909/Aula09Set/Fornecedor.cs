using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09Set
{
    public class Fornecedor
    {
        public double SaldoDevedor { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }    

        public Fornecedor()
        {
            this.SaldoDevedor = -10;
        }
    }
}
