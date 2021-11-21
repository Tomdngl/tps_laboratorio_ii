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

namespace Competencia
{
    public partial class FrmJuego : Form
    {
        private Juego juego;

        public Juego Juego
        {
            get { return this.juego; }
        }
        public FrmJuego()
        {
            InitializeComponent();
        }

        private void FrmJuego_Load(object sender, EventArgs e)
        {
            cmb_equipos.Items.Add(Equipo.Rojo);
            cmb_equipos.Items.Add(Equipo.Verde);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_Rojos.Text.SoloNumeros() && txt_Verdes.Text.SoloNumeros() && txt_Puntos.Text.SoloNumeros() && txt_Duracion.Text.SoloNumeros() && cmb_equipos.Text != "")
                {
                    this.juego = new Juego(0, (Equipo)cmb_equipos.SelectedItem,Convert.ToInt32(txt_Rojos.Text), Convert.ToInt32(txt_Verdes.Text), Convert.ToInt32(txt_Puntos.Text), Convert.ToDouble(txt_Duracion.Text));
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    throw new ParametrosInvalidosException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
