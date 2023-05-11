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
    public partial class Form_funcionario_acessar : Form
    {
        public Form_funcionario_acessar()
        {
            InitializeComponent();
        }
        Classes.ConexaoBd bd = new Classes.ConexaoBd();
        acesso_usuario ac = new acesso_usuario();
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHorite_Click(object sender, EventArgs e)
        {
            createHolerite();
        }

        public void createHolerite()
        {
           
            
            Classes.GerandoPDF pdf = new Classes.GerandoPDF();
            string nome = ac.UsuarioAcesso;
            string senha = ac.SenhaAcesso;

            string mes = cbEscolherMes.Text;

            string id = bd.verificaIdLogin(nome, senha);
            pdf.gerandoPdfHolerite(id, mes);

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            acesso_usuario acss = new acesso_usuario();
            this.Close();
            acss.ShowDialog();
        }
        public void mostrarHoras()
        {
            string nome = ac.UsuarioAcesso;
            string senha = ac.SenhaAcesso;

            string selecionado = cbEscolherMes.Text;

            string mes = bd.verificaMesSelcionado(selecionado);
            string id = bd.verificaIdLogin(nome, senha);
            dgvRegistroHoras.DataSource = bd.mostrarRegistroHoras(id, mes);
        }
        private void btnHoras_Click(object sender, EventArgs e)
        {
            mostrarHoras();
        }
    }
}
