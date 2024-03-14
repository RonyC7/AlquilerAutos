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
                    dt.Columns.Add("TotalPagar (Q)"); 

                    string[] lines = File.ReadAllLines("alquileres.txt");
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 5)
                        {
                            string nit = parts[0];
                            string placa = parts[1];
                            DateTime fechaAlquiler = DateTime.Parse(parts[2]);
                            DateTime fechaDevolucion = DateTime.Parse(parts[3]);
                            int kilometrosRecorridos = int.Parse(parts[4]);

                            decimal precioPorKilometro = ObtenerPrecioPorKilometro(placa);
                            decimal totalPagar = precioPorKilometro * kilometrosRecorridos;

                            dt.Rows.Add(nit, placa, fechaAlquiler, fechaDevolucion, kilometrosRecorridos, totalPagar);
                        }
                    }

                    dataGridViewAlquiler.DataSource = dt;

                    int valorMasAlto = EncontrarValorMasAlto(dt, "KilometrosRecorridos");

                    labelAlquiAlto.Text = valorMasAlto.ToString();
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

        private decimal ObtenerPrecioPorKilometro(string placa)
        {
            return 0.1m; 
        }

        private void dataGridViewAlquiler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int EncontrarValorMasAlto(DataTable dt, string nombreColumna)
        {
            int valorMasAlto = int.MinValue;

            foreach (DataRow row in dt.Rows)
            {
                int valorActual;
                if (int.TryParse(row[nombreColumna].ToString(), out valorActual))
                {
                    if (valorActual > valorMasAlto)
                    {
                        valorMasAlto = valorActual;
                    }
                }
            }

            return valorMasAlto;
        }
    }
}
