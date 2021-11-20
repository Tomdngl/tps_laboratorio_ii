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
    public partial class Remover_Profesor : Form
    {
        public Remover_Profesor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Carga los profesores existentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remover_Profesor_Load(object sender, EventArgs e)
        {
            foreach (Profesor profesor in Tablon.profesores)
            {
                lst_profesores.Items.Add(profesor);
            }
        }
        /// <summary>
        /// Remueve el profesor seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rmv_Click(object sender, EventArgs e)
        {
            try
            {
                Tablon.profesores.Remove((Profesor)lst_profesores.SelectedItem);
                lst_profesores.Items.Remove((Profesor)lst_profesores.SelectedItem);
            }
            catch (Exception)
            {

            }
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
    }
}
