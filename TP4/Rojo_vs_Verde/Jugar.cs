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
        public static Juego selectedItem;
        public Jugar()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Carga los juegos a la listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Jugar_Load(object sender, EventArgs e)
        {
            foreach (Juego juego in Tablon.juegos)
            {
                lst_Juegos.Items.Add(juego);
            }
        }
        private void lst_Juegos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Abre el form para añadir/remover participantes del juego seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddRmv_Click(object sender, EventArgs e)
        {
            try
            {
                selectedItem = (Juego)lst_Juegos.SelectedItem;  
                if(selectedItem is not null)
                {
                    AddRmvAlumno addRmvAlumno = new AddRmvAlumno();
                    addRmvAlumno.Show();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay ningun juego cargado.",
                "Notificación.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            
        }
        /// <summary>
        /// Permite cargar los resultados del juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cargarResultado_Click(object sender, EventArgs e)
        {
            selectedItem = (Juego)lst_Juegos.SelectedItem;
            if ((Juego)lst_Juegos.SelectedItem is Carrera)
            {
                Jugar_Carrera jugar_Carrera = new Jugar_Carrera();
                jugar_Carrera.Show();
            }
            else if((Juego)lst_Juegos.SelectedItem is Lanzamiento)
            {
                Jugar_Lanzamiento jugar_Lanzamiento = new Jugar_Lanzamiento();
                jugar_Lanzamiento.Show();
            }
            else
            {
                MessageBox.Show("No hay ningun juego seleccionado.",
                 "Notificacion.",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Muestra resultados del juego seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_verResultado_Click(object sender, EventArgs e)
        {
            try
            {
                selectedItem = (Juego)lst_Juegos.SelectedItem;
                MessageBox.Show(selectedItem.VerResultado(),
                 "Datos.",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("No hay ningun juego cargado.",
                 "Notificacion.",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Elimina un juego del sistema tras una confirmacion previa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            selectedItem = (Juego)lst_Juegos.SelectedItem;
            if (lst_Juegos.SelectedItem is not null)
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro? Esta accion es permanente y no puede deshacerse.", "Alerta", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        Tablon.juegos.Remove(selectedItem);
                        lst_Juegos.Items.Remove(selectedItem);
                        MessageBox.Show("Objeto eliminado con exito.",
                         "Notificación.",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error. Esta operación no es válida.",
                         "Notificación.",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ningun juego seleccionado.",
                 "Notificación.",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
