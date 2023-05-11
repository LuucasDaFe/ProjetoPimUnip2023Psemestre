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
    public partial class Ponto_horarios : Form
    {
        public Ponto_horarios()
        {
            InitializeComponent();
        }

        private void Ponto_horarios_Load(object sender, EventArgs e)
        {

        }

        private void dgvListaFuncio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListaFuncio_VisibleChanged(object sender, EventArgs e)
        {
            
            //dgvListaFuncio.DataSource = objetoConexao.incluirInfoDgvColaboradores(comandoSql);
        }

        private void Ponto_horarios_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            AlteraPonto alteraPonto = new AlteraPonto();
            alteraPonto.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Classes.ConexaoBd con = new Classes.ConexaoBd();
            string nome = txtBarraPesquisaNomePonto.Text;
            string id_funcionario = con.consultarIdFuncionario(nome);

            string x = cbSelecionaMes.Text;
            string mes = con.verificaMesSelcionado(x);
            dgvRegistroHora.DataSource = con.mostrarRegistroHoras(id_funcionario,mes);


        }

        private void txtBarraPesquisaNomePonto_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void barraPesquisaConsulta_VisibleChanged(object sender, EventArgs e)
        {
            Classes.ConexaoBd objConect = new Classes.ConexaoBd();
            string comando = "nome";
            string entidade = "funcionario";
            txtBarraPesquisaNomePonto.DataSource = objConect.mostrarNoComboBox(comando, entidade);
            txtBarraPesquisaNomePonto.ValueMember = comando;
        }
    }
}
