using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Manejo del evento Click para el botón de cálculo
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Llamar a la función que procesa las ventas
            ProcessSales();
        }

        // Manejo del evento TextChanged para el TextBox
        private void tbVentas_TextChanged(object sender, EventArgs e)
        {
            // Aquí puedes agregar lógica si es necesario
        }

        // Función para procesar las ventas
        private void ProcessSales()
        {
            // Arreglo para contar los salarios en cada rango
            int[] salaryRanges = new int[9];

            // Obtener el texto del TextBox y dividirlo en ventas individuales
            string input = tbVentas.Text;
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Ingrese las ventas antes de calcular.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] sales = input.Split(',');

            // Procesar cada venta
            foreach (string sale in sales)
            {
                if (float.TryParse(sale.Trim(), out float salesAmount))
                {
                    float totalSalary = 200 + (0.09f * salesAmount);
                    int salary = (int)totalSalary;

                    // Determinar el rango salarial
                    if (salary < 300)
                        salaryRanges[0]++;
                    else if (salary < 400)
                        salaryRanges[1]++;
                    else if (salary < 500)
                        salaryRanges[2]++;
                    else if (salary < 600)
                        salaryRanges[3]++;
                    else if (salary < 700)
                        salaryRanges[4]++;
                    else if (salary < 800)
                        salaryRanges[5]++;
                    else if (salary < 900)
                        salaryRanges[6]++;
                    else if (salary < 1000)
                        salaryRanges[7]++;
                    else
                        salaryRanges[8]++;
                }
                else
                {
                    MessageBox.Show($"El valor '{sale.Trim()}' no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Mostrar los resultados en el ListBox
            DisplayResults(salaryRanges);
        }

        // Función para mostrar los resultados en el ListBox
        private void DisplayResults(int[] salaryRanges)
        {
            lbResults.Items.Clear();

            lbResults.Items.Add("Rango Salarial\tCantidad");
            lbResults.Items.Add("--------------------------");
            lbResults.Items.Add("$200-$299\t\t" + salaryRanges[0]);
            lbResults.Items.Add("$300-$399\t\t" + salaryRanges[1]);
            lbResults.Items.Add("$400-$499\t\t" + salaryRanges[2]);
            lbResults.Items.Add("$500-$599\t\t" + salaryRanges[3]);
            lbResults.Items.Add("$600-$699\t\t" + salaryRanges[4]);
            lbResults.Items.Add("$700-$799\t\t" + salaryRanges[5]);
            lbResults.Items.Add("$800-$899\t\t" + salaryRanges[6]);
            lbResults.Items.Add("$900-$999\t\t" + salaryRanges[7]);
            lbResults.Items.Add("$1000 o más\t" + salaryRanges[8]);
        }

        // Manejo del evento SelectedIndexChanged para el ListBox
        private void lbResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí puedes agregar lógica si es necesario
        }
    }
}
