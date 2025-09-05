using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Pessoa
    {
        //apenas um atributo público
        public string nome = string.Empty;

        //atributo privado com métodos públicos para acesso (encapsulamento)
        private int idade;
        public void SetIdade(int idade)
        {
            this.idade = idade;
        }

        public int GetIdade()
        {
            return this.idade;
        }

        //atributo privado com propriedade pública para acesso
        private double salario = double.MinValue;
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        //propriedade automática (atributo privado gerado automaticamente pelo compilador) - autoproperty
        public string Telefone { get; set; }
    }
}
