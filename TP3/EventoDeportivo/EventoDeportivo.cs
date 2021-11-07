using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Evento_deportivo
{
    public partial class EventoDeportivo : Form
    {
        public EventoDeportivo()
        {
            InitializeComponent();
        }

        private void EventoDeportivo_Load(object sender, EventArgs e)
        {
            Alumno alumno1 = new Alumno("Tomas", "D'Angelo", "44515454", 111238, Equipo.Verde);
            Alumno alumno2 = new Alumno("Matias", "Gomez", "43514554", 111488, Equipo.Rojo);
            Alumno alumno3 = new Alumno("Jose", "Martinez", "43514551", 111487, Equipo.Verde);
            Alumno alumno4 = new Alumno("Juan", "Saavedra", "43514552", 111486, Equipo.Rojo);
            Alumno alumno5 = new Alumno("Celeste", "Cisternas", "1111111", 111285, Equipo.Verde);

            Profesor profesor = new Profesor("Matias", "Gonzales", "23878650", 125, Materia.EducacionFisica);
            Profesor profesor1 = new Profesor("Ivan", "Gomez", "23274650", 126, Materia.CienciasNaturales);

            Tablon.profesores.Add(profesor);
            Tablon.profesores.Add(profesor1);

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
    }
}
