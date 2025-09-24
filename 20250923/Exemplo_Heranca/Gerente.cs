using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Heranca
{
    public class Gerente : Funcionario
    {
        public string IdentificacaoGerente { get; set; }

        public override double PagarSalario(double pSalario)
        {
            return salario = pSalario + (pSalario * 0.20);
        }
    }
}