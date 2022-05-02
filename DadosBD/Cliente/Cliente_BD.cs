using Dados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosBD
{
    public class Cliente_BD
    {
        public void ADD(Cliente_Dados ADDdados)
        {
            Conexao.AC();

            string sql = "insert into cliente(Nome,data_nasc,telefone,email,RG,CPf,endereco,razao_social,t_Pessoa,cep,cidade,bairro,uf) values (@Nome,@data_nasc,@telefone,@email,@RG,@CPf,@endereco,@razao_social,@t_Pessoa,@cep,@cidade,@bairro,@uf)";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter Nome = cmd.Parameters.Add("Nome", MySqlDbType.VarChar);
                Nome.Value = ADDdados.Nome;

                MySqlParameter data_nasc = cmd.Parameters.Add("data_nasc", MySqlDbType.DateTime);
                data_nasc.Value = ADDdados.data_nasc;

                MySqlParameter telefone = cmd.Parameters.Add("telefone", MySqlDbType.VarChar);
                telefone.Value = ADDdados.telefone;

                MySqlParameter email = cmd.Parameters.Add("email", MySqlDbType.VarChar);
                email.Value = ADDdados.email;

                MySqlParameter RG = cmd.Parameters.Add("RG", MySqlDbType.VarChar);
                RG.Value = ADDdados.RG;

                MySqlParameter CPf = cmd.Parameters.Add("CPf", MySqlDbType.VarChar);
                CPf.Value = ADDdados.CPf;

                MySqlParameter endereco = cmd.Parameters.Add("endereco", MySqlDbType.VarChar);
                endereco.Value = ADDdados.endereco;

                MySqlParameter razao_social = cmd.Parameters.Add("razao_social", MySqlDbType.VarChar);
                razao_social.Value = ADDdados.razao_social;

                MySqlParameter t_Pessoa = cmd.Parameters.Add("t_Pessoa", MySqlDbType.VarChar);
                t_Pessoa.Value = ADDdados.t_Pessoa;

                MySqlParameter cep = cmd.Parameters.Add("cep", MySqlDbType.VarChar);
                cep.Value = ADDdados.cep;

                MySqlParameter cidade = cmd.Parameters.Add("cidade", MySqlDbType.VarChar);
                cidade.Value = ADDdados.cidade;

                MySqlParameter bairo = cmd.Parameters.Add("bairro", MySqlDbType.VarChar);
                bairo.Value = ADDdados.bairro;

                MySqlParameter uf = cmd.Parameters.Add("uf", MySqlDbType.VarChar);
                uf.Value = ADDdados.uf;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
        }

        public void ALT(Cliente_Dados ALTdados)
        {
            Conexao.AC();

            string sql = "update cliente set cli_id = @cli_id,Nome = @Nome,data_nasc = @data_nasc,telefone = @telefone,email = @email,RG = @RG,CPf = @CPf,endereco = @endereco,razao_social = @razao_social,t_Pessoa = @t_Pessoa,cep = @cep,cidade = @cidade,bairro = @bairro,uf = @uf where cli_id = @cli_id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id = cmd.Parameters.Add("cli_id", MySqlDbType.VarChar);
                id.Value = ALTdados.cli_id;

                MySqlParameter Nome = cmd.Parameters.Add("Nome", MySqlDbType.VarChar);
                Nome.Value = ALTdados.Nome;

                MySqlParameter data_nasc = cmd.Parameters.Add("data_nasc", MySqlDbType.DateTime);
                data_nasc.Value = ALTdados.data_nasc;

                MySqlParameter telefone = cmd.Parameters.Add("telefone", MySqlDbType.VarChar);
                telefone.Value = ALTdados.telefone;

                MySqlParameter email = cmd.Parameters.Add("email", MySqlDbType.VarChar);
                email.Value = ALTdados.email;

                MySqlParameter RG = cmd.Parameters.Add("RG", MySqlDbType.VarChar);
                RG.Value = ALTdados.RG;

                MySqlParameter CPf = cmd.Parameters.Add("CPf", MySqlDbType.VarChar);
                CPf.Value = ALTdados.CPf;

                MySqlParameter endereco = cmd.Parameters.Add("endereco", MySqlDbType.VarChar);
                endereco.Value = ALTdados.endereco;

                MySqlParameter razao_social = cmd.Parameters.Add("razao_social", MySqlDbType.VarChar);
                razao_social.Value = ALTdados.razao_social;

                MySqlParameter t_Pessoa = cmd.Parameters.Add("t_Pessoa", MySqlDbType.VarChar);
                t_Pessoa.Value = ALTdados.t_Pessoa;

                MySqlParameter cep = cmd.Parameters.Add("cep", MySqlDbType.VarChar);
                cep.Value = ALTdados.cep;

                MySqlParameter cidade = cmd.Parameters.Add("cidade", MySqlDbType.VarChar);
                cidade.Value = ALTdados.cidade;

                MySqlParameter bairo = cmd.Parameters.Add("bairro", MySqlDbType.VarChar);
                bairo.Value = ALTdados.bairro;

                MySqlParameter uf = cmd.Parameters.Add("uf", MySqlDbType.VarChar);
                uf.Value = ALTdados.uf;


                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
        }


        public void DEL(Cliente_Dados DELdados)
        {
            Conexao.AC();

            string sql = "delete from cliente where cli_id = @cli_id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter cli_id = cmd.Parameters.Add("cli_id", MySqlDbType.Int32);
                cli_id.Value = DELdados.cli_id;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }

        }

        public Dados.Cliente_Dados BviaCod(int id)
        {
            Conexao.AC();
            Cliente_Dados cliente = null;
            string sql = "select * from cliente where cli_id = @cli_id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter cli_id = cmd.Parameters.Add("cli_id", MySqlDbType.Int32);
                cli_id.Value = id;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cliente = new Cliente_Dados();
                        cliente.cli_id = reader.GetInt32("cli_id");
                        cliente.Nome = reader.GetString("Nome");
                        cliente.data_nasc = reader.GetDateTime("data_nasc");
                        cliente.telefone = reader.GetString("telefone");
                        cliente.email = reader.GetString("email");
                        cliente.RG = reader.GetString("RG");
                        cliente.CPf = reader.GetString("CPf");
                        cliente.endereco = reader.GetString("endereco");
                        cliente.razao_social = reader.GetString("razao_social");
                        cliente.t_Pessoa = reader.GetString("t_Pessoa");
                        cliente.cep = reader.GetString("cep");
                        cliente.cidade = reader.GetString("cidade");
                        cliente.bairro = reader.GetString("bairro");
                        cliente.uf = reader.GetString("uf");


                    }
                    reader.Close();
                    reader.Dispose();
                }

                cmd.ExecuteNonQuery();

                Conexao.FC();
                return cliente;
            }
        }

        public Cliente_Dados BviaNome(string nome)
        {
            Conexao.AC();
            Cliente_Dados cliente = null;
            string sql = "select * from cliente where Nome like '%@Nome%'";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter Nome = cmd.Parameters.Add("Nome", MySqlDbType.VarChar);
                Nome.Value = nome;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cliente = new Cliente_Dados();
                        cliente.cli_id = reader.GetInt32("cli_id");
                        cliente.Nome = reader.GetString("Nome");
                        cliente.data_nasc = reader.GetDateTime("data_nasc");
                        cliente.telefone = reader.GetString("telefone");
                        cliente.email = reader.GetString("email");
                        cliente.RG = reader.GetString("RG");
                        cliente.CPf = reader.GetString("CPf");
                        cliente.endereco = reader.GetString("endereco");
                        cliente.razao_social = reader.GetString("razao_social");
                        cliente.t_Pessoa = reader.GetString("t_Pessoa");
                        cliente.cep = reader.GetString("cep");
                        cliente.cidade = reader.GetString("cidade");
                        cliente.bairro = reader.GetString("bairro");
                        cliente.uf = reader.GetString("uf");
                        

                    }
                    reader.Close();
                    reader.Dispose();
                }

                cmd.ExecuteNonQuery();

                Conexao.FC();
                return cliente;
            }
        }

        public List<Cliente_Dados> Select()
        {
            List<Cliente_Dados> clientes = new List<Cliente_Dados>();
            Cliente_Dados cliente = null;
            Conexao.AC();

            string sql = "select * from cliente";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cliente = new Cliente_Dados();
                        cliente.cli_id = reader.GetInt32("cli_id");
                        cliente.Nome = reader.GetString("Nome");
                        cliente.data_nasc = reader.GetDateTime("data_nasc");
                        cliente.telefone = reader.GetString("telefone");
                        cliente.email = reader.GetString("email");
                        cliente.RG = reader.GetString("RG");
                        cliente.CPf = reader.GetString("CPf");
                        cliente.endereco = reader.GetString("endereco");
                        cliente.razao_social = reader.GetString("razao_social");
                        cliente.t_Pessoa = reader.GetString("t_Pessoa");
                        cliente.cep = reader.GetString("cep");
                        cliente.cidade = reader.GetString("cidade");
                        cliente.bairro = reader.GetString("bairro");
                        cliente.uf = reader.GetString("uf");
                        clientes.Add(cliente);
                       

                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return clientes;
        }

        public List<Cliente_Dados> SelectbyNome(string nome)
        {
            List<Cliente_Dados> clientes = new List<Cliente_Dados>();
            Cliente_Dados cliente = null;
            Conexao.AC();

            string sql = "select * from cliente where Nome like '%" + nome + "%';";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cliente = new Cliente_Dados();
                        cliente.cli_id = reader.GetInt32("cli_id");
                        cliente.Nome = reader.GetString("Nome");
                        cliente.data_nasc = reader.GetDateTime("data_nasc");
                        cliente.telefone = reader.GetString("telefone");
                        cliente.email = reader.GetString("email");
                        cliente.RG = reader.GetString("RG");
                        cliente.CPf = reader.GetString("CPf");
                        cliente.endereco = reader.GetString("endereco");
                        cliente.razao_social = reader.GetString("razao_social");
                        cliente.t_Pessoa = reader.GetString("t_Pessoa");
                        cliente.cep = reader.GetString("cep");
                        cliente.cidade = reader.GetString("cidade");
                        cliente.bairro = reader.GetString("bairro");
                        cliente.uf = reader.GetString("uf");
                        clientes.Add(cliente);


                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return clientes;
        }

        public List<Cliente_Dados> SelectbyCod(int id)
        {
            List<Cliente_Dados> clientes = new List<Cliente_Dados>();
            Cliente_Dados cliente = null;
            Conexao.AC();

            string sql = "select * from cliente where cli_id = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                    idParameter.Value = id;
                    while (reader.Read())
                    {
                        cliente = new Cliente_Dados();
                        cliente.cli_id = reader.GetInt32("cli_id");
                        cliente.Nome = reader.GetString("Nome");
                        cliente.data_nasc = reader.GetDateTime("data_nasc");
                        cliente.telefone = reader.GetString("telefone");
                        cliente.email = reader.GetString("email");
                        cliente.RG = reader.GetString("RG");
                        cliente.CPf = reader.GetString("CPf");
                        cliente.endereco = reader.GetString("endereco");
                        cliente.razao_social = reader.GetString("razao_social");
                        cliente.t_Pessoa = reader.GetString("t_Pessoa");
                        cliente.cep = reader.GetString("cep");
                        cliente.cidade = reader.GetString("cidade");
                        cliente.bairro = reader.GetString("bairro");
                        cliente.uf = reader.GetString("uf");
                        clientes.Add(cliente);


                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return clientes;
        }

    }
}
