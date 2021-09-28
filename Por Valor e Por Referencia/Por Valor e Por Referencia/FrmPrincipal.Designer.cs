
namespace Por_Valor_e_Por_Referencia
{
    partial class FrmPrincipal
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
            this.lbValorA = new System.Windows.Forms.Label();
            this.lbValorB = new System.Windows.Forms.Label();
            this.txtVarA = new System.Windows.Forms.TextBox();
            this.txtVarB = new System.Windows.Forms.TextBox();
            this.btPorRef = new System.Windows.Forms.Button();
            this.btPorValor = new System.Windows.Forms.Button();
            this.txtResB = new System.Windows.Forms.TextBox();
            this.txtResA = new System.Windows.Forms.TextBox();
            this.lbValorB2 = new System.Windows.Forms.Label();
            this.lbValorA2 = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbValorA
            // 
            this.lbValorA.AutoSize = true;
            this.lbValorA.Location = new System.Drawing.Point(12, 26);
            this.lbValorA.Name = "lbValorA";
            this.lbValorA.Size = new System.Drawing.Size(58, 17);
            this.lbValorA.TabIndex = 0;
            this.lbValorA.Text = "Valor A:";
            // 
            // lbValorB
            // 
            this.lbValorB.AutoSize = true;
            this.lbValorB.Location = new System.Drawing.Point(12, 62);
            this.lbValorB.Name = "lbValorB";
            this.lbValorB.Size = new System.Drawing.Size(58, 17);
            this.lbValorB.TabIndex = 1;
            this.lbValorB.Text = "Valor B:";
            // 
            // txtVarA
            // 
            this.txtVarA.Location = new System.Drawing.Point(76, 23);
            this.txtVarA.Name = "txtVarA";
            this.txtVarA.Size = new System.Drawing.Size(100, 22);
            this.txtVarA.TabIndex = 4;
            // 
            // txtVarB
            // 
            this.txtVarB.Location = new System.Drawing.Point(76, 57);
            this.txtVarB.Name = "txtVarB";
            this.txtVarB.Size = new System.Drawing.Size(100, 22);
            this.txtVarB.TabIndex = 5;
            // 
            // btPorRef
            // 
            this.btPorRef.Location = new System.Drawing.Point(218, 137);
            this.btPorRef.Name = "btPorRef";
            this.btPorRef.Size = new System.Drawing.Size(210, 44);
            this.btPorRef.TabIndex = 8;
            this.btPorRef.Text = "Passagem por REFERÊNCIA";
            this.btPorRef.UseVisualStyleBackColor = true;
            this.btPorRef.Click += new System.EventHandler(this.btPorRef_Click);
            // 
            // btPorValor
            // 
            this.btPorValor.Location = new System.Drawing.Point(218, 26);
            this.btPorValor.Name = "btPorValor";
            this.btPorValor.Size = new System.Drawing.Size(210, 44);
            this.btPorValor.TabIndex = 9;
            this.btPorValor.Text = "Passagem por VALOR";
            this.btPorValor.UseVisualStyleBackColor = true;
            this.btPorValor.Click += new System.EventHandler(this.btPorValor_Click);
            // 
            // txtResB
            // 
            this.txtResB.Location = new System.Drawing.Point(76, 168);
            this.txtResB.Name = "txtResB";
            this.txtResB.Size = new System.Drawing.Size(100, 22);
            this.txtResB.TabIndex = 13;
            // 
            // txtResA
            // 
            this.txtResA.Location = new System.Drawing.Point(76, 134);
            this.txtResA.Name = "txtResA";
            this.txtResA.Size = new System.Drawing.Size(100, 22);
            this.txtResA.TabIndex = 12;
            // 
            // lbValorB2
            // 
            this.lbValorB2.AutoSize = true;
            this.lbValorB2.Location = new System.Drawing.Point(12, 173);
            this.lbValorB2.Name = "lbValorB2";
            this.lbValorB2.Size = new System.Drawing.Size(58, 17);
            this.lbValorB2.TabIndex = 11;
            this.lbValorB2.Text = "Valor B:";
            // 
            // lbValorA2
            // 
            this.lbValorA2.AutoSize = true;
            this.lbValorA2.Location = new System.Drawing.Point(12, 137);
            this.lbValorA2.Name = "lbValorA2";
            this.lbValorA2.Size = new System.Drawing.Size(58, 17);
            this.lbValorA2.TabIndex = 10;
            this.lbValorA2.Text = "Valor A:";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(12, 208);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(416, 26);
            this.btLimpar.TabIndex = 14;
            this.btLimpar.Text = "Limpar Tudo";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 258);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.txtResB);
            this.Controls.Add(this.txtResA);
            this.Controls.Add(this.lbValorB2);
            this.Controls.Add(this.lbValorA2);
            this.Controls.Add(this.btPorValor);
            this.Controls.Add(this.btPorRef);
            this.Controls.Add(this.txtVarB);
            this.Controls.Add(this.txtVarA);
            this.Controls.Add(this.lbValorB);
            this.Controls.Add(this.lbValorA);
            this.Name = "FrmPrincipal";
            this.Text = "Por valor e Por referência";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbValorA;
        private System.Windows.Forms.Label lbValorB;
        private System.Windows.Forms.TextBox txtVarA;
        private System.Windows.Forms.TextBox txtVarB;
        private System.Windows.Forms.Button btPorRef;
        private System.Windows.Forms.Button btPorValor;
        private System.Windows.Forms.TextBox txtResB;
        private System.Windows.Forms.TextBox txtResA;
        private System.Windows.Forms.Label lbValorB2;
        private System.Windows.Forms.Label lbValorA2;
        private System.Windows.Forms.Button btLimpar;
    }
}

