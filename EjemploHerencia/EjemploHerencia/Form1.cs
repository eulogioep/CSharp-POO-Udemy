using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploHerencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            Profesor profe = new Profesor();

            profe.SetValores();
            profe.SetValores2();
            profe.AsignaSalario();

            string todosLosValores = "";

            todosLosValores += profe.Nombre + Environment.NewLine;
            todosLosValores += profe.Genero + Environment.NewLine;
            todosLosValores += profe.Edad + Environment.NewLine;
            todosLosValores += profe.Especialidad + Environment.NewLine;
            todosLosValores += profe.Sueldo + Environment.NewLine;

            txtBox.Text = todosLosValores;


        }
    }
}
