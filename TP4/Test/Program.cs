using System;
using Entidades;

namespace Test
{
    class Program
    {

        static void Main(string[] args)
        {
             Quemados quemado = new Quemados(111, Equipo.Rojo, 12, 12, 200, 52.54);
             Ajedrez ajedrez = new Ajedrez(112, Equipo.Verde, 1, 1, 50, 60);
             Carrera carrera = new Carrera(113, Equipo.Verde, 7, 6, 50, 60);

            Console.WriteLine(quemado);
            Console.WriteLine(ajedrez);
            Console.WriteLine(carrera);

            Console.Read();
        }
    }
}
