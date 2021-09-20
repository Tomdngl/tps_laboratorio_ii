using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza la operacion entre los operandos utilizando el operador designado.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Valida que el operador sea un char correcto. Caso contrario retorna '+'
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static char ValidarOperador(char operador)
        {
            if(operador == '-' || operador == '*' || operador == '/' || operador == '+')
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
