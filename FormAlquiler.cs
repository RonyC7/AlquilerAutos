// FormAlquiler.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlquilerAutos
{
    public partial class FormAlquiler : Form
    {
        public FormAlquiler()
        {
            InitializeComponent();
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
        }

        private void GuardarAlquiler()
        {
            string nit = comboBoxNit.SelectedItem as string;
            string placa = comboBoxPlaca.SelectedItem as string;
            DateTime fechaAlquiler = dateTimePickerAlquiler.Value;
            DateTime fechaDevolucion = dateTimePickerDevolucion.Value;
            int kilometrosRecorridos = int.Parse(textBoxKilometroReco.Text);

            // Calcular el precio del alquiler multiplicando los kilómetros recorridos por el precio por kilómetro del vehículo
            decimal precioPorKilometro = ObtenerPrecioPorKilometro(placa);
            decimal precioTotal = precioPorKilometro * kilometrosRecorridos;

            // Aquí iría la lógica para guardar el alquiler con todos los datos en algún lugar

            // Por ahora, solo mostramos un mensaje con la información
            string mensaje = $"Alquiler guardado:\nNIT: {nit}\nPlaca: {placa}\nFecha de Alquiler: {fechaAlquiler}\nFecha de Devolución: {fechaDevolucion}\nKilómetros Recorridos: {kilometrosRecorridos}\nPrecio Total: {precioTotal}";
            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private decimal ObtenerPrecioPorKilometro(string placa)
        {
            // Simplemente devuelve un precio por kilómetro predeterminado para la placa proporcionada
            // En una aplicación real, este valor debería obtenerse de algún lugar, como una base de datos
            return 0.1m; // Ejemplo: precio de $0.1 por kilómetro
        }
    }
}
