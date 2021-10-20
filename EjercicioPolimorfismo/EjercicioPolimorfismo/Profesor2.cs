using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Profesor2 : Empleado2
    {
        override public string SetValores(int ID, string NombreEmpleado, double Salario)
        {
            IDEmpleado = ID;
            Nombre = NombreEmpleado;
            SalarioEmpleado = Salario;
            PosicionEmpleado = "Profesor";

            string texto = "ID Empleado: " + IDEmpleado + Environment.NewLine;
            texto += "Nombre Empleado: " + Nombre + Environment.NewLine;
            texto += "Salario: " + SalarioEmpleado + Environment.NewLine;
            texto += "Posición: " + PosicionEmpleado + Environment.NewLine;

            return texto;
        }

    }
}
