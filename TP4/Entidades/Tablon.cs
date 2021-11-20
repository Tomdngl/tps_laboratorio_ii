using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static public class Tablon
    {
        static public List<Juego> juegos;
        static public List<Profesor> profesores;
        static public List<Alumno> alumnos;

        static Tablon()
        {
            juegos = new List<Juego>();
            profesores = new List<Profesor>();
            alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Filtra una sublista con los juegos que gano el equipo rojo
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static List<Juego> FiltrarRojo(List<Juego> lista)
        {
            foreach (Juego j in Tablon.juegos)
            {
                if(j.Ganador == Equipo.Rojo)
                {
                    lista.Add(j);
                }
            }
            return lista;
        }

        /// <summary>
        /// Filtra una sublista con los juegos que gano el equipo verde
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static List<Juego> FiltrarVerde(List<Juego> lista)
        {
            foreach (Juego j in Tablon.juegos)
            {
                if (j.Ganador == Equipo.Verde)
                {
                    lista.Add(j);
                }
            }
            return lista;
        }
    }
}
