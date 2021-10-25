using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploPartialClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Las Clases parciales pueden crearse en varias partes

        public partial class Empleado
        {
            public int EmpleadoID { get; set; }
            public string Nombre { get; set; }
            public double Salario { get; set; }
        }

        public partial class Empleado
        {
            public void SetValues()
            {
                Nombre = "Eulogio";
                EmpleadoID = 1;
                Salario = 5000;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public sealed class ClaseSellada
        {

        }

        // Las Clases selladas no pueden ser heredadas
        //
        //public class NuevaClase : ClaseSellada
        //{

        //}

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.SetValues();
            txtCaja.Text += emp.EmpleadoID + Environment.NewLine;
            txtCaja.Text += emp.Nombre + Environment.NewLine;
            txtCaja.Text += emp.Salario + Environment.NewLine;
        }
    }
}
