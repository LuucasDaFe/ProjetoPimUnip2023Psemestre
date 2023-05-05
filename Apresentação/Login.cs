using ProjetoPimUnip2023Psemestre.Apresentação;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPimUnip2023Psemestre
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbLogin.Text == "Marcos" && txbSenha.Text == "1234")
            {
                MessageBox.Show("Bem vindo ao sistema!");

            }
            else
            {
                MessageBox.Show("Login ou Senha invalidos!");
            }
            if (txbLogin.Text == "Marcos" && txbSenha.Text == "1234")
            {
                this.Close();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastreSe_Click(object sender, EventArgs e)
        {
            CadastreSe cad = new CadastreSe();
            cad.Show();
        }
    }
}
