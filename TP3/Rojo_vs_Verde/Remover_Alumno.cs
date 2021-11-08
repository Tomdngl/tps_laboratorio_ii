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
    public partial class Remover_Alumno : Form
    {
        public Remover_Alumno()
        {
            InitializeComponent();
        }

        private void Remover_Alumno_Load(object sender, EventArgs e)
        {
            foreach (Alumno a in Tablon.alumnos)
            {
                lst_alumnos.Items.Add(a);
            }
        }

        private void lst_alumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Rmv_Click(object sender, EventArgs e)
        {
            try
            {
                Tablon.alumnos.Remove((Alumno)lst_alumnos.SelectedItem);
                lst_alumnos.Items.Remove((Alumno)lst_alumnos.SelectedItem);
            }
            catch (Exception)
            {
                MessageBox.Show("Error.",
                 "Error.",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
