using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    public partial class FrmPrincipal : Form
    {
        //global da classe:
        private int maximo = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void preparaLoop()
        {
                listResultado.Items.Clear();
                maximo = int.Parse(txtMaximo.Text);
                if (maximo > 1000)
                {
                    throw new Exception("O valor máximo é 1000!");
                }
        }

        private void btFor_Click(object sender, EventArgs e)
        {
            try
            {
                preparaLoop();
                //laço for:
                //sintaxe: para I de <valor inicial>; <valor final>; <condição de incremento>
                //lembrando que i++ é o mesmo que i = i + 1;
                for (int i = 1; i <= maximo; i++)
                {
                    listResultado.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops, alogo deu errado. Você digitou um valor válido? \nErro:" + ex.Message);
            }
        }

        private void btWhile_Click(object sender, EventArgs e)
        {
            try
            {
                preparaLoop();
                int i = 1; //variável de controle
                while(i <= maximo)
                {
                    listResultado.Items.Add(i);
                    i++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops, alogo deu errado. Você digitou um valor válido? \nErro:" + ex.Message);
            }

        }

        private void btDoWhile_Click(object sender, EventArgs e)
        {
            try
            {
                preparaLoop();

                int i = 1; //variável de controle
                do
                {
                    listResultado.Items.Add(i);
                    i++;
                } while (i <= maximo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops, alogo deu errado. Você digitou um valor válido? \nErro:" + ex.Message);
            }
        }
    }
}
