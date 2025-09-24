namespace Exemplo_Heranca
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalarioFuncionario = new System.Windows.Forms.TextBox();
            this.txtSalarioGerente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalarioGerente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário funcionário";
            // 
            // txtSalarioFuncionario
            // 
            this.txtSalarioFuncionario.Location = new System.Drawing.Point(47, 36);
            this.txtSalarioFuncionario.Name = "txtSalarioFuncionario";
            this.txtSalarioFuncionario.Size = new System.Drawing.Size(135, 20);
            this.txtSalarioFuncionario.TabIndex = 1;
            // 
            // txtSalarioGerente
            // 
            this.txtSalarioGerente.Location = new System.Drawing.Point(47, 91);
            this.txtSalarioGerente.Name = "txtSalarioGerente";
            this.txtSalarioGerente.Size = new System.Drawing.Size(135, 20);
            this.txtSalarioGerente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salário gerente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalarioGerente
            // 
            this.btnSalarioGerente.Location = new System.Drawing.Point(205, 91);
            this.btnSalarioGerente.Name = "btnSalarioGerente";
            this.btnSalarioGerente.Size = new System.Drawing.Size(75, 23);
            this.btnSalarioGerente.TabIndex = 5;
            this.btnSalarioGerente.Text = "Calcular";
            this.btnSalarioGerente.UseVisualStyleBackColor = true;
            this.btnSalarioGerente.Click += new System.EventHandler(this.btnSalarioGerente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalarioGerente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSalarioGerente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalarioFuncionario);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalarioFuncionario;
        private System.Windows.Forms.TextBox txtSalarioGerente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalarioGerente;
    }
}

