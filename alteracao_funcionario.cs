using Npgsql;
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
    public partial class alteracao_funcionario : Form 
    {
        public alteracao_funcionario()
        {
            InitializeComponent();
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
      
        private void btnPesquisa_Alterar_Click(object sender, EventArgs e)
        {

        }

        private void barraAlteraFuncio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void lipaCampo()
        {
            nomeFuncionario.Text = "";
            AlterEmail.Text = "";
            alterContato.Text = "";
            alterEndereco.Text = "";
            alterDepartamento.Text = "";
            alterCargo.Text = "";
            AlterSalario.Text = "";
            AlterContabanco.Text = "";
            alterAgencia.Text = "";
        }
        Classes.ConexaoBd bd = new Classes.ConexaoBd();

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nome = barraAlteraFuncio.Text;
            string id = bd.consultarIdFuncionario(nome);

            string cep = LimitarTamanhoCampo(tctAlterCep.Text, 8);
            string logradouro = LimitarTamanhoCampo(alterEndereco.Text, 100);
            string bairro = LimitarTamanhoCampo(alterBairro.Text, 100);
            string numero = LimitarTamanhoCampo(alter_numero_rua_funcionario.Text, 5);
            string cidade = LimitarTamanhoCampo(alterCidade.Text, 100);
            string celular = LimitarTamanhoCampo(alterContato.Text, 20);
            string email = LimitarTamanhoCampo(AlterEmail.Text, 100);

            bd.alterdadoEndereco_contato(id, logradouro, numero, bairro, cidade, celular, email, cep);
            //*****************************************************************************************************************************************

            string contaBanco = LimitarTamanhoCampo(AlterContabanco.Text, 20);
            string agencia = LimitarTamanhoCampo(alterAgencia.Text, 20);
            bd.alterDadosBanco(id, contaBanco, agencia);

            //*****************************************************************************************************************************************

            string departamento = bd.lerIdDepartamento(alterDepartamento.Text);
            string cargo = bd.lerIdCargo(alterCargo.Text);
            //string salario = "";

            bd.alterarCargoDepartamento(id, cargo, departamento);

        }
        private string LimitarTamanhoCampo(string texto, int tamanhoMaximo)
        {
            if (texto.Length >= tamanhoMaximo)
            {
                return texto.Substring(0, tamanhoMaximo);
            }
            return texto;
        }
        //public void consultarFuncionario() 
        //{
        //    string nome = barraAlteraFuncio.Text;
        //    Classes.ConexaoBd bd = new Classes.ConexaoBd();
        //    string nomefuncionario = barraPesquisaConsulta.Text;
        //    string id_funcionario = bd.consultarIdFuncionario(nomefuncionario);

        //    InfoRegistroNome.Text = bd.consultaDadosFuncionario("nome", id_funcionario);
        //    InfoRegistroEmail.Text = bd.consultarOutros("email", "endereco_contato", id_funcionario);
        //    InfoRegistroContato.Text = bd.consultarOutros("celular", "endereco_contato", id_funcionario);
        //    InfoRegistroEndereco.Text = bd.consultarOutros("logradouro", "endereco_contato", id_funcionario);
        //    infoBairro.Text = bd.consultarOutros("bairro", "endereco_contato", id_funcionario);
        //    infoCidade.Text = bd.consultarOutros("cidade", "endereco_contato", id_funcionario);
        //    InfoRegistroContaBanco.Text = bd.consultarInfoFuncionario("numeroconta", "funcionario", nome);
        //    InfoRegistroAgenciaBanco.Text = bd.consultarInfoFuncionario("agencia", "funcionario", nome);
        //    InfoRegistroDepartamento.Text = bd.lerTableFuncionario_Departamento(id_funcionario);
        //}

        private void btnPesquisarColaborador_Click(object sender, EventArgs e)
        {
            
            
        }

        private void alterDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void alterDepartamento_VisibleChanged(object sender, EventArgs e)
        {
            Classes.ConexaoBd objConect = new Classes.ConexaoBd();
            string comando = "nome_departamento";
            string entidade = "departamento";
            alterDepartamento.DataSource = objConect.mostrarNoComboBoxOutros(comando, entidade);
            alterDepartamento.ValueMember = comando;
        }

        private void barraAlteraFuncio_VisibleChanged(object sender, EventArgs e)
        {

            Classes.ConexaoBd objConect = new Classes.ConexaoBd();
            string comando = "nome";
            string entidade = "funcionario";
            barraAlteraFuncio.DataSource = objConect.mostrarNoComboBox(comando, entidade);
            barraAlteraFuncio.ValueMember = comando;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void barraPesquisaConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void barraPesquisaConsulta_VisibleChanged(object sender, EventArgs e)
        {
            //Classes.ConexaoBd objConect = new Classes.ConexaoBd();
            //string comando = "nome";
            //string entidade = "funcionario";
            //barraPesquisaConsulta.DataSource = objConect.mostrarNoComboBox(comando, entidade);
            //barraPesquisaConsulta.ValueMember = comando;
        }

        private void alterCargo_VisibleChanged(object sender, EventArgs e)
        {
            Classes.ConexaoBd objConect = new Classes.ConexaoBd();
            string atributo = "nome_cargo";
            string entidade = "cargo";
            alterCargo.DataSource = objConect.mostrarNoComboBoxOutros(atributo, entidade);
            alterCargo.ValueMember = atributo;
        }

        private void alterCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPesquisarColaborador_Click_1(object sender, EventArgs e)
        {


        }

        private void panelPesquisa_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
