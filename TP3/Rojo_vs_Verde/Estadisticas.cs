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
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }
        private void Estadisticas_Load(object sender, EventArgs e)
        {

        }

        private void btn_GuardarTablon_Click(object sender, EventArgs e)
        {
            Archivos.SerializarAXml<List<Juego>>(EventoDeportivo.tablonJuegos, Tablon.juegos);
            Archivos.SerializarAXml(EventoDeportivo.tablonProfesores, Tablon.profesores);
            Archivos.SerializarAXml<List<Alumno>>(EventoDeportivo.tablonAlumnos, Tablon.alumnos);

            MessageBox.Show("Datos guardados.",
             "Notificación.",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information);
        }

        private void btn_CargarTablon_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Estas seguro? Los datos actuales se sobreescribiran.", "Alerta", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    Tablon.juegos.Clear();
                    Tablon.profesores.Clear();
                    Tablon.alumnos.Clear();

                    Tablon.juegos = Archivos.DeserializarDesdeXml<List<Juego>>(EventoDeportivo.tablonJuegos);
                    Tablon.profesores = Archivos.DeserializarDesdeXml<List<Profesor>>(EventoDeportivo.tablonProfesores);
                    Tablon.alumnos = Archivos.DeserializarDesdeXml<List<Alumno>>(EventoDeportivo.tablonAlumnos);

                    MessageBox.Show("Datos cargados con exito.",
                     "Notificación.",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error.",
                     "Notificación.",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                }
            }
        }
    }
}
