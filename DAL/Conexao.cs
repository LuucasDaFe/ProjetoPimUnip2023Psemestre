using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPimUnip2023Psemestre.DAL
{
    public class Conexao
    {
            NpgsqlConnection con = new NpgsqlConnection();

            public Conexao()
            {
                con.ConnectionString = @"";
        }

        public NpgsqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
                  
         
    }
}
