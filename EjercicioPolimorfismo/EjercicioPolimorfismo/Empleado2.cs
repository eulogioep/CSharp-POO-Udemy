using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Empleado2
    {
        public int IDEmpleado { get; set; }
        public string Nombre { get; set; }
        public double SalarioEmpleado { get; set; }
        public string PosicionEmpleado { get; set; }

        public virtual string SetValores(int ID, string NombreEmpleado, double Salario)
        {
            IDEmpleado = ID;
            Nombre = NombreEmpleado;
            SalarioEmpleado = Salario;

            string texto = "ID Empleado: " + IDEmpleado + Environment.NewLine;
            texto += "Nombre Empleado: " + Nombre + Environment.NewLine;
            texto += "Salario: " + SalarioEmpleado + Environment.NewLine;

            return texto;
        }


    }
}
