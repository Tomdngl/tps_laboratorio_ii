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
        protected Curso curso;

        public Alumno(string nombre, string apellido, string dni, int legajo, Curso curso,Equipo equipo):base(nombre, apellido, dni)
        {
            this.legajo = legajo;
            this.equipo = equipo;
            this.curso = curso;
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
