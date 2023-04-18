using Npgsql;
using System;
using System.Collections.Generic;
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
        static string bancoDeDados = "teste2";
        static string usuario = "postgres";
        static string senha = "cr7melhor";
        static string porta = "5432";

        string correnteConexao = "server=" + servidor + ";" + "port=" + porta + ";" + "user id=" + usuario + ";" + "password=" + senha + ";" + "database=" + bancoDeDados + ";";

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
            return conex;
        }
    }
}
