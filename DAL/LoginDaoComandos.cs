using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPimUnip2023Psemestre.DAL
{
    class LoginDaoComandos
    {
       
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();   
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String login, String senha)
        {
            cmd.CommandText = "Select * from Logins_pim where login = @login and senha = @senha" ;
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return tem;

        }


        public String cadastrar(String login, String senha, String confSenha)
        {
            
            return mensagem;
        }
    }
}
