using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soma_AN
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int a, n;
                //A conversão pode ser feita de qualquer uma das formas abaixo:
                a = int.Parse(txtValorA.Text);
                n = Convert.ToInt32(txtValorN.Text);
                lbResultado.Text = SomaAN(a, n);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Houve algum erro...\n\n" + ex.Message);
            }
        }

        private String SomaAN(int a, int n)
        {
            String resultado = "";

            int contador = a;
            int aux = a;
            resultado += a + " + ";
            for (int i = 1; i < n; i++)
            {
                contador += (a + i); //é o mesmo que contador = contator + (a+1)
                aux = a + i; //é o próximo valor a ser somado
                resultado += aux;
                if(i != (n - 1))
                {
                    resultado += " + ";
                }
            }

            return (resultado + " = " + contador);
        }
    }
}
