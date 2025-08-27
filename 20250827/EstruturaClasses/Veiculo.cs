using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaClasses
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public string Montadora { get; set; }
        public int Ano { get; set; }
        public double Potencia { get; set; }

        public enum TipoPessoa
        {
            Fisica,
            Juridica
        }

        public double ValorLiquidoAluguel(double pValorBruto, TipoPessoa pTipoPessoa)
        {
            const double DESCONTO_PESSOA_FISICA = 0.05;
            const double DESCONTO_PESSOA_JURIDICA = 0.15;

            var lValorDesconto = 0.0;
            switch (pTipoPessoa)
            {
                case TipoPessoa.Fisica:
                {
                    lValorDesconto = (pValorBruto * DESCONTO_PESSOA_FISICA);
                    break;
                }
                case TipoPessoa.Juridica:
                    {
                        lValorDesconto = (pValorBruto * DESCONTO_PESSOA_JURIDICA);
                        break;
                    }
            }

            return (pValorBruto - lValorDesconto);
        }
    }
}
