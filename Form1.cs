using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjetoPimUnip2023Psemestre
{
    public partial class Painel_Inicio : Form
    {
        private DataTable dgvListaFuncio;

        public Painel_Inicio()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Iparam);
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Painei_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if(menuVertical.Width == 250)
            {
                menuVertical.Width = 70;
                ImgLanche.Height = 40;
                ImgLanche.Width = 60;
            }
            else
            {
                menuVertical.Width = 250;
                ImgLanche.Height = 140;
                ImgLanche.Width = 240;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
           
        }

        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;    
        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnHolerite_Click(object sender, EventArgs e)
        {
            abrirFormNoPainel(new IconHolerite());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Classes.ConexaoBd objetoConexao = new Classes.ConexaoBd();
            //objetoConexao.estabelecerConexao();
            //MessageBox.Show(objetoConexao.calcularRegistroHoras("1","3"));
            //MessageBox.Show(objetoConexao.calculaHora("1"));
            //MessageBox.Show(objetoConexao.lerQtdLinhas().ToString());
            objetoConexao.abrirForms(1);
  
        }

        private void ImgLanche_Click(object sender, EventArgs e)
        {

        }
        private void abrirFormNoPainel(object formFilho)
        {
            if (this.painelContenedor.Controls.Count > 0)
                this.painelContenedor.Controls.RemoveAt(0);
            Form fh = formFilho as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.painelContenedor.Controls.Add(fh);
            this.painelContenedor.Tag = fh;
            fh.Show();

        }
        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            abrirFormNoPainel(new Colaboradores());
        }

        private void painelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormNoPainel(new Ponto_horarios());
            //Classes.ConexaoBd objetoConexao = new Classes.ConexaoBd();
            //dgvListaFuncio.Dat = objetoConexao.incluirInfoDgvColaboradores();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirFormNoPainel(new Registro());
        }
    }
}
