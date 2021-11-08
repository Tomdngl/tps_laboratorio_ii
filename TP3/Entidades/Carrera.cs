using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Carrera))]
    [XmlInclude(typeof(Lanzamiento))]
    public class Carrera : Juego, IJugable
    {
        public Carrera()
        {

        }
        public Carrera(int puntos, Profesor responsable, string identificador) : base(Equipo.Indefinido)
        {
            this.Responsable = responsable;
            this.Identificador = identificador;
            this.puntos = puntos;
            Participantes = new List<Alumno>();
        }

        public override int Puntos
        {
            get
            {
                int puntos = 0;
                foreach (Alumno alumno in Participantes)
                {
                    if (alumno.Equipo == this.Ganador)
                    {
                        puntos = this.puntos + puntos;
                    }
                }
                return puntos;
            }
            set
            {
                puntos = value;
            }
        }
        /// <summary>
        /// Permite definir el equipo ganador de la carrera con los puntos correspondientes
        /// </summary>
        /// <param name="ganador"></param>
        /// <param name="puntos"></param>
        /// <returns></returns>
        public override bool Jugar(Equipo ganador, int puntos)
        {
            if (ganador != Equipo.Indefinido && CheckLista())
            {
                this.Ganador = ganador;
                this.puntos = puntos;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica que en la lista de participantes haya por lo menos uno de cada equipo y que sean pares
        /// </summary>
        /// <returns></returns>
        private bool CheckLista()
        {
            bool hayVerde = false;
            bool hayRojo = false;
            if(this.Participantes.Count >= 2 && this.Participantes.Count % 2 == 0)
            {
                foreach (Alumno alumno in this.Participantes)
                {
                    if(alumno.Equipo == Equipo.Rojo)
                    {
                        hayRojo = true;
                    }
                    else if(alumno.Equipo == Equipo.Verde)
                    {
                        hayVerde = true;
                    }
                    if(hayRojo && hayVerde)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Permite ordenar la lista por equipos
        /// </summary>
        public void OrdenarPorEquipos()
        {
            this.Participantes = this.Participantes.OrderBy(alumno => alumno.Equipo).ToList();
        }

        /// <summary>
        /// Devuelve un string con información sobre la carrera
        /// </summary>
        /// <returns></returns>
        public override string VerResultado()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"En esta carrera participaron:{Environment.NewLine}");
            foreach (Alumno a in Participantes)
            {
                sb.AppendLine(a.ToString());
            }
            sb.AppendLine($"Gano el equipo: {this.Ganador}");
            sb.AppendLine($"Los puntos otorgados por este juego son: {this.Puntos}");

            return sb.ToString();
        }

        /// <summary>
        /// Devuelve el identificador de la carrera.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Identificador}");
            return sb.ToString();
        }
    }
}
