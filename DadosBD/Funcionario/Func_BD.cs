using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using MySql.Data.MySqlClient;

namespace DadosBD
{
    public class Func_BD
    {
        public void ADD(Func_Dados ADDdados)
        {
            Conexao.AC();

            string sql = "insert into funcionario(id_funcao,id_banco,Nome,data_nasc,telefone,email,razao_social,t_Pessoa,RG,CPf,endereco,cep,cnh,cat,ctps,bairro,cidade,uf,agencia,conta) values (@id_funcao,@id_banco,@Nome,@data_nasc,@telefone,@email,@razao_social,@t_Pessoa,@RG,@CPf,@endereco,@cep,@cnh,@cat,@ctps,@bairro,@cidade,@uf,@agencia,@conta)";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_funcao = cmd.Parameters.Add("id_funcao", MySqlDbType.Int32);
                id_funcao.Value = ADDdados.id_funcao;

                MySqlParameter id_banco = cmd.Parameters.Add("id_banco", MySqlDbType.Int32);
                id_banco.Value = ADDdados.id_banco;

                MySqlParameter Nome = cmd.Parameters.Add("Nome", MySqlDbType.VarChar);
                Nome.Value = ADDdados.Nome;

                MySqlParameter data_nasc = cmd.Parameters.Add("data_nasc", MySqlDbType.Date);
                data_nasc.Value = ADDdados.data_nasc;

                MySqlParameter telefone = cmd.Parameters.Add("telefone", MySqlDbType.VarChar);
                telefone.Value = ADDdados.telefone;

                MySqlParameter email = cmd.Parameters.Add("email", MySqlDbType.VarChar);
                email.Value = ADDdados.email;

                MySqlParameter razao_social_Parameter = cmd.Parameters.Add("razao_social", MySqlDbType.VarChar);
                razao_social_Parameter.Value = ADDdados.razao_social;

                MySqlParameter t_Pessoa_Parameter = cmd.Parameters.Add("t_Pessoa", MySqlDbType.VarChar);
                t_Pessoa_Parameter.Value = ADDdados.t_pessoa;

                MySqlParameter RG = cmd.Parameters.Add("RG", MySqlDbType.VarChar);
                RG.Value = ADDdados.RG;

                MySqlParameter CPf = cmd.Parameters.Add("CPf", MySqlDbType.VarChar);
                CPf.Value = ADDdados.CPf;

                MySqlParameter endereco = cmd.Parameters.Add("endereco", MySqlDbType.VarChar);
                endereco.Value = ADDdados.endereco;

                MySqlParameter cep = cmd.Parameters.Add("cep", MySqlDbType.VarChar);
                cep.Value = ADDdados.cep;

                MySqlParameter cnh = cmd.Parameters.Add("cnh", MySqlDbType.VarChar);
                cnh.Value = ADDdados.cnh;

                MySqlParameter cat = cmd.Parameters.Add("cat", MySqlDbType.VarChar);
                cat.Value = ADDdados.cat;

                MySqlParameter ctps = cmd.Parameters.Add("ctps", MySqlDbType.VarChar);
                ctps.Value = ADDdados.ctps;

                MySqlParameter bairro = cmd.Parameters.Add("bairro", MySqlDbType.VarChar);
                bairro.Value = ADDdados.bairro;

                MySqlParameter cidade = cmd.Parameters.Add("cidade", MySqlDbType.VarChar);
                cidade.Value = ADDdados.cidade;

                MySqlParameter uf = cmd.Parameters.Add("uf", MySqlDbType.VarChar);
                uf.Value = ADDdados.uf;

                MySqlParameter agencia = cmd.Parameters.Add("agencia", MySqlDbType.VarChar);
                agencia.Value = ADDdados.agencia;

                MySqlParameter conta = cmd.Parameters.Add("conta", MySqlDbType.VarChar);
                conta.Value = ADDdados.conta;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
        }

