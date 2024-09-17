using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendedores
{
    public partial class Form1 : Form
    {
        // Arreglo bidimensional para resumen de ventas: [producto, vendedor]
        private float[,] resumenVentas = new float[5, 4];

        public Form1()
        {
            InitializeComponent();
        }

        private void tbVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores ingresados
                int vendedor = int.Parse(tbVendedor.Text);
                int producto = int.Parse(tbProducto.Text);
                float valorVenta = float.Parse(tbVenta.Text);

                // Validar que los valores ingresados estén dentro del rango permitido
                if (vendedor >= 1 && vendedor <= 4 && producto >= 1 && producto <= 5)
                {
                    // Sumar las ventas al arreglo
                    resumenVentas[producto - 1, vendedor - 1] += valorVenta;

                    MessageBox.Show("Venta agregada exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error: Vendedor o producto fuera de rango.");
                }

                // Limpiar campos de texto
                tbVendedor.Clear();
                tbProducto.Clear();
                tbVenta.Clear();
                tbVendedor.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar el reporte en el ListBox
                lbReporte.Items.Clear();
                lbReporte.Items.Add("Producto/Vendedor   1       2       3       4   | Total Producto");

                for (int producto = 0; producto < 5; producto++)
                {
                    float totalProducto = 0;
                    string linea = $"Producto {producto + 1}       ";

                    for (int vendedor = 0; vendedor < 4; vendedor++)
                    {
                        linea += $"{resumenVentas[producto, vendedor],8:F2} ";
                        totalProducto += resumenVentas[producto, vendedor];
                    }

                    linea += $"| {totalProducto,8:F2}";
                    lbReporte.Items.Add(linea);
                }

                // Totales por vendedor
                lbReporte.Items.Add("----------------------------------------------------------");
                string lineaTotales = "Total Vendedor     ";
                for (int vendedor = 0; vendedor < 4; vendedor++)
                {
                    float totalVendedor = 0;
                    for (int producto = 0; producto < 5; producto++)
                    {
                        totalVendedor += resumenVentas[producto, vendedor];
                    }
                    lineaTotales += $"{totalVendedor,8:F2} ";
                }
                lbReporte.Items.Add(lineaTotales);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbReporte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
