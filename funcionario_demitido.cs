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
    public partial class funcionario_demitido : Form
    {
        public funcionario_demitido()
        {
            InitializeComponent();
        }

        private void txt_addContato_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Classes.ConexaoBd bd = new Classes.ConexaoBd();
            string motivo = txt_MotivoDemissao.Text;
            string nome = txtNomee.Text;
            string id = bd.consultarIdFuncionario(nome);

            bd.iniciaDemissao(id, motivo);
        }

        private void txtNomee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNomee_VisibleChanged(object sender, EventArgs e)
        {
            Classes.ConexaoBd objConect = new Classes.ConexaoBd();
            string atributo = "nome";
            string entidade = "funcionario";
            txtNomee.DataSource = objConect.mostrarNoComboBox(atributo, entidade);
            txtNomee.ValueMember = atributo;
        }
    }
}
