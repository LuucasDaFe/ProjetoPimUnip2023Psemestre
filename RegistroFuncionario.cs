﻿using System;
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
    public partial class RegistroFuncionario : Form
    {
        public RegistroFuncionario()
        {
            InitializeComponent();
        }
        Classes.ConexaoBd con = new Classes.ConexaoBd();
        public void consultarRegistro()
        {
            string nome = barraConsultaFuncionario.Text;
            string id_funcionario = con.consultarIdFuncionario(nome);

            InfoRegistroNome.Text = con.consultarInfoFuncionario("nome", "funcionario", nome);
            infoSexo.Text = con.consultarInfoFuncionario("sexo", "funcionario", nome);
            InfodataNascimento.Text = con.lerData("nascimento", "funcionario",nome);
            InfoEstadoCivil.Text = con.consultarInfoFuncionario("estado_civil","funcionario", nome);
            InfoConjuge.Text = con.consultarInfoFuncionario("nome_conjuge", "funcionario", nome);
            infoEscolaridade.Text = con.consultarInfoFuncionario("escolaridade", "funcionario", nome);
            InfoNacionalidade.Text = con.consultarInfoFuncionario("nacionalidade", "funcionario", nome);
            infoMae.Text = con.consultarInfoFuncionario("nome_mae", "funcionario", nome);
            infoPai.Text = con.consultarInfoFuncionario("nome_pai", "funcionario", nome);
            InfoContaBanco.Text = con.consultarInfoFuncionario("numeroconta", "funcionario", nome);
            InfoAgenciaBanco.Text = con.consultarInfoFuncionario("agencia", "funcionario", nome);

            //valores da tabela documento -----------------------------------------------------------------------------------------
            infoCpf.Text = con.consultarOutros("cpf", "documentos", id_funcionario);
            infoPis.Text = con.consultarOutros("pis", "documentos", id_funcionario);
            InfoRegistroRG.Text = con.consultarOutros("rg", "documentos", id_funcionario);
            info_T_Eleitor.Text = con.consultarOutros("titulo_eleitor", "documentos", id_funcionario);
            info_T_secao.Text = con.consultarOutros("titulo_secao", "documentos", id_funcionario);
            info_T_zona.Text = con.consultarOutros("titulo_zona", "documentos", id_funcionario);
            info_cart_militar.Text = con.consultarOutros("cert_militar", "documentos", id_funcionario);
            infoCnh.Text = con.consultarOutros("cnh", "documentos", id_funcionario);
            infoCtps.Text = con.consultarOutros("ctps", "documentos", id_funcionario);
            info_ctps_serie.Text = con.consultarOutros("ctps_serie", "documentos", id_funcionario);

            // valores da tabela endereco_contato -------------------------------------------------------------------------------------
            InfoCep.Text = con.consultarOutros("cep", "endereco_contato", id_funcionario);
            infoRua.Text = con.consultarOutros("logradouro", "endereco_contato", id_funcionario);
            info_N_rua.Text = con.consultarOutros("numero", "endereco_contato", id_funcionario);
            infoBairro.Text = con.consultarOutros("bairro", "endereco_contato", id_funcionario);
            infoCidade.Text = con.consultarOutros("cidade", "endereco_contato", id_funcionario);
            cbEstado.Text = con.consultarOutros("estado", "endereco_contato", id_funcionario);
            infoCelular.Text = con.consultarOutros("celular", "endereco_contato", id_funcionario);
            InfoEmail.Text = con.consultarOutros("email", "endereco_contato", id_funcionario);

            // valores da tabela funcionarios_cargo------------------------------------------------------------------------------------------
            InfoSalario.Text = con.lerDadosFloat("salario", "funcionario_cargo",id_funcionario);
            InfoDataAdimssao.Text = con.lerDataCargo("data_inicio_cargo", "funcionario_cargo", id_funcionario);
            InfoDepartamento.Text = con.lerTableFuncionario_Departamento(id_funcionario);
            infoCargo.Text = con.lerTableFuncionario_Cargo(id_funcionario);


        }
        private void RegistroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void InfoRegistroNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            consultarRegistro();
        }

        private void barraConsultaFuncionario_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void barraConsultaFuncionario_VisibleChanged_1(object sender, EventArgs e)
        {
            Classes.ConexaoBd objConect = new Classes.ConexaoBd();
            string atributo = "nome";
            string entidade = "funcionario";
            barraConsultaFuncionario.DataSource = objConect.mostrarNoComboBox(atributo, entidade);
            barraConsultaFuncionario.ValueMember = atributo;
        }
    }
}
