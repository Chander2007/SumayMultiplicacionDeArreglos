using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace reservaAerolinea
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        bool[] seats = new bool[10]; // Array para 10 asientos

        public Form1()
        {
            InitializeComponent();
        }

        // Botón sección fumadores
        private void btnSmoking_Click(object sender, EventArgs e)
        {
            try
            {
                AssignSeats(0, 4, "Smoking Section");
            }
            catch (Exception ex)
            {
                // Mensaje de error
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón sección no fumadores
        private void btnNonsmoking_Click(object sender, EventArgs e)
        {
            try
            {
                AssignSeats(5, 9, "Non-Smoking Section");
            }
            catch (Exception ex)
            {
                // Mensaje de error
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Función para la asignación de asientos
        private void AssignSeats(int inicio, int fin, string section)
        {
            try
            {
                for (int i = inicio; i <= fin; i++)
                {
                    if (!seats[i]) // Si el asiento no está ocupado
                    {
                        seats[i] = true; // Asignar asiento

                        // Mostrar en la listBox
                        lbSeats.Items.Add($"Seat {i + 1}, {section}");

                        // Mensaje de confirmación
                        MessageBox.Show($"Seat {i + 1} assigned in {section}.", "Assignment Successful");
                        return;
                    }
                }

                // En caso de que no haya asientos disponibles...
                var result = MessageBox.Show($"No seats available in the {section}. Would you like to change sections?", "Change Section", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Cambiar sección
                    if (section == "Smoking Section")
                    {
                        AssignSeats(5, 9, "Non-Smoking Section");
                    }
                    else
                    {
                        AssignSeats(0, 4, "Smoking Section");
                    }
                }
                else
                {
                    MessageBox.Show("Next flight leaves in 3 hours.", "No Seats Available");
                }
            }
            catch (Exception ex)
            {
                // Mensaje de error
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}