using System;
using System.Collections.Generic;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Tomas", "D'Angelo", "44515454", 111238, Equipo.Verde);
            Alumno alumno2 = new Alumno("Matias", "Gomez", "43514554", 111488, Equipo.Rojo);
            Alumno alumno3 = new Alumno("Jose", "Martinez", "43514551", 111487, Equipo.Verde);
            Alumno alumno4 = new Alumno("Juan", "Saavedra", "43514552", 111486, Equipo.Rojo);
            Alumno alumno5 = new Alumno("Celeste", "Cisternas", "1111111", 111285, Equipo.Verde);

            Profesor profesor = new Profesor("Matias", "Gonzales", "23878650", 125, Materia.EducacionFisica);

            Tablon.profesores.Add(profesor);

            Carrera carrera1 = new Carrera(50, profesor, "Carrera 1");
            Lanzamiento lanzamiento1 = new Lanzamiento(10, profesor, "Lanzamiento 2");

            carrera1.Agregar(alumno1);
            carrera1.Agregar(alumno2);
            carrera1.Agregar(alumno3);
            carrera1.Agregar(alumno4);

            lanzamiento1.Agregar(alumno1);
            lanzamiento1.Agregar(alumno2);

            carrera1.Jugar(Equipo.Rojo, 50);
            carrera1.OrdenarPorEquipos();
            carrera1.AsignarMvp(alumno1);

            lanzamiento1.Jugar(9, 7);

            Console.WriteLine(carrera1);
            Console.WriteLine(lanzamiento1);

            Console.ReadLine();
        }
        //Controlar excepciones:
        //No hay participantes. Participa un solo color en un juego.
    }
}
