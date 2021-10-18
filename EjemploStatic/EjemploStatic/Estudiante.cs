using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploStatic
{
    internal class Estudiante
    {
        public static int EstudianteNumero { get; set; }

        public static void getAddNote()
        {
            MessageBox.Show("Static");
        }
    }
}
