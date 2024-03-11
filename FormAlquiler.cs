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
            LlenarComboBoxNit();
        }

        private void LlenarComboBoxNit()
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
        }
    }
}
