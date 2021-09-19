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

        public static string BinarioDecimal(string binario)
        {
            string result = "Valor inválido";

            if(EsBinario(binario))
            {
                int numero = 0;
                int digito;

                for (long i = int.Parse(binario), j = 0; i > 0; i /= 10, j++)
                {
                    digito = (int)i % 10;
                    numero += digito * (int)Math.Pow(2, j);
                }

                result = numero.ToString();
            }

            return result;
        }

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

        //RESTRINGIR A ENTEROS POSITIVOS EN AMBAS CONVERSIONES quedándose para esto con el valor absoluto y entero del
        //double recibido:
        public static string DecimalBinario(double numero)
        {
            string resultado = "";
            int numeroEntero = Convert.ToInt32(numero);
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
        private double ValidarOperando(string numero)
        {
            return Convert.ToDouble(numero);
        }

    }
}