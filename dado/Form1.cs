using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dado
{
    public partial class Form1 : Form
    {
        // Variables globales para almacenar los resultados de los dados
        int dado1 = 0;
        int dado2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Evento para el botón que lanza el dado 1
        private void btnDado1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            dado1 = rand.Next(1, 7);  // Lanzar el dado 1 (valor entre 1 y 6)
            MessageBox.Show($"Dado 1: {dado1}");
        }

        // Evento para el botón que lanza el dado 2
        private void btnDado2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            dado2 = rand.Next(1, 7);  // Lanzar el dado 2 (valor entre 1 y 6)
            MessageBox.Show($"Dado 2: {dado2}");

            // Calcular la suma de los dos dados
            int suma = dado1 + dado2;

            // Mostrar los resultados en el ListBox
            lbResults.Items.Add($"Dado 1: {dado1}, Dado 2: {dado2}, Suma: {suma}");
        }

        private void lbResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Implementa aquí lo que quieras hacer cuando el índice seleccionado cambie
        }

    }

}
