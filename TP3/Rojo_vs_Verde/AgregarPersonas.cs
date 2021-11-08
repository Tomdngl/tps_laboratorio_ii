﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evento_deportivo
{
    public partial class AgregarPersonas : Form
    {
        public AgregarPersonas()
        {
            InitializeComponent();
        }

        private void btn_AgregarAlumno_Click(object sender, EventArgs e)
        {
            Agregar_Alumno agregar_Alumno = new Agregar_Alumno();
            agregar_Alumno.Show();
        }

        private void btn_AgregarProfesor_Click(object sender, EventArgs e)
        {
            Agregar_Profesor agregar_Profesor = new Agregar_Profesor();
            agregar_Profesor.Show();
        }

        private void btn_RemoverAlumno_Click(object sender, EventArgs e)
        {
            Remover_Alumno remover_Alumno = new Remover_Alumno();
            remover_Alumno.Show();
        }

        private void btn_RemoverProfesor_Click(object sender, EventArgs e)
        {
            Remover_Profesor remover_Profesor = new Remover_Profesor();
            remover_Profesor.Show();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
