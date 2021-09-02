using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Simples
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

        }

        private void TrataOperacao_Click(object sender, EventArgs e)
        {
            try
            {
                String vA, vb;

                vA = txtValorA.Text;
                vb = txtValorB.Text;

                Matematica mat = new Matematica(vA, vb);
                switch (((Button)sender).Name)
                {
                    case "btSomar":
                        lbResultado.Text = mat.Soma().ToString();
                        break;
                    case "btSubtracao":
                        lbResultado.Text = mat.Subtracao().ToString();
                        break;
                    case "btMultiplicacao":
                        lbResultado.Text = mat.Multiplicacao().ToString();
                        break;
                    case "btDivisao":
                        lbResultado.Text = mat.Divisao().ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                lbResultado.Text = ex.Message;
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtValorA.Clear();
            txtValorB.Clear();
            lbResultado.Text = "---";
        }
    }
}
