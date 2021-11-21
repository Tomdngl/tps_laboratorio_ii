using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Juego
    {
        protected int codigo;
        protected Equipo ganador;
        protected int participantesRojos;
        protected int participantesVerdes;
        protected int puntos;
        protected double minutos;
        public Juego()
        {

        }
        public Juego(int codigo, Equipo ganador, int participantesRojos, int participantesVerdes, int puntos, double minutos)
        {
            this.codigo = codigo;
            this.ganador = ganador;
            this.participantesRojos = participantesRojos;
            this.participantesVerdes = participantesVerdes;
            this.puntos = puntos;
            this.minutos = minutos;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public Equipo Ganador { get => ganador; set => ganador = value; }
        public int ParticipantesRojos { get => participantesRojos; set => participantesRojos = value; }
        public int ParticipantesVerdes { get => participantesVerdes; set => participantesVerdes = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public double Minutos { get => minutos; set => minutos = value; }
        public int Participantes { get => this.participantesRojos + this.ParticipantesVerdes; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo: {this.Codigo} Ganador: {this.Ganador} Participantes: {this.Participantes} Puntos: {this.Puntos} Duracion: {this.Minutos} min.");
            return sb.ToString();
        }
    }
}