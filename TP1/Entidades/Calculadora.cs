using System;

namespace Entidades
{
    public static class Calculadora
    {
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double result;

            switch (ValidarOperador(operador))
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                default:
                    result = num1 + num2;
                    break;
            }
            return result;
        }

        private static char ValidarOperador(char operador)
        {
            if(operador != '-' || operador != '*' || operador != '/' || operador != '+')
            {
                return operador;
            }
            else
            {
            return '+';
            }
        }
    }
}
