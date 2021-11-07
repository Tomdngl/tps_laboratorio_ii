using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lanzamiento : Juego, IJugable
    {
        protected int aciertosGanador;
        public Lanzamiento(int puntos, Profesor responsable, string identificador) : base(Equipo.Indefinido)
        {
            this.responsable = responsable;
            this.identificador = identificador;
            participantes = new List<Alumno>();
        }
        public bool Jugar(int aciertosRojo, int aciertosVerde)
        {
            if (CheckLista())
            {
                if(aciertosRojo > aciertosVerde)
                {
                    this.ganador = Equipo.Rojo;
                    this.aciertosGanador = aciertosRojo;
                }
                else if(aciertosVerde > aciertosRojo)
                {
                    this.ganador = Equipo.Verde;
                    this.aciertosGanador = aciertosVerde;
                }
                else
                {
                    this.ganador = Equipo.Indefinido;
                }
                return true;
            }
            return false;
        }
        public override int Puntos
        {
            get
            {
                return this.aciertosGanador * puntos;
            }
        }

        private bool CheckLista()
        {
            bool hayVerde = false;
            bool hayRojo = false;
            if (this.participantes.Count >= 2 && this.participantes.Count % 2 == 0)
            {
                foreach (Alumno alumno in this.participantes)
                {
                    if (alumno.Equipo == Equipo.Rojo)
                    {
                        hayRojo = true;
                    }
                    else if (alumno.Equipo == Equipo.Verde)
                    {
                        hayVerde = true;
                    }
                    if (hayRojo && hayVerde)
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
            sb.Append($"En este lanzamiento participaron:{Environment.NewLine}");
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