            public void ALT(Func_Dados ALTdados)
            {
            Conexao.AC();
            string sql = "update funcionario set id_funcao = @id_funcao,id_banco = @id_banco,Nome = @Nome, data_nasc = @data_nasc,telefone = @telefone,email = @email,t_Pessoa = @t_Pessoa,razao_social = @razao_social,RG = @RG,CPf = @CPf,endereco = @endereco,cep= @cep,cnh = @cnh,cat = @cat,ctps = @ctps,bairro = @bairro,cidade = @cidade,uf = @uf,agencia = @agencia,conta = @conta where fun_id = @fun_id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter fun_id = cmd.Parameters.Add("fun_id", MySqlDbType.Int32);
                fun_id.Value = ALTdados.fun_id;

                MySqlParameter id_funcao = cmd.Parameters.Add("id_funcao", MySqlDbType.Int32);
                id_funcao.Value = ALTdados.id_funcao;

                MySqlParameter id_banco = cmd.Parameters.Add("id_banco", MySqlDbType.Int32);
                id_banco.Value = ALTdados.id_banco;

                MySqlParameter Nome = cmd.Parameters.Add("Nome", MySqlDbType.VarChar);
                Nome.Value = ALTdados.Nome;

                MySqlParameter data_nasc = cmd.Parameters.Add("data_nasc", MySqlDbType.DateTime);
                data_nasc.Value = ALTdados.data_nasc;

                MySqlParameter telefone = cmd.Parameters.Add("telefone", MySqlDbType.VarChar);
                telefone.Value = ALTdados.telefone;

                MySqlParameter email = cmd.Parameters.Add("email", MySqlDbType.VarChar);
                email.Value = ALTdados.email;

                MySqlParameter t_Pessoa_Parameter = cmd.Parameters.Add("t_Pessoa", MySqlDbType.VarChar);
                t_Pessoa_Parameter.Value = ALTdados.t_pessoa;

                MySqlParameter razao_social_Parameter = cmd.Parameters.Add("razao_social", MySqlDbType.VarChar);
                razao_social_Parameter.Value = ALTdados.razao_social;

                MySqlParameter RG = cmd.Parameters.Add("RG", MySqlDbType.VarChar);
                RG.Value = ALTdados.RG;

                MySqlParameter CPf = cmd.Parameters.Add("CPf", MySqlDbType.VarChar);
                CPf.Value = ALTdados.CPf;

                MySqlParameter endereco = cmd.Parameters.Add("endereco", MySqlDbType.VarChar);
                endereco.Value = ALTdados.endereco;

                MySqlParameter cep = cmd.Parameters.Add("cep", MySqlDbType.VarChar);
                cep.Value = ALTdados.cep;

                MySqlParameter cnh = cmd.Parameters.Add("cnh", MySqlDbType.VarChar);
                cnh.Value = ALTdados.cnh;

                MySqlParameter cat = cmd.Parameters.Add("cat", MySqlDbType.VarChar);
                cat.Value = ALTdados.cat;

                MySqlParameter ctps = cmd.Parameters.Add("ctps", MySqlDbType.VarChar);
                ctps.Value = ALTdados.ctps;

                MySqlParameter bairro = cmd.Parameters.Add("bairro", MySqlDbType.VarChar);
                bairro.Value = ALTdados.bairro;

                MySqlParameter cidade = cmd.Parameters.Add("cidade", MySqlDbType.VarChar);
                cidade.Value = ALTdados.cidade;

                MySqlParameter uf = cmd.Parameters.Add("uf", MySqlDbType.VarChar);
                uf.Value = ALTdados.uf;

                MySqlParameter agencia = cmd.Parameters.Add("agencia", MySqlDbType.VarChar);
                agencia.Value = ALTdados.agencia;

                MySqlParameter conta = cmd.Parameters.Add("conta", MySqlDbType.VarChar);
                conta.Value = ALTdados.conta;


                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
        }


