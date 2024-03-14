using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace AlquilerAutos
{
    public partial class FormMostrarVehi : Form
    {
        public FormMostrarVehi()
        {
            InitializeComponent();
            CargarDatosVehiculos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
        }

        private void CargarDatosVehiculos()
        {
            if (File.Exists("vehiculos.txt"))
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Placa");
                    dt.Columns.Add("Marca");
                    dt.Columns.Add("Modelo");
                    dt.Columns.Add("Color");
                    dt.Columns.Add("PrecioPorKilometro");

                    string[] lines = File.ReadAllLines("vehiculos.txt");
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 5)
                        {
                            dt.Rows.Add(parts[0], parts[1], parts[2], parts[3], parts[4]);
                        }
                    }

                    dataGridViewVehiculos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos de vehículos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de vehículos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
