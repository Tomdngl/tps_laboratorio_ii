using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IJugable
    {
        bool Agregar(Alumno alumno);
        bool Remover(Alumno alumno);
        void OrdenarPorEquipos();
    }
}
