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
    public partial class Jugar_Lanzamiento : Form
    {
        public Jugar_Lanzamiento()
        {
            InitializeComponent();
        }

        private void Jugar_Lanzamiento_Load(object sender, EventArgs e)
        {
            foreach (Alumno a in Jugar.selectedItem.Participantes)
            {
                lst_participantes.Items.Add(a);
            }
        }

        private void btn_Listo_Click(object sender, EventArgs e)
        {
            if(txt_AciertosRojo.Text.SoloNumeros() && txt_AciertosRojo.Text.Length > 0 && txt_AciertosVerde.Text.SoloNumeros() && txt_AciertosVerde.Text.Length > 0 && txt_puntos.Text.Length > 0)
            {
                try
                {
                    if(Jugar.selectedItem.Jugar(Int32.Parse(txt_AciertosRojo.Text), Int32.Parse(txt_AciertosVerde.Text), Int32.Parse(txt_puntos.Text)))
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
