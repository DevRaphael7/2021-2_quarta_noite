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
            //Cria o novo formulário
            //passando para ele a lista criada localmenete:
            FrmPessoas formPessoas = new FrmPessoas(pessoas);
            formPessoas.Show(); //mostra o formulário
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            //verifica se o nome OU o sobrenome estao preenchidos
            if (txtNome.Text == "" || txtSobrenome.Text == "")
            {
                MessageBox.Show("Verifique se você preencheu o nome e o sobrenome");
                return;
            }

            //cria uma instância nova de pessoa
            Pessoa p = new Pessoa(
                    txtNome.Text,
                    txtSobrenome.Text,
                    txtMail.Text);

            //adiciona na lista de pessoas local
            pessoas.Add(p);

            //limpa os campos e coloca o cursor do teclado no primeiro
            txtNome.Clear();
            txtSobrenome.Clear();
            txtMail.Clear();
            txtNome.Focus(); // <- isso que move o cursor do teclado

            MessageBox.Show(p.Nome + " cadastrado(a)!");
        }
    }
}
