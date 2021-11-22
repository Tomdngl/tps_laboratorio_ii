using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia<T> where T : Juego
    {
        protected List<T> juegos;
        protected int puntosMax;

        public delegate void Evento(object sender, EventArgs e);
        public event Evento EventoFinalizado;
        public event Evento EventoReporte;

        public Competencia()
        {
            juegos = new List<T>();
        }

        public Competencia(int puntosMax):this()
        {
            this.puntosMax = puntosMax;
        }
        public double DuracionTotal
        {
            get
            {
                double total = 0;
                foreach (Juego item in this.Lista)
                {
                    total += item.Minutos;
                }
                return total;
            }
        }
        public string Ganador
        {
            get
            {
                int puntosRojo = 0;
                int puntosVerde = 0;
                foreach (Juego item in this.Lista)
                {
                    if (item.Ganador == Equipo.Rojo)
                    {
                        puntosRojo += item.Puntos;
                    }
                    else
                    {
                        puntosVerde += item.Puntos;
                    }
                }
                if(puntosRojo > puntosVerde)
                {
                    return "Rojo";
                }
                else if(puntosRojo < puntosVerde)
                {
                    return "Verde";
                }
                else
                {
                    return "Indefinido";
                }
            }
        }
        public int PuntosTotales
        {
            get
            {
                int total = 0;
                foreach (Juego item in this.Lista)
                {
                    total += item.Puntos;
                }
                return total;
            }
        }
        public List<T> Lista { get => juegos; set => juegos = value; }
        public int PuntosMax { get => puntosMax; }
        public static int VictoriasEquipo(List<T> lista, Equipo equipo)
        {
            int victorias = 0;
            foreach (Juego item in lista)
            {
                if (item.Ganador == equipo)
                {
                    victorias += 1;
                }
                else
                {
                }
            }
            return victorias;
        }
        public static void VerificarEstado(Competencia<T> c)
        {
            double total = 0;
            foreach (T item in c.Lista)
            {
                total += item.Puntos;
            }
            if (total >= c.puntosMax)
            {
                if (c.EventoFinalizado != null)
                {
                    c.EventoFinalizado(c, EventArgs.Empty);
                }
            }
            if(c.DuracionTotal >= 360)
            {
                if (c.EventoReporte != null)
                {
                    c.EventoReporte(c, EventArgs.Empty);
                }
            }
        }
        private static bool PuntosExcedidos(Competencia<T> c, T j)
        {
            double total = 0;
            foreach (Juego item in c.Lista)
            {
                total += item.Puntos;
            }
            if (total > c.puntosMax)
            {
                if(c.EventoFinalizado != null)
                {
                    c.EventoFinalizado(c, EventArgs.Empty);
                }
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"La competencia tiene los siguientes juegos:{Environment.NewLine}");
            foreach  (Juego juego in this.Lista)
            {
                sb.AppendLine(juego.ToString());
            }
            return sb.ToString();
        }

        public bool Añadir(T j)
        {
            if(this + j)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator +(Competencia<T> c, T j)
        {
            if (PuntosExcedidos(c, j))
            {
                c.juegos.Add(j);
            }
            else
            {
                throw new PuntosExcedidosException();                
            }
            if (c.DuracionTotal >= 360 && c.EventoReporte != null)
            {
                    c.EventoReporte(c, EventArgs.Empty);
            }
            return true;
        }
    }
}
