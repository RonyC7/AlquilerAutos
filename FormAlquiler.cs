using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AlquilerAutos
{
    public partial class FormAlquiler : Form
    {
        public FormAlquiler()
        {
            InitializeComponent();
            CargarDatosNit();
            comboBoxNit.SelectedIndexChanged += comboBoxNit_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
        }

        private void buttonGuardarAlqui_Click(object sender, EventArgs e)
        {
            GuardarAlquiler();
        }

        private void CargarDatosNit()
        {
            comboBoxNit.Items.Clear();
            foreach (string nit in RepositorioDatos.ClientesVehiculosAlquilados.Keys)
            {
                comboBoxNit.Items.Add(nit);
            }
        }

        private void comboBoxNit_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPlaca.Items.Clear();
            string nitSeleccionado = comboBoxNit.SelectedItem as string;

            if (!string.IsNullOrEmpty(nitSeleccionado) && RepositorioDatos.ClientesVehiculosAlquilados.ContainsKey(nitSeleccionado))
            {
                List<string> placas = RepositorioDatos.ClientesVehiculosAlquilados[nitSeleccionado];
                foreach (string placa in placas)
                {
                    comboBoxPlaca.Items.Add(placa);
                }
            }
            comboBoxPlaca.Refresh();
        }

        private void GuardarAlquiler()
        {
            string nit = comboBoxNit.SelectedItem as string;
            string placa = comboBoxPlaca.SelectedItem as string;
            DateTime fechaAlquiler = dateTimePickerAlquiler.Value;
            DateTime fechaDevolucion = dateTimePickerDevolucion.Value;
            int kilometrosRecorridos = int.Parse(textBoxKilometroReco.Text);

            decimal precioPorKilometro = ObtenerPrecioPorKilometro(placa);
            decimal precioTotal = precioPorKilometro * kilometrosRecorridos;

            GuardarAlquilerEnArchivo(nit, placa, fechaAlquiler, fechaDevolucion, kilometrosRecorridos);

            MessageBox.Show("Datos del alquiler guardados", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private decimal ObtenerPrecioPorKilometro(string placa)
        {
            return 0.1m; 
        }

        private void GuardarAlquilerEnArchivo(string nit, string placa, DateTime fechaAlquiler, DateTime fechaDevolucion, int kilometrosRecorridos)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("alquileres.txt", true))
                {
                    writer.WriteLine($"{nit},{placa},{fechaAlquiler},{fechaDevolucion},{kilometrosRecorridos}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el alquiler en el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
