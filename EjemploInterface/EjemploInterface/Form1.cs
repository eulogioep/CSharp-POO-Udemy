using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        interface Ordenador
        {
            void GetEscritorio();
            void GetPortatil();
        }

        interface DellComputer
        {
            void GetMark();
        }

        class OrdenadoresDell : Ordenador, DellComputer
        {
            public string Nombre { get; set; }
            public double Precio { get; set; }
            public string Mark { get; set; }

            public void GetEscritorio()
            {
                Nombre = "Escritorio1";
                Precio = 2000;
            }

            public void GetPortatil()
            {
                Nombre = "Portátil1";
                Precio = 1500;
            }

            public void GetMark()
            {
                Mark = "Dell";
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMuestra_Click(object sender, EventArgs e)
        {
            OrdenadoresDell dell = new OrdenadoresDell();
            dell.GetPortatil();
            dell.GetMark();
            string valorTexto = "Nombre: " + dell.Nombre + Environment.NewLine;
            valorTexto += "Precio: " + dell.Precio + Environment.NewLine;
            valorTexto += "Marca: " + dell.Mark + Environment.NewLine;
            txtBox.Text = valorTexto;
        }
    }
}
