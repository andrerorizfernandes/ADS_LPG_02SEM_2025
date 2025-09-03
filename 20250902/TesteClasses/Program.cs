using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno("ADS");

            Console.WriteLine("Informe a matrícula");
            a.Matricula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o nome");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Informe o sexo");
            a.Sexo = Console.ReadLine();
            Console.WriteLine("Informe o telefone");
            a.Telefone = Console.ReadLine();
            Console.WriteLine("Informe o endereço");
            a.Endereco = Console.ReadLine();
            Console.WriteLine("Informe o email");
            a.Email = Console.ReadLine();
            Console.WriteLine("Informe o nome do pai");
            a.NomePai = Console.ReadLine();
            Console.WriteLine("Informe o nome da mãe");
            a.NomeMae = Console.ReadLine();
            Console.WriteLine("Informe a escolaridade");
            a.Escolaridade = Console.ReadLine();
            Console.WriteLine("Informe o curso");
            var lCurso = Console.ReadLine();
            if(lCurso.Trim() != string.Empty)
            {
                a.Curso = lCurso;
            }

            var lOperacao = AcaoAluno.Nenhum;
            Console.WriteLine("Informe a operação: 1 - Matricular, 2 - Transferir, 3 - Evadir");
            switch (Console.ReadLine())
            {
                case "1":
                    lOperacao = AcaoAluno.Matricular;
                    break;
                case "2":
                    lOperacao = AcaoAluno.Transferir;
                    break;
                case "3":
                    lOperacao = AcaoAluno.Evadir;
                    break;
            }

            var lTeste = a.Operacao(a, lOperacao);
            Console.WriteLine(lTeste);
            Console.ReadKey();
        }
    }
}
