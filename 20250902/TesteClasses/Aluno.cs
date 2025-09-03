using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteClasses
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string Escolaridade { get; set; }
        public string Curso { get; set; }

        public string Operacao(Aluno pAluno, AcaoAluno pAcaoAluno)
        {
            var lAcao = string.Empty;
            switch (pAcaoAluno)
            {
                case AcaoAluno.Matricular:
                    lAcao = "matriculado";
                    break;
                case AcaoAluno.Transferir:
                    lAcao = "transferido";
                    break;
                case AcaoAluno.Evadir:
                    lAcao = "evadido";
                    break;
            }

            return $"O aluno de matrícula {pAluno.Matricula}, do curso {pAluno.Curso} foi {lAcao} \n\n" +
              $"Dados completos do cadastro: \n" +
              $"Matrícula: {pAluno.Matricula}, Nome: {pAluno.Nome}, Sexo: {pAluno.Sexo}, " +
              $"Telefone: {pAluno.Telefone}, Endereço: {pAluno.Endereco}, Email: {pAluno.Email}, " +
              $"Nome do Pai: {pAluno.NomePai}, Nome da Mãe: {pAluno.NomeMae}, " +
              $"Escolaridade: {pAluno.Escolaridade}, Curso: {pAluno.Curso}";
        }

        public Aluno(string pCurso)
        {
            Matricula = 0;
            Nome = string.Empty;
            Sexo = string.Empty;
            Telefone = string.Empty;
            Endereco = string.Empty;
            Email = string.Empty;
            NomePai = string.Empty;
            NomeMae = string.Empty;
            Escolaridade = string.Empty;
            Curso = pCurso;
        }
    }
}
