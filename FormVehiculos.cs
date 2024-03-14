using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AlquilerAutos
{
    public partial class FormVehiculos : Form
    {
        public FormVehiculos()
        {
            InitializeComponent();
        }

        public event EventHandler VehiculoGuardado;

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
        }

        private void buttonGuardarVehiculo_Click(object sender, EventArgs e)
        {
            string placa = textBoxPlaca.Text;
            string marca = textBoxMarca.Text;
            string modelo = textBoxModelo.Text;
            string color = textBoxColor.Text;

            decimal precioPorKilometro;
            if (!decimal.TryParse(textBoxPrecioKilometro.Text, out precioPorKilometro))
            {
                MessageBox.Show("Por favor ingrese un precio válido para el kilometro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PlacaExistente(placa))
            {
                MessageBox.Show("La placa ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (var cliente in RepositorioDatos.ClientesVehiculosAlquilados.Keys)
            {
                RepositorioDatos.ClientesVehiculosAlquilados[cliente].Add(placa);
                break;
            }

            GuardarVehiculoEnArchivo(placa, marca, modelo, color, precioPorKilometro);

            MessageBox.Show("Vehículo Guardado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VehiculoGuardado?.Invoke(this, EventArgs.Empty);
        }

        private bool PlacaExistente(string placa)
        {
            foreach (var cliente in RepositorioDatos.ClientesVehiculosAlquilados.Values)
            {
                if (cliente.Contains(placa))
                {
                    return true;
                }
            }
            return false;
        }

        private void GuardarVehiculoEnArchivo(string placa, string marca, string modelo, string color, decimal precioPorKilometro)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("vehiculos.txt", true))
                {
                    writer.WriteLine($"{placa},{marca},{modelo},{color},{precioPorKilometro}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el vehículo en el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
