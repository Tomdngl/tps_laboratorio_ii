using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        protected int idColegio;
        protected Materia materia;

        public Profesor(string nombre, string apellido, string dni, int idColegio, Materia materia) : base(nombre, apellido, dni)
        {
            this.idColegio = idColegio;
            this.materia = materia;
        }
    }
}
