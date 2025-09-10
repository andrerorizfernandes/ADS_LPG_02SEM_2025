using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09Set
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public Cliente()
        {
            this.Nome = "";
            this.Telefone = "";
            this.Email = "";
        }

        public string MetodoQualquer()
        {
            return "Teste";
        }
    }
}
