using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            // Agregar la placa del vehículo al diccionario de clientes y vehículos alquilados
            foreach (var cliente in RepositorioDatos.ClientesVehiculosAlquilados.Keys)
            {
                RepositorioDatos.ClientesVehiculosAlquilados[cliente].Add(placa);
                break; // Solo necesitamos agregar la placa para un cliente, asumiendo que un vehículo solo se alquila a un cliente
            }

            MessageBox.Show("Vehículo Guardado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VehiculoGuardado?.Invoke(this, EventArgs.Empty);

        }
    }
}
