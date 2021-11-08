using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrera : Juego, IJugable
    {
        public Carrera(int puntos, Profesor responsable, string identificador) : base(Equipo.Indefinido)
        {
            this.responsable = responsable;
            this.identificador = identificador;
            this.puntos = puntos;
            participantes = new List<Alumno>();
        }

        public override int Puntos
        {
            get
            {
                int puntos = 0;
                foreach (Alumno alumno in participantes)
                {
                    if (alumno.Equipo == this.ganador)
                    {
                        puntos = this.puntos + puntos;
                    }
                }
                return puntos;
            }
        }
        public override bool Jugar(Equipo ganador, int puntos)
        {
            if (ganador != Equipo.Indefinido && CheckLista())
            {
                this.ganador = ganador;
                this.puntos = puntos;
                return true;
            }
            return false;
        }

        private bool CheckLista()
        {
            bool hayVerde = false;
            bool hayRojo = false;
            if(this.participantes.Count >= 2 && this.participantes.Count % 2 == 0)
            {
                foreach (Alumno alumno in this.participantes)
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

        public void OrdenarPorEquipos()
        {
            this.participantes = this.participantes.OrderBy(alumno => alumno.Equipo).ToList();
        }

        public override string VerResultado()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"En esta carrera participaron:{Environment.NewLine}");
            foreach (Alumno a in participantes)
            {
                sb.AppendLine(a.ToString());
            }
            sb.AppendLine($"Gano el equipo: {this.ganador}");
            sb.AppendLine($"Los puntos otorgados por este juego son: {this.Puntos}");

            return sb.ToString();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Id}");
            return sb.ToString();
        }
    }
}
