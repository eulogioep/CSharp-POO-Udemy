using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploClasesAbstractas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        abstract class Vehiculo
        {
            public abstract double GetCantidadCombustible();
        }

        class Autobus : Vehiculo
        {
            public override double GetCantidadCombustible()
            {
                return 300;
            }
        }

        class Camion : Vehiculo
        {
            public override double GetCantidadCombustible()
            {
                return 500;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string texto = "";

            //Al ser una clase abstracta no se puede instanciar
            Vehiculo vc;

            //Se asigna al objeto vc una instancia de Autobus que hereda de la Clase Abstracta Vehículo
            vc = new Autobus();

            double combustibleBus = vc.GetCantidadCombustible();

            texto += "La Cantidad de Combustible del Autobus es: " + combustibleBus.ToString() + Environment.NewLine;

            vc = new Camion();

            double combustibleCamion = vc.GetCantidadCombustible();

            texto += "La Cantidad de Combustible del Camión es: " + combustibleCamion.ToString() + Environment.NewLine;

            txtBox.Text = texto;
        }
    }
}
