
namespace Projeto_com_Duas_Forms
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbSobrenome = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btIncluir = new System.Windows.Forms.Button();
            this.btListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(60, 74);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(80, 25);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome: ";
            // 
            // lbSobrenome
            // 
            this.lbSobrenome.AutoSize = true;
            this.lbSobrenome.Location = new System.Drawing.Point(12, 130);
            this.lbSobrenome.Name = "lbSobrenome";
            this.lbSobrenome.Size = new System.Drawing.Size(128, 25);
            this.lbSobrenome.TabIndex = 1;
            this.lbSobrenome.Text = "Sobrenome:";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(61, 195);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(79, 25);
            this.lbMail.TabIndex = 2;
            this.lbMail.Text = "E-Mail:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(143, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(248, 31);
            this.txtNome.TabIndex = 3;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(144, 127);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(247, 31);
            this.txtSobrenome.TabIndex = 4;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(143, 192);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(247, 31);
            this.txtMail.TabIndex = 5;
            // 
            // btIncluir
            // 
            this.btIncluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btIncluir.Location = new System.Drawing.Point(17, 254);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(187, 53);
            this.btIncluir.TabIndex = 6;
            this.btIncluir.Text = "Incluir Pessoa";
            this.btIncluir.UseVisualStyleBackColor = false;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btListar
            // 
            this.btListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btListar.Location = new System.Drawing.Point(210, 254);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(180, 53);
            this.btListar.TabIndex = 7;
            this.btListar.Text = "Listar Pessoa(s)";
            this.btListar.UseVisualStyleBackColor = false;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 338);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.lbSobrenome);
            this.Controls.Add(this.lbNome);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbSobrenome;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Button btListar;
    }
}

