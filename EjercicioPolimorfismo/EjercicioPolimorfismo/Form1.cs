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
    }
}
