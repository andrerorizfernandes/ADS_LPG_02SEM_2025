    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projetos_web
{
    public partial class Exemplo_03 : System.Web.UI.Page
    {
        private static double MULHER = 8;
        private static double HOMEM = 10;
        private static double CERVEJA = 6;
        private static double REFRIGERANTE = 4.5;
        private static double ESPETO = 5;

        private double CalcularVenda(string pSexo, double pCervejas, double pRefrigerantes, double pEspetinhos)
        {
            double valConta = 0;
            //calculando a taxa inicial para homens/mulheres
            switch (pSexo)
            {
                case "M":
                    valConta += HOMEM;
                    break;
                case "F":
                    valConta += MULHER;
                    break;
            }
            //calculando a quantidade de cervejas consumidas
            valConta += pCervejas * CERVEJA;
            //calculando a quantidade de refrigerantes consumidos
            valConta += pRefrigerantes * REFRIGERANTE;
            //calculando a quantidade de espetinhos consumidos
            valConta += pEspetinhos * ESPETO;
            
            return valConta;
        }

        private void IncrementarTotalizador(double pValor)
        {
            double valorTotal = double.Parse(Session["TotalGeral"].ToString());
            valorTotal += pValor;
            Session["TotalGeral"] = valorTotal;
        }

        private void LimparCampos()
        {
            cboSexo.SelectedIndex = 0;
            txtQtdCervejas.Text = "0";
            txtQtdRefrigerantes.Text = "0";
            txtQtdEspetinhos.Text = "0";
        }

        private void ZerarTotalizador()
        {
            Session["TotalGeral"] = 0;
        }

        private void Calcular()
        {
            double lvalorConta = CalcularVenda(
                cboSexo.SelectedValue,
                double.Parse(txtQtdCervejas.Text),
                double.Parse(txtQtdRefrigerantes.Text),
                double.Parse(txtQtdEspetinhos.Text)
            );
            lblTotalAtual.Text = "Total a pagar: " + lvalorConta;

            IncrementarTotalizador(lvalorConta);
            lblTotalGeral.Text = "Total Geral Recebido: " + Session["TotalGeral"];

            LimparCampos();
        }

        private void Limpar()
        {
            LimparCampos();
            ZerarTotalizador();
            lblTotalAtual.Text = "Total a Pagar: 0";
            lblTotalGeral.Text = "Total Geral Recebido: 0";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["TotalGeral"] = 0.0;
            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}