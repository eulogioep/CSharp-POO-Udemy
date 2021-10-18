namespace Encapsulacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Empleado empleadoDetalle = new Empleado();
            empleadoDetalle.EmpleadoNombre = txtNombreEmpleado.Text;
            empleadoDetalle.EmpleadoEdad = Convert.ToInt32(txtEdadEmpleado.Text);
            empleadoDetalle.EmpleadoPosicion = txtPosicionEmpleado.Text;
            FrmDetalleEmpleado frm = new FrmDetalleEmpleado();

            frm.label2.Text = empleadoDetalle.EmpleadoNombre;
            frm.label3.Text = empleadoDetalle.EmpleadoEdad.ToString();
            frm.label4.Text = empleadoDetalle.EmpleadoPosicion;

            frm.ShowDialog();
        }

    }
}