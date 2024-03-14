using System;
using System.Data;
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
            if (File.Exists("alquileres.txt"))
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("NIT");
                    dt.Columns.Add("Placa");
                    dt.Columns.Add("FechaAlquiler");
                    dt.Columns.Add("FechaDevolucion");
                    dt.Columns.Add("KilometrosRecorridos");

                    string[] lines = File.ReadAllLines("alquileres.txt");
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 5)
                        {
                            dt.Rows.Add(parts[0], parts[1], parts[2], parts[3], parts[4]);
                        }
                    }

                    dataGridViewAlquiler.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos de alquiler: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de alquileres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
