using ProjetoPimUnip2023Psemestre.Classes;
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
    public partial class IconHolerite : Form
    {
        public IconHolerite()
        {
            InitializeComponent();
        }

        private void lblColaboradores_Click(object sender, EventArgs e)
        {

        }

        private void Holerite_Load(object sender, EventArgs e)
        {

        }

        private void dgvListaFuncio_VisibleChanged(object sender, EventArgs e)
        {
            string comandoSql = "SELECT * FROM holerite;";
            Classes.ConexaoBd objetoConexao = new Classes.ConexaoBd();
            dgvHoleriteFuncionario.DataSource = objetoConexao.incluirInfoDgvColaboradores(comandoSql);
        }
        int idFuncionario;
        private void dgvListaFuncio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegando ID do funcionario
            idFuncionario = Convert.ToInt32(dgvHoleriteFuncionario.Rows[e.RowIndex].Cells["id"].Value.ToString());
            //Verificar qual coluna vai ser clicada.
            if (dgvHoleriteFuncionario.Columns[e.ColumnIndex] == dgvHoleriteFuncionario.Columns["HoleriteDoMes"])
            {
                Classes.GerandoPDF gerandoPDF = new Classes.GerandoPDF();
                gerandoPDF.gerandoPdfHolerite();
                gerandoPDF.abrindoPDF();
            }
        }

        private void dgvHoleriteFuncionario_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewColumn coluna in dgvHoleriteFuncionario.Columns)
            {
                switch (coluna.Name)
                {
                    case "HoleriteDoMes":
                        coluna.DisplayIndex = 3;
                        break;
                    case "pastaHolerite":
                        coluna.DisplayIndex = 4;
                        break;
                }
            }
        }

        private void dgvHoleriteFuncionario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvHoleriteFuncionario.Rows[e.RowIndex].Cells["HoleriteDoMes"].ToolTipText = "Clique aqui para vê o holerite do mês";
            dgvHoleriteFuncionario.Rows[e.RowIndex].Cells["pastaHolerite"].ToolTipText = "Clique aqui para vê o holerite do mês";

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Classes.GerandoPDF gerandoPDF = new Classes.GerandoPDF();
            gerandoPDF.gerandoPdfHolerite();
            gerandoPDF.abrindoPDF();
        }
    }
}
