using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projetos_web
{
    public partial class Exemplo_01 : System.Web.UI.Page
    {
        private string ExibirMensagem(string pMensagem) { 
            return pMensagem;
        }

        private string ExibirMensagem(Visualizacao visualizacao) {
            return  visualizacao.Mensagem + " - " + visualizacao.DataHora.ToString("g");
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExibir_Click(object sender, EventArgs e)
        {
            //lblNome.Text = ExibirMensagem(txtNome.Text);
            Visualizacao v = new Visualizacao();
            v.Mensagem = txtNome.Text;
            v.DataHora = DateTime.Now;

            lblNome.Text = ExibirMensagem(v);
        }
    }
}