using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_Heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalarioGerente_Click(object sender, EventArgs e)
        {
            Gerente g = new Gerente();
            var lSalario = g.PagarSalario(Convert.ToDouble(txtSalarioGerente.Text));
            MessageBox.Show(lSalario.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            var lSalario = f.PagarSalario(Convert.ToDouble(txtSalarioFuncionario.Text));
            MessageBox.Show(lSalario.ToString());
        }
    }
}
