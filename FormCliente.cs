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

            // Verificar si el cliente ya existe en el diccionario
            if (!RepositorioDatos.ClientesVehiculosAlquilados.ContainsKey(nit))
            {
                // Agregar el cliente al diccionario con una lista vacía de placas
                RepositorioDatos.ClientesVehiculosAlquilados.Add(nit, new List<string>());
            }

            MessageBox.Show("Cliente guardado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClienteGuardado?.Invoke(this, EventArgs.Empty);
        }
    }
}
