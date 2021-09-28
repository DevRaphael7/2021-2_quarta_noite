using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Simples
{
    class Matematica
    {
        public float a, b;

        public Matematica(String a, String b)
        {
            //bloco de tentativa
            try
            {
                //o "this" refere-se ao atributo local
                //o "a" sem o "this" na frente é o recebido via parâmetro
                this.a = float.Parse(a);
                this.b = float.Parse(b);
            }
            //se o bloco acima falhar em algum momento, a execução
            //será desviada para o bloco "catch":
            catch
            {
                throw new Exception("Deu Pau!");
            }
        }

        //métodos de cálculo
        public float Soma()
        {
            return a + b;
        }

        public float Subtracao()
        {
            return a - b;
        }

        public float Multiplicacao()
        {
            return a * b;
        }

        public float Divisao()
        {
            if (b != 0)
                return a / b;
            else
                return float.NaN;
        }
    }
}
