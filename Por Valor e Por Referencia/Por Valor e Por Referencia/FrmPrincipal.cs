using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Por_Valor_e_Por_Referencia
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btPorValor_Click(object sender, EventArgs e)
        {
            double varA, varB;
            varA = Convert.ToDouble(txtVarA.Text);
            varB = Convert.ToDouble(txtVarB.Text);

            /*a passagem por valor chama o procedimento passando os
             * parâmetros por VALOR, ou seja, é passada um CÓPIA
             * das variáveis
             */
            porValor(varA, varB);

            /*Aqui espera-se que os valores estejam MANTIDOS
              pois a alteração ocorreu apenas na cópia e não na variável
              original
            */
            txtVarA.Text = varA.ToString();
            txtVarB.Text = varB.ToString();

        }


        //altera o valor das variáveis locais que são passadas por valor
        //não altera os valores das variáveis originais (declaradas no botão Por Valor
        //essas alterações são válidas somente dentro deste escopo, ou seja, dentro 
        //deste método
        void porValor(double varA, double varB)
        {
            varA = varA * 3;
            varB = varB * 2;
        }

        private void btPorRef_Click(object sender, EventArgs e)
        {
            double varA, varB;
            varA = Convert.ToDouble(txtResA.Text);
            varB = Convert.ToDouble(txtResB.Text);

            //chama o procedimento porReferencia passando os parâmetros por referência
            //ou seja, passa-se o endereço deles na memória
            //é "equivalente" ao ponteiro do "C"
            porReferencia(ref varA, ref varB);

            txtResA.Text = varA.ToString();
            txtResB.Text = varB.ToString();
        }

        //a passagem por referência faz a altereção do valor da variável diretamente
        //na memória, pois obtêm-se seu endereço quando acessada por referência.
        void porReferencia(ref double varA, ref double varB)
        {
            varA = varA * 3;
            varB = varB * 2;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtVarA.Clear();
            txtVarB.Clear();
            txtResA.Clear();
            txtResB.Clear();
            txtVarA.Focus();
        }
    }
}
