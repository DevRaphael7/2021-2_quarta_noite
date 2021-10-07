
namespace Projeto_com_Duas_Forms
{
    partial class FrmPessoas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPessoas = new System.Windows.Forms.TextBox();
            this.btFechar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPessoas
            // 
            this.txtPessoas.Location = new System.Drawing.Point(12, 12);
            this.txtPessoas.Multiline = true;
            this.txtPessoas.Name = "txtPessoas";
            this.txtPessoas.Size = new System.Drawing.Size(804, 600);
            this.txtPessoas.TabIndex = 0;
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.Location = new System.Drawing.Point(12, 618);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(804, 70);
            this.btFechar.TabIndex = 1;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 711);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(710, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 800);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.txtPessoas);
            this.Name = "FrmPessoas";
            this.Text = "Pessoas";
            this.Load += new System.EventHandler(this.FrmPessoas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPessoas;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button button1;
    }
}