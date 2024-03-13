using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AlquilerAutos
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        public event EventHandler ClienteGuardado;

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
        }

        private void buttonGuardarCliente_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombreCliente.Text;
            string direccion = textBoxDireccionCliente.Text;
            string nit = textBoxNit.Text;

            if (RepositorioDatos.ClientesVehiculosAlquilados.ContainsKey(nit))
            {
                MessageBox.Show("El cliente ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RepositorioDatos.ClientesVehiculosAlquilados.Add(nit, new List<string>());

            GuardarClienteEnArchivo(nombre, direccion, nit);

            MessageBox.Show("Cliente guardado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClienteGuardado?.Invoke(this, EventArgs.Empty);
        }

        private void GuardarClienteEnArchivo(string nombre, string direccion, string nit)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("clientes.txt", true))
                {
                    writer.WriteLine($"{nombre},{direccion},{nit}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el cliente en el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
