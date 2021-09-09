
namespace Calculadora_IMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lbPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lbAltura = new System.Windows.Forms.Label();
            this.btCalculaIMC = new System.Windows.Forms.Button();
            this.lbResultadoIMC = new System.Windows.Forms.Label();
            this.lbClassificacaoIMC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Location = new System.Drawing.Point(39, 40);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(44, 17);
            this.lbPeso.TabIndex = 0;
            this.lbPeso.Text = "Peso:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(89, 37);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 22);
            this.txtPeso.TabIndex = 1;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(89, 65);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 3;
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(34, 68);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(49, 17);
            this.lbAltura.TabIndex = 2;
            this.lbAltura.Text = "Altura:";
            // 
            // btCalculaIMC
            // 
            this.btCalculaIMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btCalculaIMC.Location = new System.Drawing.Point(37, 93);
            this.btCalculaIMC.Name = "btCalculaIMC";
            this.btCalculaIMC.Size = new System.Drawing.Size(152, 30);
            this.btCalculaIMC.TabIndex = 4;
            this.btCalculaIMC.Text = "Calcular IMC";
            this.btCalculaIMC.UseVisualStyleBackColor = false;
            this.btCalculaIMC.Click += new System.EventHandler(this.btCalculaIMC_Click);
            // 
            // lbResultadoIMC
            // 
            this.lbResultadoIMC.AutoSize = true;
            this.lbResultadoIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoIMC.Location = new System.Drawing.Point(252, 32);
            this.lbResultadoIMC.Name = "lbResultadoIMC";
            this.lbResultadoIMC.Size = new System.Drawing.Size(70, 25);
            this.lbResultadoIMC.TabIndex = 5;
            this.lbResultadoIMC.Text = "label1";
            this.lbResultadoIMC.Visible = false;
            // 
            // lbClassificacaoIMC
            // 
            this.lbClassificacaoIMC.AutoSize = true;
            this.lbClassificacaoIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassificacaoIMC.Location = new System.Drawing.Point(252, 78);
            this.lbClassificacaoIMC.Name = "lbClassificacaoIMC";
            this.lbClassificacaoIMC.Size = new System.Drawing.Size(64, 25);
            this.lbClassificacaoIMC.TabIndex = 6;
            this.lbClassificacaoIMC.Text = "label2";
            this.lbClassificacaoIMC.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 157);
            this.Controls.Add(this.lbClassificacaoIMC);
            this.Controls.Add(this.lbResultadoIMC);
            this.Controls.Add(this.btCalculaIMC);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lbPeso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Calculadora IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.Button btCalculaIMC;
        private System.Windows.Forms.Label lbResultadoIMC;
        private System.Windows.Forms.Label lbClassificacaoIMC;
    }
}

