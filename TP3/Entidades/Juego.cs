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
    public abstract class Juego
    {
        protected Equipo ganador;
        public List<Alumno> participantes;
        protected int puntos;
        protected Profesor responsable;
        protected string identificador;

        public Juego()
        {

        }
        public Juego(Equipo ganador)
        {
            this.Ganador = Equipo.Indefinido;
            this.puntos = 0;
            this.Responsable = null;
        }
        public abstract int Puntos
        {
            get;
            set;
        }

        public List<Alumno> Participantes { get => participantes; set => participantes = value; }
        public Profesor Responsable { get => responsable; set => responsable = value; }
        public Equipo Ganador { get => ganador; set => ganador = value; }
        public string Identificador { get => identificador; set => identificador = value; }

        /// <summary>
        /// Nos permite definir un ganador y los puntos del juego
        /// </summary>
        /// <param name="ganador"></param>
        /// <param name="puntos"></param>
        /// <returns></returns>
        public virtual bool Jugar(Equipo ganador, int puntos)
        {
            if (ganador != Equipo.Indefinido)
            {
                this.Ganador = ganador;
                this.puntos = puntos;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Nos permite elegir aciertos en juegos que lo requieran y puntos por cada uno de estos
        /// </summary>
        /// <param name="aciertosRojo"></param>
        /// <param name="aciertosVerde"></param>
        /// <param name="puntos"></param>
        /// <returns></returns>
        public virtual bool Jugar(int aciertosRojo, int aciertosVerde, int puntos)
        {
            return true;
        }

        public abstract string VerResultado();

        /// <summary>
        /// Operador que nos permite agregar alumnos a un juego
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator +(Juego j, Alumno a)
        {
            if (!j.Participantes.Contains(a))
            {
                j.Participantes.Add(a);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Operador que nos permite remover alumnos de un juego
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator -(Juego j, Alumno a)
        {
            if (j.Participantes.Contains(a))
            {
                j.Participantes.Remove(a);
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