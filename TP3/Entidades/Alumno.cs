using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        protected int legajo;
        protected Equipo equipo;

        public Alumno(string nombre, string apellido, string dni, int legajo, Equipo equipo):base(nombre, apellido, dni)
        {
            this.legajo = legajo;
            this.equipo = equipo;
        }

        public Equipo Equipo
        {
            get
            {
                return this.equipo;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ToString()} Legajo: {this.legajo} Equipo: {this.Equipo}");
            return sb.ToString();
        }
    }
}
