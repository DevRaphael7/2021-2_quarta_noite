
namespace Notepadinho
{
    partial class FrmTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTexto));
            this.txtTextoUsuario = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtTextoUsuario
            // 
            this.txtTextoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTextoUsuario.Location = new System.Drawing.Point(0, 0);
            this.txtTextoUsuario.Name = "txtTextoUsuario";
            this.txtTextoUsuario.Size = new System.Drawing.Size(1114, 848);
            this.txtTextoUsuario.TabIndex = 0;
            this.txtTextoUsuario.Text = "";
            // 
            // FrmTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 848);
            this.Controls.Add(this.txtTextoUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTexto";
            this.Text = "FrmTexto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTextoUsuario;
    }
}