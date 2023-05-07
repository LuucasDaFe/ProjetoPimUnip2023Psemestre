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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
            //
            string comandoSql = "SELECT idfuncionario, nome FROM funcionario;";
            Classes.ConexaoBd objetoConexao = new Classes.ConexaoBd();
            dgvHoleriteFuncionario.DataSource = objetoConexao.incluirInfoDgvColaboradores(comandoSql);
        }
        string idFuncionario;
        string nomeFuncionario;
        private void dgvListaFuncio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegando ID e nome do funcionario
            //idFuncionario = Convert.ToInt32(dgvHoleriteFuncionario.Rows[e.RowIndex].Cells["id"].Value.ToString());
            idFuncionario = (dgvHoleriteFuncionario.Rows[e.RowIndex].Cells["id"].Value.ToString());
            nomeFuncionario = dgvHoleriteFuncionario.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            //Verificar qual coluna vai ser clicada.
            if (dgvHoleriteFuncionario.Columns[e.ColumnIndex] == dgvHoleriteFuncionario.Columns["HoleriteDoMes"])
            {
                Classes.GerandoPDF gerandoPDF = new Classes.GerandoPDF();
                gerandoPDF.gerandoPdfHolerite(idFuncionario, nomeFuncionario);
            }
        }

        private void dgvHoleriteFuncionario_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewColumn coluna in dgvHoleriteFuncionario.Columns)
            {
                switch (coluna.Name)
                {
                    case "HoleriteDoMes":
                        coluna.DisplayIndex = 2;
                        break;
                    case "pastaHolerite":
                        coluna.DisplayIndex = 3;
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
    
        }
    }
}
