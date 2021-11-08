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
    public partial class AddRmvAlumno : Form
    {
        public AddRmvAlumno()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga datos a la lista de alumnos y participantes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRmvAlumno_Load(object sender, EventArgs e)
        {
            foreach (Alumno a in Tablon.alumnos)
            {
                lst_alumnos.Items.Add(a);
            }

            foreach (Alumno a in Jugar.selectedItem.Participantes)
            {
                lst_participantes.Items.Add(a);
            }
        }

        /// <summary>
        /// Agrega un alumno al juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if(Jugar.selectedItem is not null)
                {
                Jugar.selectedItem.Agregar((Alumno)lst_alumnos.SelectedItem);
                lst_participantes.Items.Add((Alumno)lst_alumnos.SelectedItem);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha producido un error, seleccione un alumno.",
                 "Alerta.",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Elimina un alumno del juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rmv_Click(object sender, EventArgs e)
        {
            Jugar.selectedItem.Remover((Alumno)lst_alumnos.SelectedItem);
            lst_participantes.Items.Remove((Alumno)lst_alumnos.SelectedItem);
        }

        /// <summary>
        /// Cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lst_alumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
