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
    public partial class acesso_usuario : Form
    {
        public acesso_usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.ConexaoBd con = new Classes.ConexaoBd();

            string senha = txtSenhaAcesso.Text;
            string usuario = txtUsuarioAcesso.Text;
            string id = con.retornarIdLogin(usuario).ToString();

            con.verificandoAcesso(usuario, senha, id);

        }
    }
}
