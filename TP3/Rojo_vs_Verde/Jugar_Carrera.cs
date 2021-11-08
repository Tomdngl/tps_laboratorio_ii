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
    public partial class Jugar_Carrera : Form
    {
        public Jugar_Carrera()
        {
            InitializeComponent();
        }
        private void Jugar_Carrera_Load(object sender, EventArgs e)
        {
            foreach (Alumno a in Jugar.selectedItem.Participantes)
            {
                lst_participantes.Items.Add(a);
            }

            cmb_equipos.Items.Add(Equipo.Rojo);
            cmb_equipos.Items.Add(Equipo.Verde);
        }

        private void btn_Listo_Click(object sender, EventArgs e)
        {
            if (cmb_equipos.SelectedItem != null && txt_puntos.Text != string.Empty && txt_puntos.Text.SoloNumeros())
            {
                try
                {
                    if(Jugar.selectedItem.Jugar((Equipo)cmb_equipos.SelectedItem, Int32.Parse(txt_puntos.Text)))
                    {
                    MessageBox.Show("Datos introducidos correctamente.",
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
                    MessageBox.Show("Se ha producido un error, revise los parametros ingresados.",
                     "Alerta.",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
