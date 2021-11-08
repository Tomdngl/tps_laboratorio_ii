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

        public Alumno()
        {
                
        }

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
            set
            {
                equipo = value;
            }
        }

        public Curso Curso
        {
            get
            {
                return this.curso;
            }
            set
            {
                curso = value;
            }
        }

        public int Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                legajo = value;
            }
        }

        /// <summary>
        /// Devuelve un string con información sobre el alumno.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ToString()} Legajo: {this.legajo} Curso: {this.curso} Equipo: {this.Equipo}");
            return sb.ToString();
        }
    }
}
