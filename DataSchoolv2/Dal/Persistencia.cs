using MySql.Data.MySqlClient;
using Pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class Persistencia
    {
        public static MySqlDataReader ExecutarSQL(string pSQL, object pEntidade)
        {
            MySqlCommand comando = new MySqlCommand(pSQL, Conexao.ConectarBD());
            if (pEntidade is Aluno aluno)
            {

            }
        }
    }
}
