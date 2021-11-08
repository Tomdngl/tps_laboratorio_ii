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

        public int IdColegio { get => idColegio; set => idColegio = value; }
        public Materia Materia { get => materia; set => materia = value; }

        public Profesor()
        {

        }
        public Profesor(string nombre, string apellido, string dni, int idColegio, Materia materia) : base(nombre, apellido, dni)
        {
            this.IdColegio = idColegio;
            this.Materia = materia;
        }

        /// <summary>
        /// Devuelve un string con datos del profesor.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ToString()} Legajo: {this.IdColegio} Materia: {this.Materia}");
            return sb.ToString();
        }
    }
}
