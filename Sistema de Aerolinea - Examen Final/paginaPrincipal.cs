using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Sistema_de_Aerolinea___Examen_Final
{
    public partial class paginaPrincipal : Form
    {

        private Form formularioActual;
        public paginaPrincipal()
        {
            InitializeComponent();

        }

        private void MostrarFormulario(Form nuevoFormulario)
        {
            // Cierra el formulario actual si está abierto
            if (formularioActual != null)
            {
                formularioActual.Close();
            }

            // Configura el nuevo formulario
            nuevoFormulario.TopLevel = false;
            nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
            nuevoFormulario.Dock = DockStyle.Fill;
            
            this.pictureBox2.Controls.Add(nuevoFormulario);
            nuevoFormulario.Show();

            // Establece el nuevo formulario como formulario actual
            formularioActual = nuevoFormulario;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            reserva form4 = new reserva();
            MostrarFormulario(form4);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MisVuelos form5 = new MisVuelos();
            MostrarFormulario(form5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gestionDatos form5 = new gestionDatos();
            MostrarFormulario(form5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            administracion form5 = new administracion();
            MostrarFormulario(form5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            info form5 = new info();
            MostrarFormulario(form5);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cerrar la sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {

                this.Close();
            }

        }
    }
}
