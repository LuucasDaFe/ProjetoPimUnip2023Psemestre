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
        //public void adicionaFuncionarioBd()
        //{
        //    NpgsqlConnection conex = new NpgsqlConnection();

        //    string server = "localhost";
        //    string bd = "sistemaholerite";
        //    string user = "postgres";
        //    string password = "cr7melhor";
        //    string port = "5432";

        //    string conectBDPim = "server=" + server + ";" + "port=" + port + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + bd + ";";

        //    string nome = txt_addNome.Text;
        //    string nascimento = txt_addDataNascimento.Text;
        //    string endereco = txt_addCep.Text;
        //    string rg = txt_addRg.Text;
        //    string cpf = txt_addCpf.Text;
        //    string cidade = txt_addCidade.Text;
        //    string estado = txt_addEstado.Text;
        //    string mae = txt_addMae.Text;
        //    string pai = txt_addPai.Text;
        //    string estado_civil = txt_addEstadoCivil.Text;
        //    string email = txt_addEmail.Text;
        //    string telefone = txt_addContato.Text;
        //    string Nregistro = txt_add_N_rua.Text;
        //    string cnh = txt_addT_zona.Text;
        //    string titulo = txt_addConjuge.Text;
        //    string admissao = txt_addData_admissao.Text;
        //    string departamento = txt_addDepartamento.Text;
        //    string nacionalidade = txt_addNacionalidade.Text;
        //    string sexo = infoSexo.Text;
        //    string salario = txt_addSalario.Text;
        //    string conta = txt_addConta_banco.Text;
        //    string agencia = txt_addAgencia_banco.Text;

        //    string comando = "INSERT INTO funcionario (nome, data_nascimento, endereco, rg, cpf, cidade, estado, nome_mae, nome_pai, estado_civil, email, telefone, n_registro, n_cnh, titulo_eleitor, data_admissao, departamento, nascionalidade, sexo, salario, conta_banco, agencia_banco) VALUES (@nome, @data_nascimento, @endereco, @rg, @cpf, @cidade, @estado, @nome_mae, @nome_pai, @estado_civil, @email, @telefone, @n_registro, @n_cnh, @titulo_eleitor, @data_admissao, @departamento, @nascionalidade, @sexo, @salario, @conta_banco, @agencia_banco);";

        //    conex.ConnectionString = conectBDPim;
        //    NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);


        //    conex.Open();
        //    cmd.Parameters.AddWithValue("@nome", nome);
        //    cmd.Parameters.AddWithValue("@data_nascimento", Convert.ToDateTime(nascimento));
        //    cmd.Parameters.AddWithValue("@endereco", endereco);
        //    cmd.Parameters.AddWithValue("@rg", Convert.ToInt32(rg));
        //    cmd.Parameters.AddWithValue("@cpf", Convert.ToInt32(cpf));
        //    cmd.Parameters.AddWithValue("@cidade", cidade);
        //    cmd.Parameters.AddWithValue("@estado", estado);
        //    cmd.Parameters.AddWithValue("@nome_mae", mae);
        //    cmd.Parameters.AddWithValue("@nome_pai", pai);
        //    cmd.Parameters.AddWithValue("@estado_civil", estado_civil);
        //    cmd.Parameters.AddWithValue("@email", email);
        //    cmd.Parameters.AddWithValue("@telefone", Convert.ToInt32(telefone));
        //    cmd.Parameters.AddWithValue("@n_registro", Convert.ToInt32(Nregistro));
        //    cmd.Parameters.AddWithValue("@n_cnh",Convert.ToInt32(cnh));
        //    cmd.Parameters.AddWithValue("@titulo_eleitor", Convert.ToInt32(titulo));
        //    cmd.Parameters.AddWithValue("@data_admissao", Convert.ToDateTime(nascimento));
        //    cmd.Parameters.AddWithValue("@departamento", departamento);
        //    cmd.Parameters.AddWithValue("@nascionalidade", nacionalidade);
        //    cmd.Parameters.AddWithValue("@sexo", sexo);
        //    cmd.Parameters.AddWithValue("@salario", Convert.ToSingle(salario));
        //    cmd.Parameters.AddWithValue("@conta_banco", Convert.ToInt32(conta));
        //    cmd.Parameters.AddWithValue("@agencia_banco", agencia);

        //    cmd.ExecuteNonQuery();
        //    MessageBox.Show("Novo funcionario adcionado com sucesso!");
        //    conex.Close();

        //}

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
        //    infoFuncio();
        //}
        //        public void infoFuncio()
        //        {
        //            NpgsqlConnection conex = new NpgsqlConnection();

        //            string server = "localhost";
        //            string bd = "teste2";
        //            string user = "postgres";
        //            string password = "cr7melhor";
        //            string port = "5432";

        //            string conectBDPim = "server=" + server + ";" + "port=" + port + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + bd + ";";

        //            string cmdInfFuncio = "SELECT idfuncionario, nome, sexo, cpf, nascimento, cidade, estado, rg, nome_mae, nome_pai, estado_civil, contato, email, cnh, titulo_eleitor, id_departamento FROM funcionario;";
        //            conex.ConnectionString = conectBDPim;
        //            NpgsqlCommand cmd = new NpgsqlCommand(cmdInfFuncio, conex);

        //            //string cmdDepartamento = "SELECT data_adimssao, salario, agencia, conta_banco, banco, exame_medico, id_funcionario, id_registro FROM administrativo;";
        //            //conex.ConnectionString = conectBDPim;
        //            //NpgsqlCommand cmd2 = new NpgsqlCommand(cmdDepartamento, conex);
        //            conex.Open();

        //            NpgsqlDataReader reader = cmd.ExecuteReader();
        //            //NpgsqlDataReader reader2 = cmd2.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                //Lendo dados da tabela adimnistrativo
        //                InfoRegistroId.Text = reader.GetInt32(0).ToString();
        //                InfoRegistroNome.Text = reader.GetString(1);
        //                infoSexo.Text = reader.GetString(2);
        //                infoCpf.Text = reader.GetString(3);
        //                infoRegistroDataNasc.Text = reader.GetDateTime(4).ToString("dd/MM/yyyy");
        //                InfoRegistroCidade.Text = reader.GetString(5);
        //                infoEstado.Text = reader.GetString(6);
        //                InfoRegistroRG.Text = reader.GetString(7);
        //                InforegistroNomeMae.Text = reader.GetString(8);
        //                InfoRegistroNomePai.Text = reader.GetString(9);
        //                InfoRegistroEstadoCivil.Text = reader.GetString(10);
        //                InfoRegistroContato.Text = reader.GetString(11).ToString();
        //                InfoRegistroEmail.Text = reader.GetString(13);
        //                InfoRegistroCNH.Text = reader.GetString(13).ToString();
        //                InfoRegistroTituloEleitor.Text = reader.GetString(14);
        //                //InfoRegistroDepartamento.Text = reader.GetString(15).ToString();

        //                // Lendo dados da tabela Departamento.
        //                //InfoRegistroDataAdimssao.Text = reader2.GetInt32(0).ToString();
        //                //InfoRegistroSalarioInicial.Text = reader2.GetFloat(1).ToString();
        //                //InfoRegistroAgenciaBanco.Text = reader2.GetInt32(2).ToString();
        //                //InfoRegistroContaBanco.Text = reader2.GetInt32(3).ToString();
        //                //InfoExameMedico.Text = reader2.GetString(4);

        //            }
        //            conex.Close();
        //;        }

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

            string cpf = txt_addCpf.Text;
            string pis = txt_addPis.Text;
            string rg = txt_addRg.Text;
            string titulo_eleitor = txt_addT_eleitor.Text;
            string titulo_zona = txt_addT_zona.Text;
            string titulo_secao = txt_addT_secao.Text;
            string cert_militar = txt_addCert_militar.Text;
            string cnh = txt_addCnh.Text;
            string ctps = txt_addCtps.Text;
            string ctps_serie = txt_addCtps_serie.Text;
            string id_funcionario = id_F.ToString();

            con.adicionar_documento(cpf, pis, rg, titulo_eleitor, titulo_zona, titulo_secao, cert_militar, cnh, ctps, ctps_serie, id_funcionario);

            // adicionar table endereco_contato
            string cep = txt_addCep.Text;
            string logredouro = txt_addRua.Text;
            string numero = txt_add_N_rua.Text;
            string bairro = txt_addBairro.Text;
            string cidade = txt_addCidade.Text;
            string estado = txt_addEstado.Text;
            string celular = txt_addContato.Text;
            string email = txt_addEmail.Text;

            con.adicionar_endereco_contato(cep, logredouro, numero, bairro, cidade, estado, celular, email);

            string salario = txt_addSalario.Text;
            string id_departamento = con.lerIdDepartamento(cb_addDepartamento.Text).ToString();
            string data_inicio_cargo = txt_addData_admissao.Text;
            string id_cargo = con.lerIdCargo(cb_addCargo.Text).ToString();

            con.adiciionar_funcionario_cargo(salario, id_departamento, data_inicio_cargo, id_cargo);
            MessageBox.Show("Novo funcionario adcionado com sucesso!");
        }
        
        private void cm_addCargo_VisibleChanged(object sender, EventArgs e)
        {
            Classes.ConexaoBd objConect = new Classes.ConexaoBd();
            string atributo = "nome_cargo";
            string entidade = "cargo";
            cb_addCargo.DataSource = objConect.mostrarNoComboBOx(atributo, entidade);
            cb_addCargo.ValueMember = atributo;
        }

        private void cb_addDepartamento_VisibleChanged(object sender, EventArgs e)
        {
            Classes.ConexaoBd objConect = new Classes.ConexaoBd();
            string comando = "nome_departamento";
            string entidade = "departamento";
            cb_addDepartamento.DataSource = objConect.mostrarNoComboBOx(comando, entidade);
            cb_addDepartamento.ValueMember = comando;
        }
    }
}
