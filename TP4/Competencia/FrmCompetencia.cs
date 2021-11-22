using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Competencia
{
    public partial class FrmCompetencia : Form
    {
        static public Competencia<Carrera> carrera;
        static public Competencia<Quemados> quemados;
        static public Competencia<Ajedrez> ajedrez;

        public FrmCompetencia()
        {
            InitializeComponent();
        }

        private void EventoDeportivo_Load(object sender, EventArgs e)
        {
            string pathArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Competencia\";
            if (!Directory.Exists(pathArchivo))
            {
                Directory.CreateDirectory(pathArchivo);
            }

            carrera = new Competencia<Carrera>(1000);
            quemados = new Competencia<Quemados>(2000);
            ajedrez = new Competencia<Ajedrez>(800);
           
            Resultados<Juego> resultados = new Resultados<Juego>();
            carrera.EventoFinalizado += Competencia_EventoFinalizado;
            quemados.EventoFinalizado += Competencia_EventoFinalizado;
            ajedrez.EventoFinalizado += Competencia_EventoFinalizado;
            carrera.EventoReporte += Competencia_EventoReporte;
            quemados.EventoReporte += Competencia_EventoReporte;
            ajedrez.EventoReporte += Competencia_EventoReporte;

            Actualizar_Listas();
        }

       

        private void Competencia_EventoFinalizado(object sender, EventArgs e)
        {
            string tipo = sender.GetType().ToString();
            switch (tipo)
            {
                case "Entidades.Competencia`1[Entidades.Carrera]":
                Resultados<Carrera>.ImprimirResultados(sender, "Carrera");
                    break;
                case "Entidades.Competencia`1[Entidades.Quemados]":
                Resultados<Quemados>.ImprimirResultados(sender, "Quemados");
                    break;
                case "Entidades.Competencia`1[Entidades.Ajedrez]":
                Resultados<Ajedrez>.ImprimirResultados(sender, "Ajedrez");
                    break;
                default:
                    break;
            }
        }
        private void Competencia_EventoReporte(object sender, EventArgs e)
        {
            string tipo = sender.GetType().ToString();
            switch (tipo)
            {
                case "Entidades.Competencia`1[Entidades.Carrera]":
                    Resultados<Carrera>.ImprimirReporte(sender, "Carrera");
                    break;
                case "Entidades.Competencia`1[Entidades.Quemados]":
                    Resultados<Quemados>.ImprimirReporte(sender, "Quemados");
                    break;
                case "Entidades.Competencia`1[Entidades.Ajedrez]":
                    Resultados<Ajedrez>.ImprimirReporte(sender, "Ajedrez");
                    break;
                default:
                    break;
            }
        }

        public static void Actualizar_Listas()
        {
            try
            {
                ajedrez.Lista = BaseDeDatos.ObtenerAjedrez();
                quemados.Lista = BaseDeDatos.ObtenerQuemados();
                carrera.Lista = BaseDeDatos.ObtenerCarrera();
                Competencia<Ajedrez>.VerificarEstado(ajedrez);
                Competencia<Quemados>.VerificarEstado(quemados);
                Competencia<Carrera>.VerificarEstado(carrera);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
            frmEstadisticas.Show();
        }

        private void btn_Tablas_Click(object sender, EventArgs e)
        {
            FrmTablas tablas = new FrmTablas();
            tablas.Show();
        }

        private void btn_Archivos_Click(object sender, EventArgs e)
        {
            FrmArchivos archivos = new FrmArchivos();
            archivos.Show();
        }
    }
}
