﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Competencia
{
    public partial class FrmArchivos : Form
    {
        private static Competencia<Juego> exportar;
        public FrmArchivos()
        {
            InitializeComponent();
        }

        private void FrmArchivos_Load(object sender, EventArgs e)
        {
            dgv_juegos.DataSource = BaseDeDatos.ObtenerTodos();
            cmb_tipo.Items.Add("Ajedrez");
            cmb_tipo.Items.Add("Carrera");
            cmb_tipo.Items.Add("Quemados");
            cmb_tipo.Items.Add("Todos");
            exportar = new Competencia<Juego>();
        }

        private void btn_ExportarSeleccion_Click(object sender, EventArgs e)
        {
            if (dgv_juegos.SelectedRows.Count > 0)
            {
                Task hiloExportar = Task.Run(Exportar);
            }
            else
            {
                MessageBox.Show("Debe seleccionar por lo menos una columna.", "Error", MessageBoxButtons.OK);
            }
        }

        private void Exportar()
        {
            try
            {
                string pathArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Competencia\";
                pathArchivo += @"Informe " + DateTime.Now.ToString("HH mm ss") + ".json";
                foreach (DataGridViewRow item in dgv_juegos.SelectedRows)
                {
                    Juego juego = (Juego)item.DataBoundItem;
                    exportar.Lista.Add(juego);
                }
                if (Juego.SerializarJson(pathArchivo, exportar.Lista))
                {
                    MessageBox.Show("Se han exportado los datos con éxito en la carpeta 'Competencia' ubicada en el escritorio.", "Exportar.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    exportar.Lista.Clear();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al exportar los datos.", "Error", MessageBoxButtons.OK);
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_tipo.Text)
            {
                case "Ajedrez":
                    List<Ajedrez> ajedrez = BaseDeDatos.ObtenerAjedrez();
                    dgv_juegos.DataSource = ajedrez;

                    break;
                case "Quemados":
                    List<Quemados> quemados = BaseDeDatos.ObtenerQuemados();
                    dgv_juegos.DataSource = quemados;

                    break;
                case "Carrera":
                    List<Carrera> carrera = BaseDeDatos.ObtenerCarrera();
                    dgv_juegos.DataSource = carrera;
                    break;
                case "Todos":
                    List<Juego> juegos = BaseDeDatos.ObtenerTodos();
                    dgv_juegos.DataSource = juegos;
                    break;
            }
        }

        private void btn_ExportarTipo_Click(object sender, EventArgs e)
        {
            dgv_juegos.SelectAll();
            Task hiloExportar = Task.Run(Exportar);
            Task.WaitAll(hiloExportar);
            dgv_juegos.ClearSelection();
        }
        private void btn_Importar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione el archivo a importar.", "Importar.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OpenFileDialog Path = new OpenFileDialog();
            Path.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            Path.FilterIndex = 1;
            Path.Multiselect = false;
            string path;

            if (Path.ShowDialog() == DialogResult.OK)
            {
                path = Path.FileName;          
                dgv_juegos.DataSource = Juego.DeserializarJson(path);
                MessageBox.Show("Se han importado los datos con éxito.", "Importar.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
