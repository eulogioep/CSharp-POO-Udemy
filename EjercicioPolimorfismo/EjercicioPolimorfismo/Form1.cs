using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPolimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Profesor profesor1 = new Profesor();
            profesor1.SetValores(1);
            string textoMensaje = profesor1.GetValores();

            txtBox.Text = textoMensaje;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profesor profesor1 = new Profesor();
            profesor1.SetValores(1, "Juan Antonio");
            string textoMensaje = profesor1.GetValores();

            txtBox.Text = textoMensaje;
        }

        private void btnInfo3_Click(object sender, EventArgs e)
        {
            Profesor profesor1 = new Profesor();
            profesor1.SetValores(1, "Juan Antonio", 2000);
            string textoMensaje = profesor1.GetValores();

            txtBox.Text = textoMensaje;
        }

        private void btnInfo4_Click(object sender, EventArgs e)
        {
            Profesor profesor1 = new Profesor();
            profesor1.SetValores(1, "Juan Antonio", 2000, "Profesor");
            string textoMensaje = profesor1.GetValores();

            txtBox.Text = textoMensaje;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Empleado2 empleado2 = new Empleado2();
            string textoMensaje = empleado2.SetValores(1, "Juan Antonio", 2000);
            

            txtBox.Text = textoMensaje;
        }

        private void btnOverride_Click(object sender, EventArgs e)
        {
            Profesor2 profesor2 = new Profesor2();
            string textoMensaje = profesor2.SetValores(1, "Juan Antonio", 2000);


            txtBox.Text = textoMensaje;
        }
    }
}
