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
    public partial class documentos : Form
    {
        Classes.ConexaoBd con = new Classes.ConexaoBd();
        public documentos()
        {
            InitializeComponent();
        }
        public void AddDocumentos()
        {
            //int id_F = con.lerQtdLinhas(); // Gerando Id do funcionario para table documentos

            //string cpf = txt_addCpf.Text;
            //string pis = txt_addPis.Text;
            //string rg = txt_addRg.Text;
            //string titulo_eleitor = txt_addT_eleitor.Text;
            //string titulo_zona = txt_addT_zona.Text;
            //string titulo_secao = txt_addT_secao.Text;
            //string cert_militar = txt_addCert_militar.Text;
            //string cnh = txt_addCnh.Text;
            //string ctps = txt_addCtps.Text;
            //string ctps_serie = txt_addCtps_serie.Text;
            //string id_funcionario = id_F.ToString();

            //con.adicionar_documento(cpf, pis, rg, titulo_eleitor, titulo_zona, titulo_secao, cert_militar, cnh, ctps, ctps_serie, id_funcionario);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddDocumentos();
        }
    }
}
