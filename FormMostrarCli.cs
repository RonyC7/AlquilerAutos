using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace AlquilerAutos
{
    public partial class FormMostrarCli : Form
    {
        public FormMostrarCli()
        {
            InitializeComponent();
            CargarDatosClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
        }

        private void CargarDatosClientes()
        {
            if (File.Exists("clientes.txt"))
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Dirección");
                    dt.Columns.Add("NIT");

                    string[] lines = File.ReadAllLines("clientes.txt");
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            dt.Rows.Add(parts[0], parts[1], parts[2]);
                        }
                    }

                    dataGridViewCliente.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos de clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de clientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
