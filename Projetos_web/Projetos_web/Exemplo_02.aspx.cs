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

        private void PreencherCarros()
        {
            lbiCarros.Items.Add(new ListItem("Corolla", "1"));
            lbiCarros.Items.Add(new ListItem("Civic", "2"));
            lbiCarros.Items.Add(new ListItem("Polo", "3"));
            lbiCarros.Items.Add(new ListItem("Siena", "4"));
            lbiCarros.Items.Add(new ListItem("Palio", "5"));
            lbiCarros.Items.Add(new ListItem("Celta", "6"));
        }

        protected void showMessageBox(string message)
        {
            string sJavaScript = "<script language=javascript>\n";
            sJavaScript += "alert('" + message + "');";
            sJavaScript += "\n";
            sJavaScript += "</script>";
            ClientScript.RegisterStartupScript(typeof(string), "MessageBox", sJavaScript);
        }

        private string CarrosSelecionados()
        {
            var lRetorno = string.Empty;
            /* foreach (ListItem item in lbiCarros.Items)
            {
                if (item.Selected)
                {
                    lRetorno += item.Text + ";";
                }
            }
            return lRetorno;*/

            var I = 0;
            while (I < lbiCarros.Items.Count)
            {
                if (lbiCarros.Items[I].Selected)
                {
                    lRetorno += lbiCarros.Items[I].Text + ";";
                }

                I++;
            }

            return lRetorno.Substring(0, lRetorno.Length - 1);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                PreencherCores();
                PreencherCarros();
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

        protected void btnSelecionados_Click(object sender, EventArgs e)
        {
            var lResultado = CarrosSelecionados();
            lblInformacao3.Text = lResultado;
            showMessageBox(lResultado);
        }
    }
}