using Bll;
using Pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace View
{
    public partial class AlunoView : System.Web.UI.Page
    {
        private AlunoBll _alunoBll;

        public AlunoView()
        {
            _alunoBll = new AlunoBll();
        }

        private void ExibirMensagem(string mensagem)
        {
            string sJavaScript = "<script language=javascript>\n";
            sJavaScript += "alert('" + mensagem + "');";
            sJavaScript += "\n";
            sJavaScript += "</script>";
            ClientScript.RegisterStartupScript(typeof(string), "MessageBox", sJavaScript);
        }

        private void LimparCamposInsercao()
        {
            txtNovoNome.Text = string.Empty;
            txtNovoCpf.Text = string.Empty;
            txtNovoIdade.Text = string.Empty;
            txtNovoSexo.Text = string.Empty;
        }

        private void Inserir()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = txtNovoNome.Text;
            aluno.Cpf = txtNovoCpf.Text;
            aluno.Idade = Convert.ToInt32(txtNovoIdade.Text);
            aluno.Sexo = txtNovoSexo.Text;

            if (_alunoBll.InserirAluno(aluno))
            {
                ExibirMensagem("Aluno inserido com sucesso");
                LimparCamposInsercao();
                Lib.ExibirDados(_alunoBll, gvdAluno);
            }
            else
            {
                ExibirMensagem("Erro ao inserir aluno");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Lib.ExibirDados(_alunoBll, gvdAluno);
            }
        }

        protected void gvdAluno_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void gvdAluno_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvdAluno_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvdAluno_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void Insert(object sender, EventArgs e)
        {
            Inserir();
        }
    }
}