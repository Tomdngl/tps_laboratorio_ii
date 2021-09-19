using System;
using Entidades;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Operando.BinarioDecimal("1010"));
            Console.WriteLine(Operando.DecimalBinario("5"));
            Operando op1 = new Operando(5.5);
            Operando op2 = new Operando(5);

            double result = Calculadora.Operar(op1, op2, '*');
            Console.WriteLine("El resultado es {0}", result);
            Console.ReadLine();
        }
    }
}
