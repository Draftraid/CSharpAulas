using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAulas.Uteis
{
    public class Calculadora
    {
        public static int Soma(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtracao(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiplicacao(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divisao(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Fatorial(int num)
        {
            if( num == 1)
            {
                return num;
            }
            else
            {
                return num * Fatorial(num -1);
            }
        }
    }

}
