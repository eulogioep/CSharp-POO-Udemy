using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDelegados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Ejemplo de Delegados

        public delegate void fillTextBox(int x);
        string valorTexto = "";

        public void FillMathNote (int notaExamen)
        {
            valorTexto += "Tu nota de Matemáticas es: " + notaExamen + Environment.NewLine;
        }

        public void FillChemistryNote(int notaExamen)
        {
            valorTexto += "Tu nota de Química es: " + notaExamen + Environment.NewLine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void MostrarCajaTexto()
        {
            txtCaja.Text = valorTexto;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            fillTextBox fillText = FillMathNote;
            //Otra forma seria: fillTextBox fillText = FillMathNote(FillMathNote);
            //fillText.Invoke(80);
            fillText += FillChemistryNote;

            fillText(80);

            //fillText -= FillMathNote;
            //fillText(60);
            
            MostrarCajaTexto();
        }
    }
}
