using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Pessoa p = new Pessoa();
            //p.nome = "João";

            Conta c = new Conta();
            c.Depositar(100);
            c.Sacar(50);

            Pessoa p = new Pessoa();
            //atributo público
            p.nome = "Antony";

            //métodos públicos para acessar atributo privado (encapsulamento)
            p.SetIdade(23);
            var tr1 = p.GetIdade();

            //propriedade pública para acessar atributo privado (propriedade)
            p.Salario = 2500.75;
            var teste = p.Salario;

            //propriedade automática (autoproperty)
            p.Telefone = "11999999999";
            var t3 = p.Telefone;

            c.titular = p;
            Console.WriteLine(c.titular.nome);
        }
    }
}
