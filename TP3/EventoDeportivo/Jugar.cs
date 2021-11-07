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
    public partial class Jugar : Form
    {
        public Jugar()
        {
            InitializeComponent();
        }

        private void Jugar_Load(object sender, EventArgs e)
        {
            foreach (Juego juego in Tablon.juegos)
            {
                lst_Juegos.Items.Add(juego.Id);
            }
        }
        private void lst_Juegos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
