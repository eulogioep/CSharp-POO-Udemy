using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Profesor : Empleado
    {

        public string PosicionEmpleado { get; set; }
        
        public string GetValores()
        {
            string texto = "ID Empleado: " + IDEmpleado + Environment.NewLine;
            texto += "Nombre Empleado: " + NombreEmpleado + Environment.NewLine;
            texto += "Salario: " + SalarioEmpleado + Environment.NewLine;
            texto += "Posición Empleado: " + PosicionEmpleado + Environment.NewLine;

            return texto;
        }


    }

}
