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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            infoFuncio();
        }
        public void infoFuncio()
        {
            NpgsqlConnection conex = new NpgsqlConnection();

            string server = "localhost";
            string bd = "teste2";
            string user = "postgres";
            string password = "cr7melhor";
            string port = "5432";

            string conectBDPim = "server=" + server + ";" + "port=" + port + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + bd + ";";

            string cmdInfFuncio = "SELECT idfuncionario, nome, sexo, cpf, nascimento, cidade, estado, rg, nome_mae, nome_pai, estado_civil, contato, email, cnh, titulo_eleitor, id_departamento FROM funcionario;";
            conex.ConnectionString = conectBDPim;
            NpgsqlCommand cmd = new NpgsqlCommand(cmdInfFuncio, conex);

            //string cmdDepartamento = "SELECT data_adimssao, salario, agencia, conta_banco, banco, exame_medico, id_funcionario, id_registro FROM administrativo;";
            //conex.ConnectionString = conectBDPim;
            //NpgsqlCommand cmd2 = new NpgsqlCommand(cmdDepartamento, conex);
            conex.Open();

            NpgsqlDataReader reader = cmd.ExecuteReader();
            //NpgsqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader.Read())
            {
                //Lendo dados da tabela adimnistrativo
                InfoRegistroId.Text = reader.GetInt32(0).ToString();
                InfoRegistroNome.Text = reader.GetString(1);
                infoSexo.Text = reader.GetString(2);
                infoCpf.Text = reader.GetString(3);
                infoRegistroDataNasc.Text = reader.GetDateTime(4).ToString("dd/MM/yyyy");
                InfoRegistroCidade.Text = reader.GetString(5);
                infoEstado.Text = reader.GetString(6);
                InfoRegistroRG.Text = reader.GetString(7);
                InforegistroNomeMae.Text = reader.GetString(8);
                InfoRegistroNomePai.Text = reader.GetString(9);
                InfoRegistroEstadoCivil.Text = reader.GetString(10);
                InfoRegistroContato.Text = reader.GetString(10);
                InfoRegistroEmail.Text = reader.GetString(11);
                InfoRegistroCNH.Text = reader.GetString(12);
                InfoRegistroTituloEleitor.Text = reader.GetString(13);
                InfoRegistroDepartamento.Text = reader.GetString(14);

                // Lendo dados da tabela Departamento.
                //InfoRegistroDataAdimssao.Text = reader2.GetInt32(0).ToString();
                //InfoRegistroSalarioInicial.Text = reader2.GetFloat(1).ToString();
                //InfoRegistroAgenciaBanco.Text = reader2.GetInt32(2).ToString();
                //InfoRegistroContaBanco.Text = reader2.GetInt32(3).ToString();
                //InfoExameMedico.Text = reader2.GetString(4);

            }
            conex.Close();
;        }
    }
}
