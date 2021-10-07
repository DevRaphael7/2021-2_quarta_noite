using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_com_Duas_Forms
{
    public partial class FrmPrincipal : Form
    {
        private List<Pessoa> pessoas;

        public FrmPrincipal()
        {
            InitializeComponent();
            pessoas = new List<Pessoa>();
            txtNome.Focus();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            FrmPessoas formPessoas = new FrmPessoas();
            formPessoas.ListaPessoas = pessoas;
            formPessoas.Show();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtSobrenome.Text == "")
            {
                MessageBox.Show("Verifique se você preencheu o nome e o sobrenome");
                return;
            }

            Pessoa p = new Pessoa(
                    txtNome.Text,
                    txtSobrenome.Text,
                    txtMail.Text);

            pessoas.Add(p);

            txtNome.Clear();
            txtSobrenome.Clear();
            txtMail.Clear();
            txtNome.Focus();

            MessageBox.Show(p.Nome + " cadastrado(a)!");
        }
    }
}
