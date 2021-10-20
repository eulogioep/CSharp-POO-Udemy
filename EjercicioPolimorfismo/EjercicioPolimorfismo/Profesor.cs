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

        public void SetValores (int ID, string NombreEmpleado, double Sueldo, string Posicion)
        {
            IDEmpleado = ID;
            Nombre = NombreEmpleado;
            SalarioEmpleado = Sueldo;
            PosicionEmpleado = Posicion;
        }
        
        public string GetValores()
        {
            string texto = "ID Empleado: " + IDEmpleado + Environment.NewLine;
            texto += "Nombre Empleado: " + Nombre + Environment.NewLine;
            texto += "Salario: " + SalarioEmpleado + Environment.NewLine;
            texto += "Posición Empleado: " + PosicionEmpleado + Environment.NewLine;

            return texto;
        }


    }

}
