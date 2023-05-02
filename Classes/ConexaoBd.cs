using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPimUnip2023Psemestre.Classes
{
    internal class ConexaoBd
    {
        NpgsqlConnection conex = new NpgsqlConnection();

        static string servidor = "localhost";
        static string bancoDeDados = "sistemaholerite";
        static string usuario = "postgres";
        static string senha = "cr7melhor";
        static string porta = "5432";

        string correnteConexao = "server=" + servidor + ";" + "port=" + porta + ";" + "user id=" + usuario + ";" + "password=" + senha + ";" + "database=" + bancoDeDados + ";";


            static string server = "localhost";
            static string bd = "teste2";
            static string user = "postgres";
            static string password = "cr7melhor";
            static string port = "5432";

            string conectBDPim = "server=" + server + ";" + "port=" + port + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + bd + ";";


        public NpgsqlConnection estabelecerConexao()
        {
            try
            {
                conex.ConnectionString = correnteConexao;
                conex.Open();
                MessageBox.Show("Conexão bem sucecidida!!!");
            }
            catch(NpgsqlException e)
            {
                MessageBox.Show("Não se pode conectar ao BD" + e.ToString());               
            }
            finally
            {
                conex.Close();
            }
            return conex;
        }
        //public NpgsqlConnection incitialize()
        //{
        //    try
        //    {
        //        conex.ConnectionString = correnteConexao;
        //        conex.Open();

        //        string query = "SELECT * FROM info_holerite_funcionarios;";
        //        NpgsqlCommand cmd = new NpgsqlCommand(query, conex);
        //        NpgsqlDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            MessageBox.Show("Pode conectar ao BD");
        //        }
        //    }
        //    catch (NpgsqlException e)
        //    {
        //        MessageBox.Show("Não se pode conectar ao BD" + e.ToString());
        //    }
        //    finally
        //    {
        //        conex.Close();
        //    }
        //    return conex;
        //}

        public void conectar()
        {
            conex.Open();
        }

        public void desconectar()
        {
            conex.Close();
        }

        public DataTable statusFuncionarios(string status)
        {
            string comandoSql = "SELECT * FROM info_holerite_funcionarios where status = '"+status+"';";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand conector = new NpgsqlCommand(comandoSql, conex);
            conex.Open();
            conector.ExecuteNonQuery();
            NpgsqlDataAdapter dados = new NpgsqlDataAdapter(conector);
            DataTable tabela = new DataTable();
            dados.Fill(tabela);
            conex.Close();
            return tabela;
        }

        public DataTable incluirInfoDgvColaboradores(string comandoSql)
        {           
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand conector = new NpgsqlCommand(comandoSql, conex);
            conex.Open();
            conector.ExecuteNonQuery();
            NpgsqlDataAdapter dados = new NpgsqlDataAdapter(conector);
            DataTable tabela = new DataTable();
            dados.Fill(tabela);
            conex.Close();
            return tabela;
        }

        public DataTable pesquisarColaborador(string funcionario)
        {
            string comandoSql = "SELECT * FROM info_holerite_funcionarios where colaborador LIKE '%"+funcionario+"%';";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand conector = new NpgsqlCommand(comandoSql, conex);
            conex.Open();
            conector.ExecuteNonQuery();
            NpgsqlDataAdapter dados = new NpgsqlDataAdapter(conector);
            DataTable resultado = new DataTable();
            dados.Fill(resultado);
            conex.Close();
            return resultado;
        }


        string horaTrabalho;
        public string calculaHora(string Id_funcionario)
        {
            
            string comandoH = "SELECT hora_entrada, hora_saida, hora_inicio_intervalo, hora_fim_intervalo FROM horarios WHERE id_funcionario = "+ Id_funcionario + ";";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comandoH, conex);
            conex.Open();
            NpgsqlDataReader ler = cmd.ExecuteReader();

            TimeSpan tempo = TimeSpan.Zero;

            while (ler.Read())
            {
                TimeSpan entrada = ler.GetTimeSpan(0);
                TimeSpan saida = ler.GetTimeSpan(1);
                TimeSpan almoco = ler.GetTimeSpan(2);
                TimeSpan almoco2 = ler.GetTimeSpan(3);
            
                tempo += (saida - entrada) - (almoco2 - almoco);
                horaTrabalho = tempo.TotalHours.ToString();               
            }

            conex.Close();
            return horaTrabalho;
        }


        float salarioHora;
        public float calculaSalario(string Id_funcionario)
        {

            string comandoH = "SELECT salario FROM registro WHERE id_funcionario = " + Id_funcionario + ";";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comandoH, conex);
            conex.Open();
            NpgsqlDataReader ler = cmd.ExecuteReader();

            float salarioX;

            while (ler.Read())
            {
                float salarioNoRegistro = ler.GetFloat(0);
                salarioX = salarioNoRegistro / 220;
                salarioHora = salarioX;
            }

            conex.Close();            
            return salarioHora;
        }


    }
}
