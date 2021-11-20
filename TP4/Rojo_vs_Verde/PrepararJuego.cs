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
    public partial class PrepararJuego : Form
    {
        public PrepararJuego()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Añade elementos a la combobox y carga la lista de profesores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrepararJuego_Load(object sender, EventArgs e)
        {
            cmb_Juego.Items.Add("Carrera");
            cmb_Juego.Items.Add("Lanzamiento");
            foreach (Profesor p in Tablon.profesores)
            {
                lst_profesores.Items.Add(p);
            }
        }

        private void cmb_Juego_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Crea el nuevo juego si los parametros son correctos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Listo_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmb_Juego.Text == "Carrera" && lst_profesores.SelectedItem != null && txt_Identificador.Text.Length > 0)
                {
                    Tablon.juegos.Add(new Carrera(50, (Profesor)lst_profesores.SelectedItem, txt_Identificador.Text));
                    MessageBox.Show("Se ha añadido una carrera.",
                                     "Notificacion.",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }
                else if(cmb_Juego.Text == "Lanzamiento" && lst_profesores.SelectedItem != null)
                {
                    Tablon.juegos.Add(new Lanzamiento(10, (Profesor)lst_profesores.SelectedItem, txt_Identificador.Text));
                    MessageBox.Show("Se ha añadido un lanzamiento.",
                                     "Notificacion.",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, revise los parámetros.",
                 "Error.",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }
        private void txt_Identificador_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
