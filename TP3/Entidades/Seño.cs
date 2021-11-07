using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Seño : Persona
    {
        protected int idColegio;

        public Seño(string nombre, string apellido, string dni, int idColegio) : base(nombre, apellido, dni)
        {
            this.idColegio = idColegio;
        }
    }
}
