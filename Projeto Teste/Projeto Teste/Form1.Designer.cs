
namespace Projeto_Teste
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPrincipal
            // 
            this.btPrincipal.Location = new System.Drawing.Point(87, 98);
            this.btPrincipal.Name = "btPrincipal";
            this.btPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btPrincipal.TabIndex = 0;
            this.btPrincipal.Text = "Aperte-me";
            this.btPrincipal.UseVisualStyleBackColor = true;
            this.btPrincipal.Click += new System.EventHandler(this.btPrincipal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 226);
            this.Controls.Add(this.btPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPrincipal;
    }
}

