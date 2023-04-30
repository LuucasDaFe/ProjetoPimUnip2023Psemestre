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


        string horaEntrada;
        public string calculaSalario()
        {
            string hEntrada = "SELECT hora_entrada, hora_saida FROM registro";
            conex.ConnectionString = conectBDPim;
            NpgsqlCommand cmd = new NpgsqlCommand(hEntrada, conex);
            conex.Open();
            NpgsqlDataReader ler = cmd.ExecuteReader();


          
            while (ler.Read())
            {
                TimeSpan entrada = ler.GetTimeSpan(0);
                TimeSpan saida = ler.GetTimeSpan(1);

                var tempo = saida - entrada;
                horaEntrada = tempo.TotalHours.ToString();
            }

            conex.Close();
            return horaEntrada;
        }
    }
}
