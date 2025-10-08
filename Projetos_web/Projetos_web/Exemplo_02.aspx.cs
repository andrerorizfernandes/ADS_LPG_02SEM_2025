using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projetos_web
{
    public partial class Exemplo_02 : System.Web.UI.Page
    {
        private string MensagemFechamentoContrato(Boolean Aceito)
        {
            var lRetorno = string.Empty;

            if (Aceito)
            {
                lRetorno = chkAceito.Text;
            }

            return lRetorno;
        }

        private string CodigoCorSelecionada()
        {
            return ddlDados.SelectedValue;
        }

        private void PreencherCores()
        {
            ddlDados.Items.Add(new ListItem("Amarelo", "100"));
            ddlDados.Items.Add(new ListItem("Azul", "200"));
            ddlDados.Items.Add(new ListItem("Verde", "300"));
            ddlDados.Items.Add(new ListItem("Vermelho", "400"));
            ddlDados.Items.Add(new ListItem("Rosa", "500"));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                PreencherCores();
            }
        }

        protected void chkAceito_CheckedChanged(object sender, EventArgs e)
        {
            lblInfo02.Text = MensagemFechamentoContrato(chkAceito.Checked);
        }

        protected void ddlDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInformacao.Text = CodigoCorSelecionada();
        }
    }
}