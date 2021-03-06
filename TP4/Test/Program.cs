using System;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia<Juego> juegos = new Competencia<Juego>(1000);            
            Ajedrez ajedrez = new Ajedrez(112, Equipo.Verde, 1, 1, 950, 60);
            Carrera carrera = new Carrera(113, Equipo.Verde, 7, 6, 500, 600);
            Quemados quemado = new Quemados(111, Equipo.Rojo, 12, 12, 2000, 500);
            juegos.EventoReporte += ManejadorEDuracion;

                juegos.Añadir(carrera);
                juegos.Añadir(ajedrez);
            try
            {
                juegos.Añadir(quemado);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            juegos.Lista = BaseDeDatos.ObtenerTodos();

            void ManejadorEDuracion(object sender, EventArgs e)
            {
                Console.WriteLine("Se ha disparado el evento porque la duracion de los juegos supera los 360 min.");
            }

            Console.WriteLine(juegos);

            Console.Read();
        }
    }
}
