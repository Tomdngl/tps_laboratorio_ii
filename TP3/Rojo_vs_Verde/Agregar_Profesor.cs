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
    public partial class Agregar_Profesor : Form
    {
        public Agregar_Profesor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga datos a la combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Agregar_Profesor_Load(object sender, EventArgs e)
        {
            cmb_Materia.DataSource = Enum.GetValues(typeof(Materia));
        }

        /// <summary>
        /// Verifica que todos los parametros esten y sean correctos y añade el profesor al sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Listo_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_Nombre.Text.SoloCaracteres() && txt_Apellido.Text.SoloCaracteres() && txt_DNI.Text.SoloNumeros() && txt_Legajo.Text.SoloNumeros() && cmb_Materia is not null)
                {
                    Tablon.profesores.Add(new Profesor(txt_Nombre.Text, txt_Apellido.Text, txt_DNI.Text, Int32.Parse(txt_Legajo.Text), (Materia)cmb_Materia.SelectedItem));
                    MessageBox.Show("Profesor agregado con éxito.",
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
