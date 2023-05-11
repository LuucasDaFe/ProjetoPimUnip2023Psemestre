using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public string SenhaAcesso
        {
            get { return txtSenhaAcesso.Text; }
        }

        public string UsuarioAcesso
        {
            get { return txtUsuarioAcesso.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.ConexaoBd con = new Classes.ConexaoBd();

            string senha = SenhaAcesso; // Obtém o valor da propriedade SenhaAcesso
            string usuario = UsuarioAcesso; // Obtém o valor da propriedade UsuarioAcesso
            con.validaAcesso(usuario, senha);
        }
    }

}
