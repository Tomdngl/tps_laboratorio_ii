using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lanzamiento : Juego, IJugable
    {
        private int aciertosGanador;

        public Lanzamiento()
        {
                
        }
        public Lanzamiento(int puntos, Profesor responsable, string identificador) : base(Equipo.Indefinido)
        {
            this.Responsable = responsable;
            this.Identificador = identificador;
            this.puntos = puntos;
            Participantes = new List<Alumno>();
        }
        public override bool Jugar(int aciertosRojo, int aciertosVerde, int puntos)
        {
            if (CheckLista())
            {
                this.puntos = puntos;
                if(aciertosRojo > aciertosVerde)
                {
                    this.Ganador = Equipo.Rojo;
                    this.AciertosGanador = aciertosRojo;
                }
                else if(aciertosVerde > aciertosRojo)
                {
                    this.Ganador = Equipo.Verde;
                    this.AciertosGanador = aciertosVerde;
                }
                else
                {
                    this.Ganador = Equipo.Indefinido;
                    this.puntos = 0;
                }
                return true;
            }
            return false;
        }
        public override int Puntos
        {
            get
            {
                return this.AciertosGanador * puntos;
            }
            set
            {
                puntos = value;
            }
        }

        public int AciertosGanador { get => aciertosGanador; set => aciertosGanador = value; }

        private bool CheckLista()
        {
            bool hayVerde = false;
            bool hayRojo = false;
            if (this.Participantes.Count >= 2 && this.Participantes.Count % 2 == 0)
            {
                foreach (Alumno alumno in this.Participantes)
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
            this.Participantes = this.Participantes.OrderBy(alumno => alumno.Equipo).ToList();
        }

        public override string VerResultado()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"En este lanzamiento participaron:{Environment.NewLine}");
            foreach (Alumno a in Participantes)
            {
                sb.AppendLine(a.ToString());
            }
            sb.AppendLine($"Gano el equipo: {this.Ganador}");
            sb.AppendLine($"Los puntos otorgados por este juego son: {this.Puntos}");

            return sb.ToString();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Identificador}");
            return sb.ToString();
        }
    }
}