            public void DEL(Func_Dados ALTdados)
            {
                Conexao.AC();

                string sql = "delete from funcionario where fun_id = @fun_id";
                using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                {
                    MySqlParameter fun_id = cmd.Parameters.Add("fun_id", MySqlDbType.Int32);
                    fun_id.Value = ALTdados.fun_id;

                    cmd.ExecuteNonQuery();

                    Conexao.FC();
                }

          }

            public Dados.Func_Dados BviaCod(int id)
            {
                Conexao.AC();
                Func_Dados funcionario = null;
                string sql = "select * from funcionario where fun_id = @fun_id";
                using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                {
                    MySqlParameter fun_id = cmd.Parameters.Add("fun_id", MySqlDbType.Int32);
                    fun_id.Value = id;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            funcionario = new Func_Dados();
                            funcionario.fun_id = reader.GetInt32("fun_id");
                            funcionario.id_funcao = reader.GetInt32("id_funcao");
                            funcionario.id_banco = reader.GetInt32("id_banco");
                            funcionario.Nome = reader.GetString("Nome");
                            funcionario.data_nasc = reader.GetDateTime("data_nasc");
                            funcionario.telefone = reader.GetString("telefone");
                            funcionario.email = reader.GetString("email");
                            funcionario.t_pessoa = reader.GetString("t_Pessoa");
                            funcionario.razao_social = reader.GetString("razao_social");
                            funcionario.RG = reader.GetString("RG");
                            funcionario.CPf = reader.GetString("CPf");
                            funcionario.endereco = reader.GetString("endereco");
                            funcionario.cep = reader.GetString("cep");
                            funcionario.cnh = reader.GetString("cnh");
                            funcionario.cat = reader.GetString("cat");
                            funcionario.ctps = reader.GetString("ctps");
                            funcionario.bairro = reader.GetString("bairro");
                            funcionario.cidade = reader.GetString("cidade");
                            funcionario.uf = reader.GetString("uf");
                            funcionario.agencia = reader.GetString("agencia");
                            funcionario.conta = reader.GetString("conta");

                        }
                        reader.Close();
                        reader.Dispose();
                    }

                    cmd.ExecuteNonQuery();

