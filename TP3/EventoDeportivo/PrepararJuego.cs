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

        private void PrepararJuego_Load(object sender, EventArgs e)
        {
            cmb_Juego.Items.Add("Carrera");
            cmb_Juego.Items.Add("Lanzamiento");
            foreach (Profesor p in Tablon.profesores)
            {
                cmb_Profesor.Items.Add(p);
            }
        }

        private void cmb_Juego_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Profesor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Listo_Click(object sender, EventArgs e)
        {
            if(cmb_Juego.Text == "Carrera" && cmb_Profesor.SelectedItem != null)
            {
                Tablon.juegos.Add(new Carrera(50, (Profesor)cmb_Profesor.SelectedItem, txt_Identificador.Text));
                MessageBox.Show("Se ha añadido una carrera.",
                                 "Notificacion.",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            else if(cmb_Juego.Text == "Lanzamiento" && cmb_Profesor.SelectedItem != null)
            {
                Tablon.juegos.Add(new Lanzamiento(10, (Profesor)cmb_Profesor.SelectedItem, txt_Identificador.Text));
                MessageBox.Show("Se ha añadido un lanzamiento.",
                                 "Notificacion.",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
        }
        private void txt_Identificador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
