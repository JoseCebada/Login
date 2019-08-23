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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string user = "juancho", pass = "123frijoles";
            if (txtUsuario.Text.ToString().Trim() == user)
            {
                if (txtContra.Text.ToString().Trim() == pass)
                {
                    MessageBox.Show("Sesión iniciada correctamente");
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta, inténtelo de nuevo.");
                }
            }
            else
            {
                MessageBox.Show("Usuario incorrecto, inténtelo de nuevo.");
            }
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbUsuario_Click(object sender, EventArgs e)
        {

        }

        private void LbContra_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
