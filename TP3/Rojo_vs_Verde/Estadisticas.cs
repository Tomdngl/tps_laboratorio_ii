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

        /// <summary>
        /// Guarda las listas del tablon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Carga las listas guardadas en archivos xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Filtra la lista de juegos y guarda un archivo con las victorias del equipo rojo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_VictoriasRojo_Click(object sender, EventArgs e)
        {
            try
            {
                List<Juego> victoriasRojo = new List<Juego>();
                Tablon.FiltrarRojo(victoriasRojo);
                string fecha = DateTime.Now.ToString("MMMM dd HH-mm-ss");
                string ruta = Path.Combine(EventoDeportivo.applicationData, $"{fecha}.xml");
                Archivos.SerializarAXml<List<Juego>>(ruta, Tablon.juegos);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error.",
                 "Notificación.",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Filtra la lista de juegos y guarda un archivo con las victorias del equipo verde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_VictoriasVerde_Click(object sender, EventArgs e)
        {
            try
            {
                List<Juego> victoriasVerde = new List<Juego>();
                Tablon.FiltrarVerde(victoriasVerde);
                string fecha = DateTime.Now.ToString("MMMM dd HH-mm-ss");
                string ruta = Path.Combine(EventoDeportivo.applicationData, $"{fecha}.xml");
                Archivos.SerializarAXml<List<Juego>>(ruta, Tablon.juegos);
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
