using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }
        public Operando()
        {
            this.numero = 0;
        }
        public Operando(double numero) : this()
        {
            this.numero = numero;
        }
        public Operando(string strNumero) : this()
        {
            Numero = strNumero;
        }
        /// <summary>
        /// Transforma un numero binario a decimal en caso de ser posible.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public static string BinarioDecimal(string binario)
        {
            string result = "Valor inválido";

            if(EsBinario(binario) && binario != "" && long.TryParse(binario, out long intBinario))
            {
                long numero = 0;
                long digito;

                for (long i = intBinario, j = 0; i > 0; i /= 10, j++)
                {
                    digito = (long)i % 10;
                    numero += digito * (long)Math.Pow(2, j);
                }

                result = numero.ToString();
            }

            return result;
        }
        /// <summary>
        /// Transforma un numero decimal en uno binario en caso de ser posible.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string numero)
        {
            double numeroDouble;
            if(double.TryParse(numero, out numeroDouble))
            {
                return DecimalBinario(numeroDouble);
            }
            else
            {
                return "Valor inválido";
            }
        }
        public static string DecimalBinario(double numero)
        {
            string resultado = "";
            if(numero > int.MaxValue || numero < int.MinValue)
            {
                return "Valor inválido";
            }
            int numeroEntero = Convert.ToInt32(Math.Abs(numero));
            while (numeroEntero != 0)
            {
                if (numeroEntero % 2 == 0)
                {
                    resultado = resultado.Insert(0, "0");
                }
                else if (numeroEntero == 1)
                {
                    resultado = resultado.Insert(0, "1");
                    numeroEntero = 0;
                }
                else
                {
                    resultado = resultado.Insert(0, "1");
                }
                numeroEntero = numeroEntero / 2;
            }

            return resultado;
        }
        /// <summary>
        /// Verifica que un string este compuesto solo por 0 y 1.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private static bool EsBinario(string binario)
        {
            bool isOk = true;
            foreach (char c in binario)
            {
                if(c != '1' && c != '0')
                {
                    isOk = false;
                }
            }
            return isOk;
        }
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// Verifica que los operando sean numeros, caso contrario retorna 0.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private double ValidarOperando(string numero)
        {
            if(double.TryParse(numero, out double numeroDouble))
            {
                return Convert.ToDouble(numeroDouble);
            }
            else
            {
                return 0;
            }
        }
    }
}