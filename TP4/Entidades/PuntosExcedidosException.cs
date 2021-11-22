using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuntosExcedidosException : Exception
    {
        public override string Message => "No se puede agregar el juego porque excede los puntos permitidos.";
    }
}
