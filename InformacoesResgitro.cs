using iTextSharp.text.pdf.codec.wmf;
using Npgsql;
using Npgsql.Replication.PgOutput.Messages;
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
    public partial class InformacoesResgitro : Form
    {
        public InformacoesResgitro()
        {
            InitializeComponent();
        }
        Classes.ConexaoBd con = new Classes.ConexaoBd();
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void InformacoesResgitro_Load(object sender, EventArgs e)
        {

        }

        private void btnFecharPainelFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFuncionario();
            
        }

        private void InfoRegistroNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InfoSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfoRegistroEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        public void AddFuncionario()
        {
            //Adicionar na table funcionario
            string nome = txt_addNome.Text;
            string sexo = con.lerSexo(cb_addSexo.Text);
            string nascimento = txt_addDataNascimento.Text;
            string estado_civil = txt_addEstadoCivil.Text;
            string nome_conjuge = txt_addConjuge.Text;
            string escolaridade = txt_addEscolaridade.Text;
            string nacionalidade = txt_addNacionalidade.Text;
            string nome_mae = txt_addMae.Text;
            string nome_pai = txt_addPai.Text;
            string numeroconta = txt_addConta_banco.Text;
            string agencia = txt_addAgencia_banco.Text;

            con.adicionar_funcionario(nome, sexo, nascimento, estado_civil, nome_conjuge, escolaridade, nacionalidade, nome_mae, nome_pai, numeroconta, agencia);

            this.Close();

            int id_F = con.lerQtdLinhas(); // Gerando Id do funcionario para table documentos
            string cpf = LimitarTamanhoCampo(txt_addCpf.Text, 14);
            string pis = LimitarTamanhoCampo(txt_addPis.Text, 14);
            string rg = LimitarTamanhoCampo(txt_addRg.Text, 12);
            string titulo_eleitor = LimitarTamanhoCampo(txt_addT_eleitor.Text, 15);
            string titulo_zona = LimitarTamanhoCampo(txt_addT_zona.Text, 5);
            string titulo_secao = LimitarTamanhoCampo(txt_addT_secao.Text, 5);
            string cert_militar = LimitarTamanhoCampo(txt_addCert_militar.Text, 14);
            string cnh = LimitarTamanhoCampo(txt_addCnh.Text, 14);
            string ctps = LimitarTamanhoCampo(txt_addCtps.Text, 14);
            string ctps_serie = LimitarTamanhoCampo(txt_addCtps_serie.Text, 10);
            string id_funcionario = id_F.ToString();


            con.adicionar_documento(cpf, pis, rg, titulo_eleitor, titulo_zona, titulo_secao, cert_militar, cnh, ctps, ctps_serie, id_funcionario);

            // adicionar table endereco_contato

            string cep = LimitarTamanhoCampo(txt_addCep.Text, 8);
            string logradouro = LimitarTamanhoCampo(txt_addRua.Text, 100);
            string numero = LimitarTamanhoCampo(txt_add_N_rua.Text, 5);
            string bairro = LimitarTamanhoCampo(txt_addBairro.Text, 100);
            string cidade = LimitarTamanhoCampo(txt_addCidade.Text, 100);
            string estado = LimitarTamanhoCampo(txt_addEstado.Text, 2);
            string celular = LimitarTamanhoCampo(txt_addContato.Text, 20);
            string email = LimitarTamanhoCampo(txt_addEmail.Text, 100);


            con.adicionar_endereco_contato(cep, logradouro, numero, bairro, cidade, estado, celular, email);

            string salario = txt_addSalario.Text;
            string id_departamento = con.lerIdDepartamento(cb_addDepartamento.Text).ToString();
            string data_inicio_cargo = txt_addData_admissao.Text;
            string id_cargo = con.lerIdCargo(cb_addCargo.Text).ToString();

            con.adiciionar_funcionario_cargo(salario, id_departamento, data_inicio_cargo, id_cargo);
            MessageBox.Show("Novo funcionario adcionado com sucesso!");

            // adcionar usuario ao sistema 
            string usuario = txtNomeUsuario.Text;
            string senha = txtSenhaUsuario.Text;
            string nivel = cbNivel.Text;

            con.addAcesso(nivel,senha, usuario);
        }
        private string LimitarTamanhoCampo(string texto, int tamanhoMaximo)
        {
            if (texto.Length >= tamanhoMaximo)
            {
                return texto.Substring(0, tamanhoMaximo);
            }
            return texto;
        }
        private void cm_addCargo_VisibleChanged(object sender, EventArgs e)
        {
            Classes.ConexaoBd objConect = new Classes.ConexaoBd();
            string atributo = "nome_cargo";
            string entidade = "cargo";
            cb_addCargo.DataSource = objConect.mostrarNoComboBoxOutros(atributo, entidade);
            cb_addCargo.ValueMember = atributo;
        }

        private void cb_addDepartamento_VisibleChanged(object sender, EventArgs e)
        {
            Classes.ConexaoBd objConect = new Classes.ConexaoBd();
            string comando = "nome_departamento";
            string entidade = "departamento";
            cb_addDepartamento.DataSource = objConect.mostrarNoComboBoxOutros(comando, entidade);
            cb_addDepartamento.ValueMember = comando;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
