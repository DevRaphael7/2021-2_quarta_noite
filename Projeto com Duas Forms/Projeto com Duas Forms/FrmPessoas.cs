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
    partial class FrmPessoas : Form
    {
        //variável local (segundo form) da lista de pessoas
        private List<Pessoa> listaPessoas;

        public FrmPessoas()
        {
            InitializeComponent();
            listaPessoas = new List<Pessoa>(); //cria uma lista vazia de pessoas
        }

        public FrmPessoas(List<Pessoa> pessoas)
        {
            InitializeComponent();
            listaPessoas = pessoas; //seta a variável local de pessoas pelo recebido via onstrutor
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Dispose(); //fecha o formulário atual (limpa a instância)
        }

        private void FrmPessoas_Load(object sender, EventArgs e)
        {
            //verifica se a lista possui ao menos uma pessoa para exibir
            if (listaPessoas.Count > 0)
            {
                //para cada pessoa na lista, exibe...
                foreach(Pessoa p in listaPessoas)
                {
                    txtPessoas.Text += p.listaDados();
                    txtPessoas.Text += "--------------------" + Environment.NewLine;
                }
            } else
            {
                MessageBox.Show("Sem dados para exibir!");
                Dispose();
            }
        }
    }
}
