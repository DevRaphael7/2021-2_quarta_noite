using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbResultado.Text = "";
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            lbResultado.Text = "";
        }

        private void btOlaMundo_Click(object sender, EventArgs e)
        {
            lbResultado.Text = txtNome.Text;
            MessageBox.Show(
                "Olá " + txtNome.Text + ", sinta-se acolhido(a)! :)");
        }
    }
}
