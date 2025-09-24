using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Heranca
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }

        protected double salario;

        public virtual double PagarSalario(double pSalario)
        {
            return salario = pSalario;
        }
    }
}
