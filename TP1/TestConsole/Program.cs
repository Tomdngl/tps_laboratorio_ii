using System;
using Entidades;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Operando.BinarioDecimal("101"));
            Console.WriteLine(Operando.DecimalBinario("9999999"));
            Console.ReadLine();
        }
    }
}
