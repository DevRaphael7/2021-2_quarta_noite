using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_IMC
{
    class Imc
    {
        private float _altura;
        private float _peso;
        private String _classificacao;
        private Color _corClassificacao;

        //Encapsulamento (métodos modificadores de acesso)
        //os famosos métodos "set e get":
        public float altura
        {
            get { return _altura; }
            set { _altura = value; }
        }
        public float peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        public String classificacao
        {
            get { return _classificacao; }
            set { _classificacao = value; }
        }

        public Color corClassificacao 
        { 
            get
            {
                return _corClassificacao;
            } 
        }

        //métodos:
        public float calculaIMC()
        {
            float imc = peso / (altura * altura);
            geraClassificacao(imc);
            return imc;
        }

        private void geraClassificacao(float imc)
        {
            //classificação baseada em https://arquivos.sbn.org.br/equacoes/eq5.htm
            if (imc <= 16)
            {
                classificacao = "Magreza grau III";
                _corClassificacao = Color.Red;
            }
            else if (imc > 16 && imc <= 16.9)
            {
                classificacao = "Magreza grau II";
                _corClassificacao = Color.Red;
            }
            else if (imc > 16.9 && imc <= 18.4)
            {
                classificacao = "Magreza grau I";
                _corClassificacao = Color.Red;
            }
            else if (imc > 18.5 && imc <= 24.9)
            {
                classificacao = "Adequado";
                _corClassificacao = Color.Blue;
            }
            else if (imc > 25 && imc <= 29.9)
            {
                classificacao = "Pré-obeso";
                _corClassificacao = Color.Magenta;
            }
            else if (imc > 30 && imc <= 34.9)
            {
                classificacao = "Obesidade grau I";
                _corClassificacao = Color.Red;
            }
            else if (imc > 35 && imc <= 39.9)
            {
                classificacao = "Obesidade grau II";
                _corClassificacao = Color.Red;
            }
            else
            {
                classificacao = "Obesidade grau III";
                _corClassificacao = Color.Red;
            }
        }
    }
}
