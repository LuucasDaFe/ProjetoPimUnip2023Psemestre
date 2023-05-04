using iTextSharp.text.pdf.codec.wmf;
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
    public partial class InformacoesResgitro : Form
    {
        public InformacoesResgitro()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void InformacoesResgitro_Load(object sender, EventArgs e)
        {

        }
        public void adicionaFuncionarioBd()
        {
            NpgsqlConnection conex = new NpgsqlConnection();

            string server = "localhost";
            string bd = "sistemaholerite";
            string user = "postgres";
            string password = "cr7melhor";
            string port = "5432";

            string conectBDPim = "server=" + server + ";" + "port=" + port + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + bd + ";";

            string nome = InfoRegistroNome.Text;
            string nascimento = infoRegistroDataNasc.Text;
            string endereco = InfoRegistroEndereco.Text;
            string rg = InfoRegistroRG.Text;
            string cpf = infoCpf.Text;
            string cidade = InfoRegistroCidade.Text;
            string estado = infoEstado.Text;
            string mae = InforegistroNomeMae.Text;
            string pai = InfoRegistroNomePai.Text;
            string estado_civil = InfoRegistroEstadoCivil.Text;
            string email = InfoRegistroEmail.Text;
            string telefone = InfoRegistroContato.Text;
            string Nregistro = InfoNumeroRegistro.Text;
            string cnh = InfoRegistroCNH.Text;
            string titulo = InfoRegistroTituloEleitor.Text;
            string admissao = InfoRegistroDataAdimssao.Text;
            string departamento = InfoRegistroDepartamento.Text;
            string nacionalidade = InfoRegistroNacionalidade.Text;
            string sexo = infoSexo.Text;
            string salario = InfoSalario.Text;
            string conta = InfoRegistroContaBanco.Text;
            string agencia = InfoRegistroAgenciaBanco.Text;

            string comando = "INSERT INTO funcionario (nome, data_nascimento, endereco, rg, cpf, cidade, estado, nome_mae, nome_pai, estado_civil, email, telefone, n_registro, n_cnh, titulo_eleitor, data_admissao, departamento, nascionalidade, sexo, salario, conta_banco, agencia_banco) VALUES (@nome, @data_nascimento, @endereco, @rg, @cpf, @cidade, @estado, @nome_mae, @nome_pai, @estado_civil, @email, @telefone, @n_registro, @n_cnh, @titulo_eleitor, @data_admissao, @departamento, @nascionalidade, @sexo, @salario, @conta_banco, @agencia_banco);";

            conex.ConnectionString = conectBDPim;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);


            conex.Open();
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@data_nascimento", Convert.ToDateTime(nascimento));
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@rg", Convert.ToInt32(rg));
            cmd.Parameters.AddWithValue("@cpf", Convert.ToInt32(cpf));
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@nome_mae", mae);
            cmd.Parameters.AddWithValue("@nome_pai", pai);
            cmd.Parameters.AddWithValue("@estado_civil", estado_civil);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telefone", Convert.ToInt32(telefone));
            cmd.Parameters.AddWithValue("@n_registro", Convert.ToInt32(Nregistro));
            cmd.Parameters.AddWithValue("@n_cnh",Convert.ToInt32(cnh));
            cmd.Parameters.AddWithValue("@titulo_eleitor", Convert.ToInt32(titulo));
            cmd.Parameters.AddWithValue("@data_admissao", Convert.ToDateTime(nascimento));
            cmd.Parameters.AddWithValue("@departamento", departamento);
            cmd.Parameters.AddWithValue("@nascionalidade", nacionalidade);
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@salario", Convert.ToSingle(salario));
            cmd.Parameters.AddWithValue("@conta_banco", Convert.ToInt32(conta));
            cmd.Parameters.AddWithValue("@agencia_banco", agencia);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Novo funcionario adcionado com sucesso!");
            conex.Close();

        }

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
            adicionaFuncionarioBd();
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
    }
}
