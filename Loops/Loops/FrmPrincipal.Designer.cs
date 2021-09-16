
namespace Loops
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
            this.listResultado = new System.Windows.Forms.ListBox();
            this.btFor = new System.Windows.Forms.Button();
            this.btWhile = new System.Windows.Forms.Button();
            this.btDoWhile = new System.Windows.Forms.Button();
            this.lbMaximo = new System.Windows.Forms.Label();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listResultado
            // 
            this.listResultado.BackColor = System.Drawing.Color.White;
            this.listResultado.FormattingEnabled = true;
            this.listResultado.ItemHeight = 16;
            this.listResultado.Location = new System.Drawing.Point(12, 12);
            this.listResultado.Name = "listResultado";
            this.listResultado.Size = new System.Drawing.Size(142, 340);
            this.listResultado.TabIndex = 0;
            // 
            // btFor
            // 
            this.btFor.Location = new System.Drawing.Point(172, 139);
            this.btFor.Name = "btFor";
            this.btFor.Size = new System.Drawing.Size(150, 30);
            this.btFor.TabIndex = 1;
            this.btFor.Text = "Laço \"for\"";
            this.btFor.UseVisualStyleBackColor = true;
            this.btFor.Click += new System.EventHandler(this.btFor_Click);
            // 
            // btWhile
            // 
            this.btWhile.Location = new System.Drawing.Point(172, 194);
            this.btWhile.Name = "btWhile";
            this.btWhile.Size = new System.Drawing.Size(150, 30);
            this.btWhile.TabIndex = 2;
            this.btWhile.Text = "Laço \"while\"";
            this.btWhile.UseVisualStyleBackColor = true;
            this.btWhile.Click += new System.EventHandler(this.btWhile_Click);
            // 
            // btDoWhile
            // 
            this.btDoWhile.Location = new System.Drawing.Point(172, 250);
            this.btDoWhile.Name = "btDoWhile";
            this.btDoWhile.Size = new System.Drawing.Size(150, 30);
            this.btDoWhile.TabIndex = 3;
            this.btDoWhile.Text = "Laço \"do..while\"";
            this.btDoWhile.UseVisualStyleBackColor = true;
            this.btDoWhile.Click += new System.EventHandler(this.btDoWhile_Click);
            // 
            // lbMaximo
            // 
            this.lbMaximo.AutoSize = true;
            this.lbMaximo.Location = new System.Drawing.Point(172, 13);
            this.lbMaximo.Name = "lbMaximo";
            this.lbMaximo.Size = new System.Drawing.Size(129, 17);
            this.lbMaximo.TabIndex = 4;
            this.lbMaximo.Text = "Máximo de valores:";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(172, 33);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(100, 22);
            this.txtMaximo.TabIndex = 5;
            this.txtMaximo.Text = "10";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 359);
            this.Controls.Add(this.txtMaximo);
            this.Controls.Add(this.lbMaximo);
            this.Controls.Add(this.btDoWhile);
            this.Controls.Add(this.btWhile);
            this.Controls.Add(this.btFor);
            this.Controls.Add(this.listResultado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Loops";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listResultado;
        private System.Windows.Forms.Button btFor;
        private System.Windows.Forms.Button btWhile;
        private System.Windows.Forms.Button btDoWhile;
        private System.Windows.Forms.Label lbMaximo;
        private System.Windows.Forms.TextBox txtMaximo;
    }
}

