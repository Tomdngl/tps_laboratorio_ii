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
    public partial class Agregar_Alumno : Form
    {
        public Agregar_Alumno()
        {
            InitializeComponent();
        }
        private void Agregar_Alumno_Load(object sender, EventArgs e)
        {
            cmb_Cursos.DataSource = Enum.GetValues(typeof(Curso));
            cmb_Equipos.Items.Add(Equipo.Rojo);
            cmb_Equipos.Items.Add(Equipo.Verde);
        }

        private void btn_Listo_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_Nombre.Text.SoloCaracteres() && txt_Apellido.Text.SoloCaracteres() && txt_DNI.Text.SoloNumeros() && txt_Legajo.Text.SoloNumeros() && cmb_Cursos.SelectedItem is not null && cmb_Equipos.SelectedItem is not null)
                {
                    Tablon.alumnos.Add(new Alumno(txt_Nombre.Text, txt_Apellido.Text, txt_DNI.Text, Int32.Parse(txt_Legajo.Text), (Curso)cmb_Cursos.SelectedItem, (Equipo)cmb_Equipos.SelectedItem));
                    MessageBox.Show("Alumno agregado con éxito.",
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
