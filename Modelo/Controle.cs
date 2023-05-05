using ProjetoPimUnip2023Psemestre.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPimUnip2023Psemestre.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if(!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }

            return tem;
        }

        public String cadastrar (String login, String senha, String ConfSenha) 
        {

            return mensagem;
        }

        public override bool Equals(object obj)
        {
            return obj is Controle controle &&
                   tem == controle.tem &&
                   mensagem == controle.mensagem;
        }
    }
}
