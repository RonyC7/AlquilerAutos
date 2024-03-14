using System;
using System.Data;
using System.Windows.Forms;

namespace AlquilerAutos
{
    public partial class FormMostrarAlqui : Form
    {
        public FormMostrarAlqui()
        {
            InitializeComponent();
            CargarDatosAlquiler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
        }

        private void CargarDatosAlquiler()
        {
            // Aquí cargarías los datos de alquiler desde algún lugar y los mostrarías en el DataGridView
            // Por ahora, solo se muestra un mensaje
            MessageBox.Show("Cargar datos de alquiler desde algún lugar y mostrarlos en el DataGridView.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
