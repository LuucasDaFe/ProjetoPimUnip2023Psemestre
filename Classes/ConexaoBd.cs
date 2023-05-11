using iTextSharp.text.pdf.codec.wmf;
using Npgsql;
using System;
using System.Data;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        public DataTable mostrarNoComboBoxOutros(string atributo, string entidade)
        {
            string comando = "SELECT " + atributo + " FROM " + entidade + ";";
            DataTable tabela = new DataTable();

            try
            {
                conex.ConnectionString = correnteConexao;
                NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);
                conex.Open();

                NpgsqlDataReader reader = cmd.ExecuteReader();
                tabela.Load(reader);
                DataRow row = tabela.NewRow();
                row[atributo] = "";
                tabela.Rows.InsertAt(row, 0);
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                MessageBox.Show("Erro de banco de dados: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return tabela;
        }
        public DataTable mostrarNoComboBox(string atributo, string entidade)
        {
            string comando = "SELECT " + atributo + " FROM " + entidade + " WHERE ativo = true;";
            DataTable tabela = new DataTable();

            try
            {
                conex.ConnectionString = correnteConexao;
                NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);
                conex.Open();

                NpgsqlDataReader reader = cmd.ExecuteReader();
                tabela.Load(reader);
                DataRow row = tabela.NewRow();
                row[atributo] = "";
                tabela.Rows.InsertAt(row, 0);
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                MessageBox.Show("Erro de banco de dados: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return tabela;
        }
        string valor;
        public string consultarInfoFuncionario(string atributo, string entidade, string nome)
        {
            string comando = "SELECT " + atributo + " FROM " + entidade + " WHERE nome = @nome;";
            string valor = "";
            conex.Close();
            try
            {
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
                        // Faça o que você precisa com o valor retornado
                    }
                    else
                    {
                        valor = "";
                        // Trate o caso em que o valor da coluna é nulo
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Exiba uma mensagem de erro em uma caixa de diálogo
                MessageBox.Show("Erro de banco de dados: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return valor;
        }
        public string consultarOutros(string atributo, string entidade, string id)
        {
            string comando = "SELECT " + atributo + " FROM " + entidade + " WHERE id_funcionario = @id_funcionario;";
            string valor = "";

            try
            {
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
                        // Faça o que você precisa com o valor retornado
                    }
                    else
                    {
                        valor = "";
                        // Trate o caso em que o valor da coluna é nulo
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return valor;
        }
        public string consultarOutros_Int(string atributo, string entidade, string id)
        {
            string comando = "SELECT " + atributo + " FROM " + entidade + " WHERE id_funcionario = @id_funcionario;";
            string valor = "";

            try
            {
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
                        // Faça o que você precisa com o valor retornado
                    }
                    else
                    {
                        valor = "";
                        // Trate o caso em que o valor da coluna é nulo
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return valor;
        }
        public string consultarIdFuncionario(string nome)
        {
            string valor = "";

            try
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
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return valor;
        }
        public string lerDadosInt(string atributo, string entidade, string nome)
        {
            string valor = "";

            try
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
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return valor;
        }
        public string lerDadosHolerite(string atributo, string entidade, string id_cargo)
        {
            string valor = "";

            try
            {
                string comando = "SELECT " + atributo + " FROM " + entidade + " WHERE id_cargo = ;";
                conex.ConnectionString = correnteConexao;
                NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

                conex.Open();
                cmd.Parameters.AddWithValue("@id_cargo", id_cargo);

                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    valor = reader.GetInt32(0).ToString();
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return valor;
        }
        public string lerIdCargo(string idCargo)
        {
            string id;

            switch (idCargo)
            {
                case "ATENDENTE":
                    id = "1"; return id;
                case "CHAPEIRO":
                    id = "2"; return id;
                case "FAXINEIRO":
                    id = "3"; return id;
                case "OPERADOR DE CAIXA":
                    id = "4"; return id;
                case "GERENTE":
                    id = "5"; return id;
                case "ENTREGADOR":
                    id = "6"; return id;
                case "GARCOM":
                    id = "7"; return id;
                default:
                    throw new ArgumentException("Cargo inválido: " + idCargo);
            }
        }
        public string lerIdDepartamento(string idDepartamento)
        {
            string id;

            switch (idDepartamento)
            {
                case "ATENDIMENTO":
                    id = "1";
                    return id;
                case "COZINHA":
                    id = "2";
                    return id;
                case "LIMPEZA":
                    id = "3";
                    return id;
                case "CAIXA":
                    id = "4";
                    return id;
                case "ESTOQUE":
                    id = "5";
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
            string valor = "";

            try
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
                        // Faça o que você precisa com o valor retornado
                    }
                    else
                    {
                        valor = "";
                        // Trate o caso em que o valor da coluna é nulo
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return valor;
        }
        public string lerDadosFloatolerite(string atributo, string entidade, string id_cargo)
        {
            string valor = "";

            try
            {
                string comando = "SELECT " + atributo + " FROM " + entidade + " WHERE id_cargo = @id_cargo;";
                conex.ConnectionString = correnteConexao;
                NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

                conex.Open();
                cmd.Parameters.AddWithValue("@id_cargo", Convert.ToInt32(id_cargo));

                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        valor = reader.GetDouble(0).ToString();
                        // Faça o que você precisa com o valor retornado
                    }
                    else
                    {
                        valor = "";
                        // Trate o caso em que o valor da coluna é nulo
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return valor;
        }
        public string lerTableFuncionario_Departamento(string idFuncionario)
        {
            try
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
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }

            return ""; // Retornar um valor padrão caso ocorra uma exceção ou o funcionário não seja encontrado
        }
        public string lerTableFuncionario_Cargo(string idFuncionario)
        {
            try
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
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return ""; // Retornar um valor padrão caso ocorra uma exceção ou o funcionário não seja encontrado
        }
        public string lerDataCargo(string atributo, string entidade, string id)
        {
            try
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
                        // Faça o que você precisa com o valor da data
                    }
                    else
                    {
                        valor = "";
                        // Trate o caso em que o valor da coluna é nulo
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return valor;
        }

        public string lerData(string atributo, string entidade, string nome)
        {
            try
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
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return valor;
        }

        public DataTable incluirInfoDgvColaboradores(string comandoSql)
        {
            DataTable tabela = new DataTable();

            try
            {
                conex.ConnectionString = correnteConexao;
                NpgsqlCommand conector = new NpgsqlCommand(comandoSql, conex);
                conex.Open();

                NpgsqlDataAdapter dados = new NpgsqlDataAdapter(conector);
                dados.Fill(tabela);
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return tabela;
        }

        public DataTable pesquisarColaborador(string funcionario)
        {
            DataTable resultado = new DataTable();

            try
            {
                string comandoSql = "SELECT * FROM info_holerite_funcionarios where colaborador LIKE '%" + funcionario + "%';";
                conex.ConnectionString = correnteConexao;
                NpgsqlCommand conector = new NpgsqlCommand(comandoSql, conex);

                conex.Open();
                NpgsqlDataAdapter dados = new NpgsqlDataAdapter(conector);
                dados.Fill(resultado);
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return resultado;
        }


        string horaTrabalho;
        public DataTable mostrarRegistroHoras(string id_funcionario_cargo, string mes)
        {
            DataTable tabela = new DataTable();

            try
            {
                conex.Close();
                string comando = "SELECT * FROM registro WHERE EXTRACT(MONTH FROM data) = @mes AND id_funcionario_cargo = @id_funcionario_cargo;";
                conex.ConnectionString = correnteConexao;
                NpgsqlCommand conector = new NpgsqlCommand(comando, conex);

                conex.Open();
                conector.Parameters.AddWithValue("@mes", Convert.ToInt32(mes));
                conector.Parameters.AddWithValue("@id_funcionario_cargo", Convert.ToInt32(id_funcionario_cargo));

                NpgsqlDataAdapter dados = new NpgsqlDataAdapter(conector);
                dados.Fill(tabela);
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

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
                    throw new ArgumentException("Mês inválido: " + mes);
            }

        }
        public string calcularRegistroHoras(string id_funcionario_cargo, string mes)
        {
            string horaTrabalho = "";

            try
            {
                string comando = "SELECT hora_entrada, hora_intervalo_inicio, hora_intervalo_fim, hora_saida FROM registro WHERE EXTRACT(MONTH FROM data) = @mes AND id_funcionario_cargo = @id_funcionario_cargo";
                conex.ConnectionString = correnteConexao;
                NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);
                conex.Open();
                cmd.Parameters.AddWithValue("@mes", Convert.ToInt32(mes));
                cmd.Parameters.AddWithValue("@id_funcionario_cargo", Convert.ToInt32(id_funcionario_cargo));
                NpgsqlDataReader ler = cmd.ExecuteReader();

                TimeSpan tempo = TimeSpan.Zero;

                while (ler.Read())
                {
                    DateTimeOffset horaEntradaOffset = ler.GetFieldValue<DateTimeOffset>(0);
                    TimeSpan horaEntrada = horaEntradaOffset.TimeOfDay;

                    DateTimeOffset horaIntervaloInicioOffset = ler.GetFieldValue<DateTimeOffset>(1);
                    TimeSpan horaIntervaloInicio = horaIntervaloInicioOffset.TimeOfDay;

                    DateTimeOffset horaIntervaloFimOffset = ler.GetFieldValue<DateTimeOffset>(2);
                    TimeSpan horaIntervaloFim = horaIntervaloFimOffset.TimeOfDay;

                    DateTimeOffset horaSaidaOffset = ler.GetFieldValue<DateTimeOffset>(3);
                    TimeSpan horaSaida = horaSaidaOffset.TimeOfDay;

                    tempo += (horaSaida - horaEntrada) - (horaIntervaloFim - horaIntervaloInicio);
                    horaTrabalho = tempo.TotalHours.ToString();
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return horaTrabalho;
        }

        public string calculaHora(string Id_funcionario)
        {
            string horaTrabalho = "";

            try
            {
                string comandoH = "SELECT hora_entrada, hora_intervalo_inicio, hora_intervalo_fim, hora_saida FROM registro WHERE id_funcionario_cargo = @Id_funcionario;";
                conex.ConnectionString = correnteConexao;
                NpgsqlCommand cmd = new NpgsqlCommand(comandoH, conex);
                conex.Open();
                cmd.Parameters.AddWithValue("@Id_funcionario", Id_funcionario);
                NpgsqlDataReader ler = cmd.ExecuteReader();

                TimeSpan tempo = TimeSpan.Zero;

                while (ler.Read())
                {
                    DateTimeOffset horaEntradaOffset = ler.GetFieldValue<DateTimeOffset>(0);
                    TimeSpan horaEntrada = horaEntradaOffset.TimeOfDay;

                    DateTimeOffset horaIntervaloInicioOffset = ler.GetFieldValue<DateTimeOffset>(1);
                    TimeSpan horaIntervaloInicio = horaIntervaloInicioOffset.TimeOfDay;

                    DateTimeOffset horaIntervaloFimOffset = ler.GetFieldValue<DateTimeOffset>(2);
                    TimeSpan horaIntervaloFim = horaIntervaloFimOffset.TimeOfDay;

                    DateTimeOffset horaSaidaOffset = ler.GetFieldValue<DateTimeOffset>(3);
                    TimeSpan horaSaida = horaSaidaOffset.TimeOfDay;

                    tempo += (horaSaida - horaEntrada) - (horaIntervaloFim - horaIntervaloInicio);
                    horaTrabalho = tempo.TotalHours.ToString();
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return horaTrabalho;
        }

        float salarioHora;
        public float calculaSalario(string Id_funcionario)
        {
            float salarioHora = 0.0f;

            try
            {
                string comandoH = "SELECT salario FROM registro WHERE id_funcionario = @Id_funcionario;";
                conex.ConnectionString = correnteConexao;
                NpgsqlCommand cmd = new NpgsqlCommand(comandoH, conex);
                conex.Open();
                cmd.Parameters.AddWithValue("@Id_funcionario", Id_funcionario);
                NpgsqlDataReader ler = cmd.ExecuteReader();

                while (ler.Read())
                {
                    float salarioNoRegistro = ler.GetFloat(0);
                    salarioHora = salarioNoRegistro / 220;
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return salarioHora;
        }
        public void adicionar_funcionario(string nome, string sexo, string nasci, string estado_civil, string conjuge, string escolaridade, string nacionalidade, string mae, string pai, string conta, string agencia)
        {
            try
            {
                string comando = "INSERT INTO funcionario(idfuncionario, nome, sexo, nascimento, estado_civil, nome_conjuge, escolaridade, nacionalidade, nome_mae, nome_pai, numeroconta, agencia) VALUES (@idfuncionario, @nome, @sexo, @nascimento, @estado_civil, @nome_conjuge, @escolaridade, @nacionalidade, @nome_mae, @nome_pai, @numeroconta, @agencia)";
                conex.ConnectionString = correnteConexao;
                NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

                int id_F = addQtdLinhas(); // Gerando Id do funcionario para tabela documentos
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
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }
        }

        public void adiciionar_funcionario_cargo(string salario, string id_departamento, string data_inicio_cargo, string id_cargo)
        {
            try
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
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }
        }

        public void adicionar_documento(string cpf, string pis, string rg, string titulo_eleitor, string titulo_zona, string titulo_secao, string cert_militar, string cnh, string ctps, string ctps_serie, string id)
        {
            try
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
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }
        }

        public void adicionar_endereco_contato(string cep, string logradouro, string numero, string bairro, string cidade, string estado, string celular, string email)
        {
            try
            {
                string comando = "INSERT INTO endereco_contato (cep, logradouro, numero, bairro, cidade, estado, celular, id_funcionario, email) VALUES (@cep, @logradouro, @numero, @bairro, @cidade, @estado, @celular, @id_funcionario, @email)";
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
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@id_funcionario", Convert.ToInt32(id_funcionario));
                cmd.Parameters.AddWithValue("@email", email);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }
        }


        public void consultar_funcionarios(string nome)
        {
            try
            {
                string comando = "SELECT nome, sexo, nascimento, estado_civil, nome_conjuge, escolaridade, nacionalidade, nome_mae, nome_pai, numeroconta, agencia FROM funcionario WHERE nome = @nome";
                conex.ConnectionString = correnteConexao;
                NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

                cmd.Parameters.AddWithValue("@nome", nome);

                conex.Open();

                // Restante do código para executar a consulta e lidar com os resultados

            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }
        }

        public int lerQtdLinhas()
        {
            string comando = "SELECT COUNT(*) FROM funcionario;";
            int valor = 0;

            try
            {
                conex.ConnectionString = correnteConexao;
                NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);
                conex.Open();

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    valor = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

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

        //------------------------------------------------------------
        public string consultaDadosFuncionario(string atributo, string idfuncionario)
        {
            string comando = "SELECT " + atributo + " FROM funcionario WHERE idfuncionario = @idfuncionario;";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);
            string valor = "";

            try
            {
                conex.Open();
                cmd.Parameters.AddWithValue("@idfuncionario", Convert.ToInt32(idfuncionario));
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
                        // Trate o caso em que o valor da coluna é nulo
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção de acordo com suas necessidades
                Console.WriteLine("Ocorreu um erro durante a consulta: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return valor;
        }

        public string consultaDadosEnderecoContato(string atributo, string idendereco_contato)
        {
            string comando = "SELECT " + atributo + " FROM endereco_contato WHERE idendereco_contato = @idendereco_contato;";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);
            string valor = "";
            conex.Close();
            try
            {
                conex.Open();
                cmd.Parameters.AddWithValue("@idendereco_contato", Convert.ToInt32(idendereco_contato));
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
                        // Trate o caso em que o valor da coluna é nulo
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção de acordo com suas necessidades
                Console.WriteLine("Ocorreu um erro durante a consulta: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return valor;
        }
        public string consultaCargo(string id_funcionario)
        {
            string comando = "SELECT c.nome_cargo FROM funcionario_cargo fc JOIN cargo c ON fc.id_cargo = c.idcargo WHERE fc.id_funcionario = @id_funcionario;";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);
            string valor = "";

            try
            {
                conex.Open();
                cmd.Parameters.AddWithValue("@id_funcionario", Convert.ToInt32(id_funcionario));
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
                        // Trate o caso em que o valor da coluna é nulo
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção de acordo com suas necessidades
                Console.WriteLine("Ocorreu um erro durante a consulta: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return valor;
        }

        public string consultaDepartamento(string id_funcionario)
        {
            string comando = "SELECT d.nome_departamento FROM funcionario_cargo fc JOIN departamento d ON fc.id_departamento = d.iddepartamento WHERE fc.id_funcionario = @id_funcionario;";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);
            string valor = "";

            try
            {
                conex.Open();
                cmd.Parameters.AddWithValue("@id_funcionario", Convert.ToInt32(id_funcionario));
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
                        // Trate o caso em que o valor da coluna é nulo
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção de acordo com suas necessidades
                Console.WriteLine("Ocorreu um erro durante a consulta: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return valor;
        }
        public string consultaSalario(string id_funcionario)
        {
            string comando = "SELECT salario FROM funcionario_cargo WHERE id_funcionario = @id_funcionario;";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);
            string valor = "";

            try
            {
                conex.Open();
                cmd.Parameters.AddWithValue("@id_funcionario", Convert.ToInt32(id_funcionario));
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
                        // Trate o caso em que o valor da coluna é nulo
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção de acordo com suas necessidades
                Console.WriteLine("Ocorreu um erro durante a consulta: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return valor;
        }

        public void iniciaDemissao(string idfuncionario, string motivo_deligamento)
        {
            string comando = "UPDATE funcionario SET ativo = false, motivo_deligamento = @motivo_deligamento WHERE idfuncionario = @idfuncionario;";

            using (NpgsqlConnection conex = new NpgsqlConnection(correnteConexao))
            {
                conex.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(comando, conex))
                {
                    cmd.Parameters.AddWithValue("@idfuncionario", Convert.ToInt32(idfuncionario));
                    cmd.Parameters.AddWithValue("@motivo_deligamento", motivo_deligamento);
                    cmd.ExecuteNonQuery();
                }

                conex.Close();
            }

            MessageBox.Show("Demissão concluída!");
        }
        public void alterDadosBanco(string idfuncionario, string numeroconta, string agencia)
        {
            string comando = "UPDATE funcionario SET numeroconta = @numeroconta, agencia = @agencia WHERE idfuncionario = @idfuncionario;";

            using (NpgsqlConnection conex = new NpgsqlConnection(correnteConexao))
            {
                conex.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(comando, conex))
                {
                    cmd.Parameters.AddWithValue("@idfuncionario", Convert.ToInt32(idfuncionario));
                    cmd.Parameters.AddWithValue("@numeroconta", numeroconta);
                    cmd.Parameters.AddWithValue("@agencia", agencia);
                    cmd.ExecuteNonQuery();
                }

                conex.Close();
            }
        }

        public void alterdadoEndereco_contato(string id_funcionario, string logradouro, string numero, string bairro, string cidade, string celular, string email, string cep)
        {
            string comando = "UPDATE endereco_contato SET logradouro = @logradouro, numero = @numero, bairro = @bairro, cidade = @cidade, celular = @celular, email = @email, cep = @cep WHERE id_funcionario = @id_funcionario;";
            conex.Close();

            using (NpgsqlConnection conex = new NpgsqlConnection(correnteConexao))
            {
                conex.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(comando, conex))
                {
                    cmd.Parameters.AddWithValue("@id_funcionario", Convert.ToInt32(id_funcionario));
                    cmd.Parameters.AddWithValue("@logradouro", logradouro);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@bairro", bairro);
                    cmd.Parameters.AddWithValue("@cidade", cidade);
                    cmd.Parameters.AddWithValue("@celular", celular);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@cep", cep);
                    cmd.ExecuteNonQuery();
                }

                conex.Close();
            }
        }

        public void alterarCargoDepartamento(string idFuncionario, string novoCargo, string novoDepartamento)
        {
            using (NpgsqlConnection conex = new NpgsqlConnection(correnteConexao))
            {
                conex.Open();

                // Atualizar o cargo do funcionário na tabela funcionario_cargo
                string comandoAtualizarCargo = "UPDATE funcionario_cargo SET id_cargo = @novoCargo WHERE id_funcionario = @idFuncionario;";
                using (NpgsqlCommand cmdAtualizarCargo = new NpgsqlCommand(comandoAtualizarCargo, conex))
                {
                    cmdAtualizarCargo.Parameters.AddWithValue("@novoCargo", Convert.ToInt32(novoCargo));
                    cmdAtualizarCargo.Parameters.AddWithValue("@idFuncionario", Convert.ToInt32(idFuncionario));
                    cmdAtualizarCargo.ExecuteNonQuery();
                }

                // Atualizar o departamento do funcionário na tabela funcionario_cargo
                string comandoAtualizarDepartamento = "UPDATE funcionario_cargo SET id_departamento = @novoDepartamento WHERE id_funcionario = @id_Funcionario;";
                using (NpgsqlCommand cmdAtualizarDepartamento = new NpgsqlCommand(comandoAtualizarDepartamento, conex))
                {
                    cmdAtualizarDepartamento.Parameters.AddWithValue("@novoDepartamento", Convert.ToInt32(novoDepartamento));
                    cmdAtualizarDepartamento.Parameters.AddWithValue("@id_Funcionario", Convert.ToInt32(idFuncionario));
                    cmdAtualizarDepartamento.ExecuteNonQuery();
                }

                conex.Close();
            }

            MessageBox.Show("Alteração concluída!");
        }
        //*************************************************************************** Acesso ao usuario

        public void addAcesso(string nivel_acesso, string senha, string nome_usuario)
        {
            try
            {
                string comando = "INSERT INTO usuario_acesso (id_funcionario, nivel_acesso, senha, nome_usuario) VALUES (@id_funcionario, @nivel_acesso, @senha, @nome_usuario)";
                conex.ConnectionString = correnteConexao;
                NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);
                string id_funcionario = lerQtdLinhas().ToString();
                conex.Open();

                cmd.Parameters.AddWithValue("@id_funcionario", Convert.ToInt32(id_funcionario));
                cmd.Parameters.AddWithValue("@nivel_acesso", Convert.ToInt32(nivel_acesso));
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@nome_usuario", nome_usuario);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }
        }

        public void validaAcesso(string usuario, string senha)
        {
            string comando = "SELECT nivel_acesso, senha, nome_usuario FROM usuario_acesso;";
            string user = "";
            string pass = "";
            int nivel = 0;
            conex.Close();
            try
            {
                conex.ConnectionString = correnteConexao;
                NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

                conex.Open();
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    nivel = reader.GetInt32(0);
                    pass = reader.GetString(1);
                    user = reader.GetString(2);

                    if (senha == pass && usuario == user )
                    {
                        abrirForms(nivel);
                    }
                    else
                    {
                        MessageBox.Show("Senha ou usuario invalido");
                    }
                   
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Exiba uma mensagem de erro em uma caixa de diálogo
                MessageBox.Show("Erro de banco de dados: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }
        }
        public void abrirForms(int nivel)
        {
            if(nivel == 2)
            {
                Painel_Inicio painel_ = new Painel_Inicio();
                painel_.ShowDialog();
            }
            else if(nivel == 1)
            {
                Form_funcionario_acessar user = new Form_funcionario_acessar();
                user.ShowDialog();
            }
        }
        public string verificaIdLogin(string nome_usuario, string senha)
        {
            string comando = "SELECT id_funcionario FROM usuario_acesso WHERE senha = @senha AND nome_usuario = @nome_usuario";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@nome_usuario", nome_usuario);
            string id = "";
            try
            {
                conex.Open();
                NpgsqlDataReader reader = cmd.ExecuteReader();

                bool acessoConcedido = false;

                while (reader.Read())
                {
                    id = reader.GetString(0);

                    
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
            return id;
        }
        public string verificaIdCargo(string id_funcionario)
        {
            string comando = "SELECT id_cargo FROM funcionario_cargo WHERE id_funcionario = @id_funcionario";
            conex.ConnectionString = correnteConexao;
            NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);
            cmd.Parameters.AddWithValue("@id_funcionario", Convert.ToInt32(id_funcionario));
            string id = "";
            try
            {
                conex.Open();
                NpgsqlDataReader reader = cmd.ExecuteReader();

                bool acessoConcedido = false;

                while (reader.Read())
                {
                    id = reader.GetInt32(0).ToString();
                }
            }
            catch (NpgsqlException ex)
            {
                // Tratar exceção
               // MessageBox.Show("Erro de banco de dados: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }
            return id;
        }
        //*********************************************************************************************

        public string mostrarMesHolerite(string id_cargo, string mes)
        {
            string n = "";
            try
            {
                conex.Close();
                string comando = "SELECT * FROM holerite WHERE EXTRACT(MONTH FROM data) = @mes AND id_cargo = @id_cargo;";
                conex.ConnectionString = correnteConexao;
                NpgsqlCommand cmd = new NpgsqlCommand(comando, conex);

                conex.Open();
                cmd.Parameters.AddWithValue("@mes", Convert.ToInt32(mes));
                cmd.Parameters.AddWithValue("@id_cargo", Convert.ToInt32(id_cargo));
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    n = reader.GetDateTime(0).ToString();
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção aqui de acordo com suas necessidades
                // Por exemplo, você pode registrar ou exibir uma mensagem de erro
                //Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return n;
        }

    }
}
