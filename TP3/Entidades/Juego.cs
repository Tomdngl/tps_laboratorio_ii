using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Juego
    {
        protected Equipo ganador;
        protected int puntos;
        protected Profesor responsable;
        protected Alumno mvp;
        protected string identificador;
        public Juego(Equipo ganador, int puntos)
        {
            this.ganador = Equipo.Indefinido;
            this.puntos = puntos;
            this.responsable = null;
        }
        public abstract int Puntos
        {
            get;
        }

        public string Id
        {
            get
            {
                return this.identificador;
            }
        }
        public virtual bool Jugar(Equipo ganador, int puntos)
        {
            if (ganador != Equipo.Indefinido)
            {
                this.ganador = ganador;
                this.puntos = puntos;
                return true;
            }
            return false;
        }
        public virtual Alumno AsignarMvp(Alumno mvp)
        {
            this.mvp = mvp;
            return mvp;
        }
    }
}