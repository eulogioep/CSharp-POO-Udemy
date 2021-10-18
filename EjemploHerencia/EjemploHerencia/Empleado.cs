using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    internal class Empleado : Humano
    {
        protected string Puesto { get; set; }

        public double Sueldo { get; set; }

        public void SetValores()
        {
            Nombre = "Eulogio";
            ID = 1;
            Genero = 'M';
            Edad = 40;
        }
    }
}
