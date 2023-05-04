﻿using Npgsql;
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
    public partial class alteracao_funcionario : Form 
    {
        public alteracao_funcionario()
        {
            InitializeComponent();
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        public void alterarFuncionario(string nome)
        {
            NpgsqlConnection conex = new NpgsqlConnection();

            string server = "localhost";
            string bd = "sistemaholerite";
            string user = "postgres";
            string password = "cr7melhor";
            string port = "5432";

            string conectBDPim = "server=" + server + ";" + "port=" + port + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + bd + ";";

            string comando = "UPDATE funcionario SET email = @email, telefone = @telefone, endereco = @endereco, departamento = @departamento, cargo = @cargo, salario=@salario, conta_banco = @conta_banco, agencia_banco = @agencia_banco WHERE nome = @nome;";

            string email = AlterEmail.Text;
            string contato = alterContato.Text;
            string endereco = alterEndereco.Text;
            string departamento = alterDepartamento.Text;
            string cargo = alterCargo.Text;
            string salario = AlterSalario.Text;
            string conta_banco = AlterContabanco.Text;
            string agencia = alterAgencia.Text;

            conex.ConnectionString = conectBDPim;

            conex.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telefone", int.Parse(contato));
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@departamento", departamento);
            cmd.Parameters.AddWithValue("@cargo", cargo);
            cmd.Parameters.AddWithValue("@salario", Convert.ToSingle(salario));
            cmd.Parameters.AddWithValue("@conta_banco", Convert.ToInt32(conta_banco));
            cmd.Parameters.AddWithValue("@agencia_banco", agencia);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Alterações realizado com sucesso!");
            conex.Close();
        }
        public void pesquisarParaAlterar(string nome)
        {
            NpgsqlConnection conex = new NpgsqlConnection();

            string server = "localhost";
            string bd = "sistemaholerite";
            string user = "postgres";
            string password = "cr7melhor";
            string port = "5432";

            string conectBDPim = "server=" + server + ";" + "port=" + port + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + bd + ";";

            string comando = "SELECT nome, email, telefone, endereco, departamento, cargo, salario, conta_banco, agencia_banco FROM funcionario WHERE nome = @nome;";

            conex.ConnectionString = conectBDPim;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

            conex.Open();

            cmd.Parameters.AddWithValue("@nome", nome);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                nomeFuncionario.Text = reader.GetString(0);
                AlterEmail.Text = reader.GetString(1);
                alterContato.Text = reader.GetInt32(2).ToString();
                alterEndereco.Text = reader.GetString(3);
                alterDepartamento.Text = reader.GetString(4);
                alterCargo.Text = reader.IsDBNull(5) ? "" : reader.GetString(5);
                AlterSalario.Text = reader.GetFloat(6).ToString();
                AlterContabanco.Text = reader.GetInt32(7).ToString();
                alterAgencia.Text = reader.GetString(8);
            }

            conex.Close();
        }
        private void btnPesquisa_Alterar_Click(object sender, EventArgs e)
        {
            string nome = barraAlteraFuncio.Text;
            pesquisarParaAlterar(nome);
        }

        private void barraAlteraFuncio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nome = barraAlteraFuncio.Text;
            alterarFuncionario(nome);
        }
    }
}
