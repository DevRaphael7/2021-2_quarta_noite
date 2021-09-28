
namespace Hello_World
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.btOlaMundo = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AccessibleName = "";
            this.txtNome.Location = new System.Drawing.Point(36, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(153, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(33, 9);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(100, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Insira seu nome:";
            // 
            // btOlaMundo
            // 
            this.btOlaMundo.BackColor = System.Drawing.Color.Yellow;
            this.btOlaMundo.Location = new System.Drawing.Point(36, 51);
            this.btOlaMundo.Name = "btOlaMundo";
            this.btOlaMundo.Size = new System.Drawing.Size(153, 23);
            this.btOlaMundo.TabIndex = 2;
            this.btOlaMundo.Text = "Dizer olá...";
            this.btOlaMundo.UseVisualStyleBackColor = false;
            this.btOlaMundo.Click += new System.EventHandler(this.btOlaMundo_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(33, 106);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(73, 13);
            this.lbResultado.TabIndex = 3;
            this.lbResultado.Text = "RESULTADO";
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btLimpar.Location = new System.Drawing.Point(36, 80);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(153, 23);
            this.btLimpar.TabIndex = 4;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(211, 154);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btOlaMundo);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Button btOlaMundo;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btLimpar;
    }
}

