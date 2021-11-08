using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Evento_deportivo
{
    public partial class EventoDeportivo : Form
    {
        public static string applicationData = Application.StartupPath;
        public static string tablonJuegos = Path.Combine(applicationData, "tablonJuegos.xml");
        public static string tablonProfesores = Path.Combine(applicationData, "tablonProfesores.xml");
        public static string tablonAlumnos = Path.Combine(applicationData, "tablonAlumnos.xml");
        public EventoDeportivo()
        {
            InitializeComponent();
        }

        private void EventoDeportivo_Load(object sender, EventArgs e)
        {
            Alumno alumno1 = new Alumno("Tomas", "D'Angelo", "44515454", 111238, Curso.Cuarto_A,Equipo.Verde);
            Alumno alumno2 = new Alumno("Matias", "Gomez", "43514554", 111488, Curso.Cuarto_B, Equipo.Rojo);
            Alumno alumno3 = new Alumno("Jose", "Martinez", "43514551", 111487, Curso.Quinto_A, Equipo.Verde);
            Alumno alumno4 = new Alumno("Juan", "Saavedra", "43514552", 111486, Curso.Tercero_A, Equipo.Rojo);
            Alumno alumno5 = new Alumno("Celeste", "Cisternas", "1111111", 111285, Curso.Cuarto_A, Equipo.Verde);

            Profesor profesor = new Profesor("Matias", "Gonzales", "23878650", 125, Materia.EducacionFisica);
            Profesor profesor1 = new Profesor("Ivan", "Gomez", "23274650", 126, Materia.CienciasNaturales);

            Carrera carrera1 = new Carrera(50, profesor, "Carrera 1");
            Lanzamiento lanzamiento1 = new Lanzamiento(10, profesor, "Lanzamiento 2");

            Tablon.juegos.Add(carrera1);
            Tablon.juegos.Add(lanzamiento1);

            Tablon.profesores.Add(profesor);
            Tablon.profesores.Add(profesor1);

            Tablon.alumnos.Add(alumno1);
            Tablon.alumnos.Add(alumno2);
            Tablon.alumnos.Add(alumno3);
            Tablon.alumnos.Add(alumno4);
            Tablon.alumnos.Add(alumno5);
        }

        private void btn_PrepararJuego_Click(object sender, EventArgs e)
        {
            PrepararJuego prepararJuego = new PrepararJuego();
            prepararJuego.Show();
        }

        private void btn_Jugar_Click(object sender, EventArgs e)
        {
            Jugar jugar = new Jugar();
            jugar.Show();
        }

        private void btn_Personas_Click(object sender, EventArgs e)
        {
            AgregarPersonas agregarPersonas = new AgregarPersonas();
            agregarPersonas.Show();
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            Estadisticas estadisticas = new Estadisticas();
            estadisticas.Show();
        }
    }
}
