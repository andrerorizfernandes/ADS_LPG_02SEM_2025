using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Conta
    {
        private int numero;
        private double saldo;
        public Pessoa titular;

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor > saldo)
                return false;
            
            saldo -= valor;
            return true;
        }
    }
}
