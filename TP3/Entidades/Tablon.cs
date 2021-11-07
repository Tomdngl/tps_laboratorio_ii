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

        //Metodos de conteo, filtrado y creacion de estadisticas
    }
}
