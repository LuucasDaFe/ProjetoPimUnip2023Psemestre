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
    public partial class Colaboradores : Form
    {
        public Colaboradores()
        {
            InitializeComponent();
        }

        private void btnFecharPainelFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Colaboradores_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            alteracao_funcionario alteracao_Funcionario = new alteracao_funcionario();
            alteracao_Funcionario.ShowDialog();
        }

        private void lblQuantidadeFuncio_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvListaFuncio_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvListaFuncio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InformacoesResgitro info_funcio = new InformacoesResgitro();
            info_funcio.ShowDialog();
        }

        private void btnPesquisarColaborador_Click(object sender, EventArgs e)
        {
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            
        }

        private void barraPesquisaColaborador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
