using System;
using System.IO;
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
            try
            {
                dataGridViewAlquiler.Rows.Clear();

                string[] lineas = File.ReadAllLines("alquileres.txt");

                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(',');

                    if (campos.Length == 5)
                    {
                        dataGridViewAlquiler.Rows.Add(campos);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos de alquiler: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
