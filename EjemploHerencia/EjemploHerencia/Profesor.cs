using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    internal class Profesor : Empleado
    {
        public string Especialidad { get; set; }

        public void AsignaSalario() 
        {
            Sueldo = 2000;
        }

        public void SetValores2()
        {
            Puesto = "Profesor";

            Especialidad = "Matemáticas";
        }
    }
}
