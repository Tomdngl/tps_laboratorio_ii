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
        public List<Alumno> participantes;
        protected int puntos;
        protected Profesor responsable;
        protected string identificador;
        public Juego(Equipo ganador)
        {
            this.ganador = Equipo.Indefinido;
            this.puntos = 0;
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

        public Equipo Ganador
        {
            get
            {
                return this.ganador;
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

        public virtual bool Jugar(int aciertosRojo, int aciertosVerde, int puntos)
        {
            return true;
        }

        public abstract string VerResultado();

        public static bool operator +(Juego j, Alumno a)
        {
            if (!j.participantes.Contains(a))
            {
                j.participantes.Add(a);
                return true;
            }
            return false;
        }

        public static bool operator -(Juego j, Alumno a)
        {
            if (j.participantes.Contains(a))
            {
                j.participantes.Remove(a);
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
    }
}