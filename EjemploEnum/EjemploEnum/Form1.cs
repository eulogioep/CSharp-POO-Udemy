using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploEnum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Ejemplo de Enumerado. Empiezan con el valor 0 pero podemos asignar otro valor.

        enum colores {rojo = 4 ,azul,blanco,negro,amarillo = 2,morado,marrón,naranja };

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
            string text = "Rojo: " + (int)colores.rojo + Environment.NewLine;
            text += "Azul: " + (int)colores.azul + Environment.NewLine;
            text += "Blanco: " + (int)colores.blanco + Environment.NewLine;
            text += "Negro: " + (int)colores.negro + Environment.NewLine;
            text += "Amarillo: " + (int)colores.amarillo + Environment.NewLine;
            text += "Morado: " + (int)colores.morado + Environment.NewLine;
            text += "Marrón: " + (int)colores.marrón + Environment.NewLine;
            text += "Naranja: " + (int)colores.naranja + Environment.NewLine;

            txtCaja.Text = text;

        }
    }
}
