
namespace Soma_AN
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
            this.btCalcular = new System.Windows.Forms.Button();
            this.lbValorA = new System.Windows.Forms.Label();
            this.lbValorN = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(12, 97);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(145, 34);
            this.btCalcular.TabIndex = 0;
            this.btCalcular.Text = "Calcular Soma(a, N)";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lbValorA
            // 
            this.lbValorA.AutoSize = true;
            this.lbValorA.Location = new System.Drawing.Point(12, 41);
            this.lbValorA.Name = "lbValorA";
            this.lbValorA.Size = new System.Drawing.Size(21, 17);
            this.lbValorA.TabIndex = 1;
            this.lbValorA.Text = "A:";
            // 
            // lbValorN
            // 
            this.lbValorN.AutoSize = true;
            this.lbValorN.Location = new System.Drawing.Point(12, 72);
            this.lbValorN.Name = "lbValorN";
            this.lbValorN.Size = new System.Drawing.Size(20, 17);
            this.lbValorN.TabIndex = 2;
            this.lbValorN.Text = "n:";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(12, 134);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(33, 17);
            this.lbResultado.TabIndex = 3;
            this.lbResultado.Text = "-----";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(39, 38);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(100, 22);
            this.txtValorA.TabIndex = 4;
            // 
            // txtValorN
            // 
            this.txtValorN.Location = new System.Drawing.Point(38, 69);
            this.txtValorN.Name = "txtValorN";
            this.txtValorN.Size = new System.Drawing.Size(100, 22);
            this.txtValorN.TabIndex = 5;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 182);
            this.Controls.Add(this.txtValorN);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbValorN);
            this.Controls.Add(this.lbValorA);
            this.Controls.Add(this.btCalcular);
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Soma(a,N)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbValorA;
        private System.Windows.Forms.Label lbValorN;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox txtValorN;
    }
}