                    Conexao.FC();
                    return funcionario;
                }
            }

            public List<Func_Dados> Todos()
            {
                List<Func_Dados> funcionarios = new List<Func_Dados>();
                
                Conexao.AC();

                string sql = "select * from funcionario";
                using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Func_Dados funcionario = new Func_Dados();

                            funcionario.fun_id = reader.GetInt32("fun_id");
                            funcionario.id_funcao = reader.GetInt32("id_funcao");
                            funcionario.id_banco = reader.GetInt32("id_banco");
                            funcionario.Nome = reader.GetString("Nome");
                            funcionario.data_nasc = reader.GetDateTime("data_nasc");
                            funcionario.telefone = reader.GetString("telefone");
                            funcionario.email = reader.GetString("email");
                            funcionario.t_pessoa = reader.GetString("t_Pessoa");
                            funcionario.razao_social = reader.GetString("razao_social");
                            funcionario.RG = reader.GetString("RG");
                            funcionario.CPf = reader.GetString("CPf");
                            funcionario.endereco = reader.GetString("endereco");
                            funcionario.cep = reader.GetString("cep");
                            funcionario.cnh = reader.GetString("cnh");
                            funcionario.cat = reader.GetString("cat");
                            funcionario.ctps = reader.GetString("ctps");
                            funcionario.bairro = reader.GetString("bairro");
                            funcionario.cidade = reader.GetString("cidade");
                            funcionario.uf = reader.GetString("uf");
                            funcionario.agencia = reader.GetString("agencia");
                            funcionario.conta = reader.GetString("conta");
                            funcionarios.Add(funcionario);

                        }
                        reader.Close();
                        reader.Dispose();
                    }
                    
                }
                Conexao.FC();
                return funcionarios;
            }

            public List<Func_Dados> GetPorCodigo(int id)
            {
                List<Func_Dados> venda = new List<Func_Dados>();
                Conexao.AC();
                String sql = "Select * from funcionario where fun_id = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                {
                    MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                    idParameter.Value = id;
                    using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Func_Dados funcionario = new Func_Dados();
                            funcionario.fun_id = dataReader.GetInt32("fun_id");
                            funcionario.id_funcao = dataReader.GetInt32("id_funcao");
                            funcionario.id_banco = dataReader.GetInt32("id_banco");
                            funcionario.Nome = dataReader.GetString("Nome");
                            funcionario.data_nasc = dataReader.GetDateTime("data_nasc");
                            funcionario.telefone = dataReader.GetString("telefone");
                            funcionario.email = dataReader.GetString("email");
                            funcionario.t_pessoa = dataReader.GetString("t_Pessoa");
                            funcionario.razao_social = dataReader.GetString("razao_social");
                            funcionario.RG = dataReader.GetString("RG");
                            funcionario.CPf = dataReader.GetString("CPf");
                            funcionario.endereco = dataReader.GetString("endereco");
                            funcionario.cep = dataReader.GetString("cep");
                            funcionario.cnh = dataReader.GetString("cnh");
                            funcionario.cat = dataReader.GetString("cat");
                            funcionario.ctps = dataReader.GetString("ctps");
                            funcionario.bairro = dataReader.GetString("bairro");
                            funcionario.cidade = dataReader.GetString("cidade");
                            funcionario.uf = dataReader.GetString("uf");
                            funcionario.agencia = dataReader.GetString("agencia");
                            funcionario.conta = dataReader.GetString("conta");
                            venda.Add(funcionario);
                        }
                        dataReader.Close();
                        dataReader.Dispose();
                    }
                }
                Conexao.FC();
                return venda;
            }

            public List<Func_Dados> BviaNome(string nome)
            {
                Conexao.AC();
                List<Func_Dados> funcionarios = new List<Func_Dados>();
                string sql = "select * from funcionario where Nome like '%" + nome + "%';";
                using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Func_Dados funcionario = new Func_Dados();
                            funcionario.fun_id = reader.GetInt32("fun_id");
                            funcionario.id_funcao = reader.GetInt32("id_funcao");
                            funcionario.id_banco = reader.GetInt32("id_banco");
                            funcionario.Nome = reader.GetString("Nome");
                            funcionario.data_nasc = reader.GetDateTime("data_nasc");
                            funcionario.telefone = reader.GetString("telefone");
                            funcionario.email = reader.GetString("email");
                            funcionario.t_pessoa = reader.GetString("t_Pessoa");
                            funcionario.razao_social = reader.GetString("razao_social");
                            funcionario.RG = reader.GetString("RG");
                            funcionario.CPf = reader.GetString("CPf");
                            funcionario.endereco = reader.GetString("endereco");
                            funcionario.cep = reader.GetString("cep");
                            funcionario.cnh = reader.GetString("cnh");
                            funcionario.cat = reader.GetString("cat");
                            funcionario.ctps = reader.GetString("ctps");
                            funcionario.bairro = reader.GetString("bairro");
                            funcionario.cidade = reader.GetString("cidade");
                            funcionario.uf = reader.GetString("uf");
                            funcionario.agencia = reader.GetString("agencia");
                            funcionario.conta = reader.GetString("conta");
                            funcionarios.Add(funcionario);
                        }
                        reader.Close();
                        reader.Dispose();
                    }

                    cmd.ExecuteNonQuery();

                    Conexao.FC();
                    return funcionarios;
                }
            }

        public string GetFuncao(int id)
        {
            Conexao.AC();
            string Nome_Funcao = null;
            string sql = "Select desc_funcao from funcao where id_funcao = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql,Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = id;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Nome_Funcao = reader.GetString("desc_funcao");
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
            return Nome_Funcao;
        }

        public string GetBanco(int id)
        {
            Conexao.AC();
            string Nome_Funcao = null;
            string sql = "Select desc_banco from Banco where id_banco = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = id;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Nome_Funcao = reader.GetString("desc_banco");
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
            return Nome_Funcao;
        }
    }
}
