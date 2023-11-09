namespace Sistema_de_Aerolinea___Examen_Final
{
    public partial class inicioSesion : Form
    {
        public inicioSesion()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Las credenciales son correctas, abrir Form3
            paginaPrincipal form3 = new paginaPrincipal();
            form3.ShowDialog(); // Mostrar Form3 como un diálogo modal.
            this.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registroSesion form2 = new registroSesion();
            form2.ShowDialog(); // Mostrar Form2 como un diálogo modal.
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {

                    ((TextBox)control).Text = string.Empty;
                }
                else if (control is ComboBox)
                {

                    ((ComboBox)control).SelectedIndex = -1;
                }

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}