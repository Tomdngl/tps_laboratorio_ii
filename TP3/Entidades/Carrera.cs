using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrera : Juego, IJugable
    {
        protected List<Alumno> participantes;
        public Carrera(int puntos, Profesor responsable, string identificador) : base(Equipo.Indefinido, puntos)
        {
            this.mvp = null;
            this.responsable = responsable;
            this.identificador = identificador;
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
        public override Alumno AsignarMvp(Alumno mvp)
        {
            this.mvp = mvp;
            return mvp;
        }

        //Por si hacen trampa, agregar mas tarde
        public Alumno InvalidarAlumno()
        {
            throw new NotImplementedException();
        }
        public static bool operator +(Carrera c, Alumno a)
        {
            if(!c.participantes.Contains(a))
            {
                c.participantes.Add(a);
                return true;
            }
            return false;
        }

        public static bool operator -(Carrera c, Alumno a)
        {
            if (c.participantes.Contains(a))
            {
                c.participantes.Remove(a);
                return true;
            }
            return false;
        }
        public bool Agregar(Alumno alumno)
        {
            return this + alumno;
        }

        public bool Remover(Alumno alumno)
        {
            return this - alumno;
        }
        public void OrdenarPorEquipos()
        {
            this.participantes = this.participantes.OrderBy(alumno => alumno.Equipo).ToList();
        }
        public override string ToString()
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
    }
}
