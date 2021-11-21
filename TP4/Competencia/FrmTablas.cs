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
    public partial class FrmTablas : Form
    {
        public static string selectedCmb;
        public FrmTablas()
        {
            InitializeComponent();
        }
        private void Tablas_Load(object sender, EventArgs e)
        {
            dgv_juegos.DataSource = BaseDeDatos.ObtenerTodos();
            cmb_tipo.Items.Add("Ajedrez");
            cmb_tipo.Items.Add("Carrera");
            cmb_tipo.Items.Add("Quemados");
        }
        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_tipo.Text)
            {
                case "Ajedrez":
                    List<Ajedrez> ajedrez = BaseDeDatos.ObtenerAjedrez();
                    FrmCompetencia.ajedrez.Lista = ajedrez;
                    dgv_juegos.DataSource = ajedrez;
                    lbl_Puntos.Text = $"Puntos: {FrmCompetencia.ajedrez.PuntosTotales}/{FrmCompetencia.ajedrez.PuntosMax}";
                    Entidades.Competencia<Ajedrez>.VerificarEstado(FrmCompetencia.ajedrez);
                    selectedCmb = cmb_tipo.Text;
                    break;
                case "Quemados":
                    List<Quemados> quemados = BaseDeDatos.ObtenerQuemados();
                    FrmCompetencia.quemados.Lista = quemados;
                    dgv_juegos.DataSource = quemados;
                    lbl_Puntos.Text = $"Puntos: {FrmCompetencia.quemados.PuntosTotales}/{FrmCompetencia.quemados.PuntosMax}";
                    Entidades.Competencia<Quemados>.VerificarEstado(FrmCompetencia.quemados);
                    selectedCmb = cmb_tipo.Text;
                    break;
                case "Carrera":
                    List<Carrera> carrera = BaseDeDatos.ObtenerCarrera();
                    FrmCompetencia.carrera.Lista = carrera;
                    dgv_juegos.DataSource = carrera;
                    lbl_Puntos.Text = $"Puntos: {FrmCompetencia.carrera.PuntosTotales}/{FrmCompetencia.carrera.PuntosMax}";
                    Entidades.Competencia<Carrera>.VerificarEstado(FrmCompetencia.carrera);
                    selectedCmb = cmb_tipo.Text;
                    break;
            }

            lbl_Juego.Text = cmb_tipo.Text;
            lbl_Seleccione.Text = "";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            FrmJuego juego = new FrmJuego();
            try
            {
                if (cmb_tipo.Text != "")
                {
                    DialogResult respuesta = juego.ShowDialog();
                    if (respuesta == DialogResult.OK)
                    {
                        BaseDeDatos.Agregar(juego.Juego, cmb_tipo.Text);
                        cmb_tipo_SelectedIndexChanged(this, e);
                    }
                }
                else
                {
                    throw new ParametrosInvalidosException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }           
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            FrmJuego juego = new FrmJuego();
            try
            {
                if (cmb_tipo.Text != "" && dgv_juegos.SelectedRows.Count == 1)
                {
                    DialogResult respuesta = juego.ShowDialog();
                    if (respuesta == DialogResult.OK)
                    {                           
                            Juego juego1;
                            juego1 = (Juego)dgv_juegos.CurrentRow.DataBoundItem;
                            BaseDeDatos.Modificar(juego.Juego, juego1.Codigo);
                            cmb_tipo_SelectedIndexChanged(this, e);                        
                    }
                }
                else
                {
                    throw new ParametrosInvalidosException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_tipo.Text != "")
                {
                    if (dgv_juegos.SelectedRows.Count == 1)
                    {
                        Juego juego1;
                        juego1 = (Juego)dgv_juegos.CurrentRow.DataBoundItem;
                        BaseDeDatos.Eliminar(juego1);
                        cmb_tipo_SelectedIndexChanged(this, e);
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar solo una columna.", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    throw new ParametrosInvalidosException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
