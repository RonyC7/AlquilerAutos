﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormVehiculos formVehiculos = new FormVehiculos();
            formVehiculos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAlquiler formAlquiler = new FormAlquiler();
            formAlquiler.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormMostrarCli formMostrarCli = new FormMostrarCli();
            formMostrarCli.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormMostrarVehi formMostrarVehi = new FormMostrarVehi();
            formMostrarVehi.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormMostrarAlqui formMostrarAlqui = new FormMostrarAlqui();
            formMostrarAlqui.ShowDialog();
        }
    }
}
