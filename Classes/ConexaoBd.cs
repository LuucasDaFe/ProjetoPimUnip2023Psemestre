using Npgsql;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPimUnip2023Psemestre.Classes
{
    internal class ConexaoBd
    {
        NpgsqlConnection conex = new NpgsqlConnection();

        static string servidor = "localhost";
        static string bancoDeDados = "Pim";
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
            catch (NpgsqlException e)
            {
                MessageBox.Show("Não se pode conectar ao BD" + e.ToString());
            }
            finally
            {
                conex.Close();
            }
            return conex;
        }
        public NpgsqlConnection incitialize(string comando)
        {
            try
            {
                conex.ConnectionString = correnteConexao;
                conex.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("Não se pode conectar ao BD" + e.ToString());
            }
            finally
            {
                conex.Close();
            }
            return conex;
        }

        public DataTable mostrarNoComboBOx(string atributo, string entidade)
        {
            string comando = "SELECT " + atributo + " FROM " + entidade + ";";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);
            conex.Open();

            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable tabela = new DataTable();
            tabela.Load(reader);
            DataRow row = tabela.NewRow();
            row[atributo] = "";
            tabela.Rows.InsertAt(row, 0);

            conex.Close();
            return tabela;
        }
        string valor;
        public string consultarInfoFuncionario(string atributo, string entidade, string nome)
        {
            string comando = "SELECT " + atributo + " FROM " + entidade + " WHERE nome = @nome;";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

            conex.Open();
            cmd.Parameters.AddWithValue("@nome", nome);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    valor = reader.GetString(0).ToString();
                    // Faça o que você precisa com o nomeConjuge
                }
                else
                {
                    valor = "";
                    // Trate o caso em que o valor da coluna é nulo
                }
            }
            conex.Close();

            return valor;
        }
        public string consultaroutros(string atributo, string entidade, string id)
        {
            string comando = "SELECT " + atributo + " FROM " + entidade + " WHERE id_funcionario = @id_funcionario;";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

            conex.Open();
            cmd.Parameters.AddWithValue("@id_funcionario", Convert.ToInt32(id));
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    valor = reader.GetString(0).ToString();
                    // Faça o que você precisa com o nomeConjuge
                }
                else
                {
                    valor = "";
                    // Trate o caso em que o valor da coluna é nulo
                }
            }
            conex.Close();

            return valor;
        }
        public string consultaroutros_Int(string atributo, string entidade, string id)
        {
            string comando = "SELECT " + atributo + " FROM " + entidade + " WHERE id_funcionario = @id_funcionario;";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

            conex.Open();
            cmd.Parameters.AddWithValue("@id_funcionario", id);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    valor = reader.GetInt32(0).ToString();
                    // Faça o que você precisa com o nomeConjuge
                }
                else
                {
                    valor = "";
                    // Trate o caso em que o valor da coluna é nulo
                }
            }
            conex.Close();

            return valor;
        }
        public string consultarIdFuncionario(string nome)
        {
            conex.Close();
            string comando = "SELECT idfuncionario FROM funcionario WHERE nome = @nome;";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);


            cmd.Parameters.AddWithValue("@nome", nome);
            conex.Open();
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                valor = reader.GetInt32(0).ToString();
            }
            conex.Close();

            return valor;
        }
        public string lerDadosInt(string atributo, string entidade, string nome)
        {

            string comando = "SELECT " + atributo + " FROM " + entidade + " WHERE nome = @nome;";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

            conex.Open();
            cmd.Parameters.AddWithValue("@nome", nome);

            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                valor = reader.GetInt32(0).ToString();
            }
            conex.Close();

            return valor;
        }
        public int lerIdCargo(string idCargo)
        {
            int id;

            switch (idCargo)
            {
                case "ATENDENTE":
                    id = 1; return id;
                case "CHAPEIRO":
                    id = 2; return id;
                case "FAXINEIRO":
                    id = 3; return id;
                case "OPERADOR DE CAIXA":
                    id = 4; return id;
                case "GERENTE":
                    id = 5; return id;
                case "ENTREGADOR":
                    id = 6; return id;
                case "GARCOM":
                    id = 7; return id;
                default:
                    throw new ArgumentException("Cargo inválido: " + idCargo);
            }
        }
        public int lerIdDepartamento(string idDepartamento)
        {
            int id;

            switch (idDepartamento)
            {
                case "ATENDIMENTO":
                    id = 1;
                    return id;
                case "COZINHA":
                    id = 2;
                    return id;
                case "LIMPEZA":
                    id = 3;
                    return id;
                case "CAIXA":
                    id = 4;
                    return id;
                case "ESTOQUE":
                    id = 5;
                    return id;
                default:
                    throw new ArgumentException("Departamento inválido: " + idDepartamento);
            }
            
        }
        public string lerSexo(string sexo)
        {
            string x;
            switch (sexo)
            {
                case "MASCULINO":
                    x = "M"; return x;
                case "FEIMININO":
                    x = "F"; return x;
                default:
                    throw new ArgumentException("Sexo inválido: " + sexo);
            }
        }
        public string lerDadosFloat(string atributo, string entidade, string id)
        {

            string comando = "SELECT " + atributo + " FROM " + entidade + " WHERE id_funcionario = @id_funcionario;";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

            conex.Open();
            cmd.Parameters.AddWithValue("@id_funcionario", Convert.ToInt32(id));

            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    valor = reader.GetDouble(0).ToString();
                    // Faça o que você precisa com o nomeConjuge
                }
                else
                {
                    valor = "";
                    // Trate o caso em que o valor da coluna é nulo
                }
            }
            conex.Close();

            return valor;
        }
        public string lerTableFuncionario_Departamento(string idFuncionario)
        {

            using (NpgsqlConnection conex = new NpgsqlConnection(correnteConexao))
            {
                string comando = @"SELECT c.nome_cargo, d.nome_departamento
                           FROM funcionario_cargo fc
                           JOIN cargo c ON c.idcargo = fc.id_cargo
                           JOIN departamento d ON d.iddepartamento = fc.id_departamento
                           WHERE fc.id_funcionario = @idFuncionario;";
              
                conex.ConnectionString = correnteConexao;

                conex.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

                    cmd.Parameters.AddWithValue("@idFuncionario", Convert.ToInt32(idFuncionario));

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        string nomeCargo = "";
                        string nomeDepartamento = "";
                        if (reader.Read())
                        {
                            nomeCargo = reader.GetString(0);
                            nomeDepartamento = reader.GetString(1);

                            return nomeDepartamento;
                            // Use os valores do cargo e departamento conforme necessário
                        }
                        else
                        {
                            nomeCargo = "";
                        }
                    }
            }

            return ""; // Retornar um valor padrão caso o funcionário não seja encontrado
        }
        public string lerTableFuncionario_Cargo(string idFuncionario)
        {

                string comando = @"SELECT c.nome_cargo, d.nome_departamento
                           FROM funcionario_cargo fc
                           JOIN cargo c ON c.idcargo = fc.id_cargo
                           JOIN departamento d ON d.iddepartamento = fc.id_departamento
                           WHERE fc.id_funcionario = @idFuncionario;";

                conex.ConnectionString = correnteConexao;
                NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);
                conex.Open();

                cmd.Parameters.AddWithValue("@idFuncionario", Convert.ToInt32(idFuncionario));

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        string nomeCargo;
                        if (reader.Read())
                        {
                            nomeCargo = reader.GetString(0);
                            string nomeDepartamento = reader.GetString(1);

                            return nomeCargo;
                            // Use os valores do cargo e departamento conforme necessário
                        }
                        else
                        {
                            nomeCargo = "";
                        }
                    }
                

            return ""; // Retornar um valor padrão caso o funcionário não seja encontrado
        }
        public string lerDataCargo(string atributo, string entidade, string id)
        {

            string comando = "SELECT " + atributo + " FROM " + entidade + " WHERE id_funcionario = @id_funcionario;";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

            conex.Open();
            cmd.Parameters.AddWithValue("@id_funcionario", Convert.ToInt32(id));

            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    valor = reader.GetDateTime(0).ToString();
                    // Faça o que você precisa com o nomeConjuge
                }
                else
                {
                    valor = "";
                    // Trate o caso em que o valor da coluna é nulo
                }
            }
            conex.Close();

            return valor;
        }
        public string lerData(string atributo, string entidade, string nome)
        {
            string comando = "SELECT " + atributo + " FROM " + entidade + " WHERE nome = @nome;";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

            conex.Open();
            cmd.Parameters.AddWithValue("@nome", nome);

            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                valor = reader.GetDateTime(0).ToString();
            }
            conex.Close();

            return valor;
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

        string horaTrabalho;
        public DataTable mostrarRegistroHoras(string id_funcionario_cargo, string mes)
        {
            string comando = "SELECT hora_entrada, hora_saida, hora_intervalo_inicio, hora_intervalo_fim FROM registro WHERE EXTRACT(MONTH FROM data) = " + mes + " AND id_funcionario_cargo = " + id_funcionario_cargo + ";";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand conector = new NpgsqlCommand(comando, conex);
            conex.Open();
            conector.ExecuteNonQuery(); NpgsqlDataAdapter dados = new NpgsqlDataAdapter(conector);
            DataTable tabela = new DataTable();
            dados.Fill(tabela);
            conex.Close();
            return tabela;
        }
        public string verificaMesSelcionado(string mes)
        {
            string x;

            switch (mes)
            {
                case "JANEIRO":
                    x = "1"; return x;
                case "FEVEREIRO":
                    x = "2"; return x;
                case "MARÇO":
                    x = "3"; return x;
                case "ABRIL":
                    x = "4"; return x;
                case "MAIO":
                    x = "5"; return x;
                default:
                    throw new ArgumentException("Sexo inválido: " + mes);
            }

        }
        public string calcularRegistroHoras(string id_funcionario_cargo, string mes)
        {
            string comando = "SELECT hora_entrada, hora_saida, hora_intervalo_inicio, hora_intervalo_fim FROM registro WHERE AND WHERE MONTH(data) =" + mes + " id_funcionario = " + id_funcionario_cargo + ";";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);
            conex.Open();
            NpgsqlDataReader ler = cmd.ExecuteReader();

            TimeSpan tempo = TimeSpan.Zero;

            while (ler.Read())
            {
                TimeSpan entrada = ler.GetTimeSpan(0);
                TimeSpan saida = ler.GetTimeSpan(1);
                TimeSpan almoco = ler.GetTimeSpan(2);
                TimeSpan almoco2 = ler.GetTimeSpan(3);

                tempo += (saida - entrada) - (almoco2 - almoco);
                horaTrabalho = tempo.TotalHours.ToString();
            }

            conex.Close();
            return horaTrabalho;
        }
        public string calculaHora(string Id_funcionario)
        {
            
            string comandoH = "SELECT hora_entrada, hora_saida, hora_intervalo_inicio, hora_intervalo_fim FROM registro WHERE id_funcionario = "+ Id_funcionario + "; ";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comandoH, conex);
            conex.Open();
            NpgsqlDataReader ler = cmd.ExecuteReader();

            TimeSpan tempo = TimeSpan.Zero;

            while (ler.Read())
            {
                TimeSpan entrada = ler.GetTimeSpan(0);
                TimeSpan saida = ler.GetTimeSpan(1);
                TimeSpan almoco = ler.GetTimeSpan(2);
                TimeSpan almoco2 = ler.GetTimeSpan(3);
            
                tempo += (saida - entrada) - (almoco2 - almoco);
                horaTrabalho = tempo.TotalHours.ToString();               
            }

            conex.Close();
            return horaTrabalho;
        }

        float salarioHora;
        public float calculaSalario(string Id_funcionario)
        {

            string comandoH = "SELECT salario FROM registro WHERE id_funcionario = " + Id_funcionario + ";";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comandoH, conex);
            conex.Open();
            NpgsqlDataReader ler = cmd.ExecuteReader();

            float salarioX;

            while (ler.Read())
            {
                float salarioNoRegistro = ler.GetFloat(0);
                salarioX = salarioNoRegistro / 220;
                salarioHora = salarioX;
            }

            conex.Close();            
            return salarioHora;
        }
        public void adicionar_funcionario(string nome, string sexo, string nasci, string estado_civil, string conjuge,string escolaridade, string nacionalidade, string mae, string pai, string conta, string agencia)
        {
            string comando = "INSERT INTO funcionario(idfuncionario, nome, sexo, nascimento, estado_civil, nome_conjuge, escolaridade, nacionalidade, nome_mae, nome_pai, numeroconta, agencia) VALUES (@idfuncionario, @nome, @sexo, @nascimento, @estado_civil, @nome_conjuge, @escolaridade, @nacionalidade, @nome_mae, @nome_pai, @numeroconta, @agencia)";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

            int id_F = addQtdLinhas(); // Gerando Id do funcionario para table documentos
            string id_funcionario = id_F.ToString();
            conex.Open();
            cmd.Parameters.AddWithValue("@idfuncionario", Convert.ToInt32(id_funcionario));
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@sexo", Convert.ToChar(sexo));
            cmd.Parameters.AddWithValue("@nascimento", Convert.ToDateTime(nasci));
            cmd.Parameters.AddWithValue("@estado_civil", estado_civil);
            cmd.Parameters.AddWithValue("@nome_conjuge", conjuge);
            cmd.Parameters.AddWithValue("@escolaridade", escolaridade);
            cmd.Parameters.AddWithValue("@nacionalidade", nacionalidade);
            cmd.Parameters.AddWithValue("@nome_mae", mae);
            cmd.Parameters.AddWithValue("@nome_pai", pai);
            cmd.Parameters.AddWithValue("@numeroconta", conta);
            cmd.Parameters.AddWithValue("@agencia", agencia);

            cmd.ExecuteNonQuery();
            conex.Close();
        }
        public void adiciionar_funcionario_cargo(string salario, string id_departamento, string data_inicio_cargo, string id_cargo)
        {
            string comando = "INSERT INTO funcionario_cargo (salario, id_funcionario, id_departamento, data_inicio_cargo, id_cargo) VALUES (@salario, @id_funcionario, @id_departamento, @data_inicio_cargo, @id_cargo)";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);
            string id_funcionario = lerQtdLinhas().ToString();

            conex.Open();

            cmd.Parameters.AddWithValue("@salario", Convert.ToDouble(salario)); 
            cmd.Parameters.AddWithValue("@id_funcionario", Convert.ToInt32(id_funcionario)); 
            cmd.Parameters.AddWithValue("@id_departamento", Convert.ToInt32(id_departamento)); 
            cmd.Parameters.AddWithValue("@data_inicio_cargo", Convert.ToDateTime(data_inicio_cargo)); 
            cmd.Parameters.AddWithValue("@id_cargo", Convert.ToInt32(id_cargo));

            cmd.ExecuteNonQuery();
            conex.Close();

        }
        public void adicionar_documento(string cpf, string pis, string rg, string titulo_eleitor, string titulo_zona, string titulo_secao, string cert_militar, string cnh, string ctps, string ctps_serie, string id)
        {
            string comando = "INSERT INTO documentos (cpf, pis, rg, titulo_eleitor, titulo_zona, titulo_secao, cert_militar, cnh, ctps, ctps_serie, id_funcionario) VALUES (@cpf, @pis, @rg, @titulo_eleitor, @titulo_zona, @titulo_secao, @cert_militar, @cnh, @ctps, @ctps_serie, @id_funcionario)";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

            conex.Open();

            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@pis", pis);
            cmd.Parameters.AddWithValue("@rg", rg);
            cmd.Parameters.AddWithValue("@titulo_eleitor", titulo_eleitor);
            cmd.Parameters.AddWithValue("@titulo_zona", titulo_zona);
            cmd.Parameters.AddWithValue("@titulo_secao", titulo_secao);
            cmd.Parameters.AddWithValue("@cert_militar", cert_militar);
            cmd.Parameters.AddWithValue("@cnh", cnh);
            cmd.Parameters.AddWithValue("@ctps", ctps);
            cmd.Parameters.AddWithValue("@ctps_serie", ctps_serie);
            cmd.Parameters.AddWithValue("@id_funcionario", Convert.ToInt32(id));

            cmd.ExecuteNonQuery();
            conex.Close();

            conex.Close();
        }
        public void adicionar_endereco_contato(string cep, string logradouro, string numero, string bairro,string cidade, string estado, string celular,string email)
        {
            string comando = "INSERT INTO endereco_contato (cep, logradouro, numero, bairro, cidade, estado, celular,id_funcionario,email) VALUES (@cep, @logradouro, @numero, @bairro, @cidade, @estado, @celular,@id_funcionario, @email)";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);
            string id_funcionario = lerQtdLinhas().ToString();
            conex.Open();

            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@logradouro", logradouro);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@bairro", bairro);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@celular",celular);
            cmd.Parameters.AddWithValue("@id_funcionario", Convert.ToInt32(id_funcionario));
            cmd.Parameters.AddWithValue("@email", email);

            cmd.ExecuteNonQuery();
            conex.Close();

        }

        public void consultar_funcionarios(string nome, string sexo, string nasci, string estado_civil, string conjuge, string escolaridade, string nacionalidade, string mae, string pai, string conta, string agencia)
        {
            string comando = "SELECT nome, sexo, nascimento, estado_civil, nome_conjuge, escolaridade, nacionalidade, nome_mae, nome_pai, numeroconta, agencia FROM funcionario WHERE nome = @nome";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

            int id_F = addQtdLinhas(); // Gerando Id do funcionario para table documentos
            string id_funcionario = id_F.ToString();
            conex.Open();
        }
        public int lerQtdLinhas()
        {
            string comando = "SELECT COUNT(*) FROM funcionario;";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

            conex.Open();
            object result = cmd.ExecuteScalar();
            int valor = Convert.ToInt32(result);
            conex.Close();

            return valor;
        }
        public int addQtdLinhas()
        {
            string comando = "SELECT COUNT(*) FROM funcionario;";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

            conex.Open();
            object result = cmd.ExecuteScalar();
            int valor = Convert.ToInt32(result);
            conex.Close();

            return valor + 1;
        }
        public void verificandoAcesso(string usuario, string senha, string id_usuario)
        {
            int idFuncionario = Convert.ToInt32(id_usuario);
            string comando = "SELECT nome_usuario, senha FROM usuario_acesso WHERE id_funcionario = @id_funcionario";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);
            cmd.Parameters.AddWithValue("@id_funcionario", idFuncionario);

            try
            {
                conex.Open();
                NpgsqlDataReader reader = cmd.ExecuteReader();

                bool acessoConcedido = false;

                while (reader.Read())
                {
                    string user = reader.GetString(0);
                    string password = reader.GetString(1);

                    if (usuario == user && senha == password)
                    {
                        acessoConcedido = true;
                        break;
                    }
                }

                if (acessoConcedido)
                {
                    MessageBox.Show("Acesso concedido");
                }
                else
                {
                    MessageBox.Show("Credenciais inválidas");
                }
            }
            catch (NpgsqlException ex)
            {
                // Tratar exceção
                MessageBox.Show("Erro de banco de dados: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }
        }
        public string retornarIdLogin(string usuario)
        {
            conex.Close();
            string comando = "SELECT id_funcionario FROM usuario_acesso WHERE nome_usuario = @nome_usuario;";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);


            cmd.Parameters.AddWithValue("@nome_usuario", usuario);
            conex.Open();
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                valor = reader.GetInt32(0).ToString();
            }
            conex.Close();

            return valor;
        }
    }
}
