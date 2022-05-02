using Dados.Fornecedor;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosBD.Fornecedor
{
    public class Fornecedor_BD
    {
        public void ADD(Fornecedor_Dados ADDdados)
        {
            Conexao.AC();

            string sql = "insert into fornecedor(Nome,data_nasc,telefone,email,site,RG,CPf,endereco,razao_social,t_Pessoa,cnpj,cep,ins_Est,cidade,bairro,uf)values(@Nome,@data_nasc,@telefone,@email,@site,@RG,@CPf,@endereco,@razao_social,@t_Pessoa,@cnpj,@cep,@ins_Est,@cidade,@bairro,@uf)";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter nome_Parameter = cmd.Parameters.Add("Nome", MySqlDbType.VarChar);
                nome_Parameter.Value = ADDdados.Nome;
                MySqlParameter data_nasc_Parameter = cmd.Parameters.Add("data_nasc", MySqlDbType.VarChar);
                data_nasc_Parameter.Value = ADDdados.data_nasc;
                MySqlParameter telefone_Parameter = cmd.Parameters.Add("telefone", MySqlDbType.VarChar);
                telefone_Parameter.Value = ADDdados.Telefone;
                MySqlParameter email_Parameter = cmd.Parameters.Add("email", MySqlDbType.VarChar);
                email_Parameter.Value = ADDdados.Email;
                MySqlParameter site_Parameter = cmd.Parameters.Add("site", MySqlDbType.VarChar);
                site_Parameter.Value = ADDdados.site;
                MySqlParameter RG_Parameter = cmd.Parameters.Add("RG", MySqlDbType.VarChar);
                RG_Parameter.Value = ADDdados.RG;
                MySqlParameter CPf_Parameter = cmd.Parameters.Add("CPf", MySqlDbType.VarChar);
                CPf_Parameter.Value = ADDdados.CPF;
                MySqlParameter endereco_Parameter = cmd.Parameters.Add("endereco", MySqlDbType.VarChar);
                endereco_Parameter.Value = ADDdados.endereco;
                MySqlParameter razao_social_Parameter = cmd.Parameters.Add("razao_social", MySqlDbType.VarChar);
                razao_social_Parameter.Value = ADDdados.razao_social;
                MySqlParameter t_Pessoa_Parameter = cmd.Parameters.Add("t_Pessoa", MySqlDbType.VarChar);
                t_Pessoa_Parameter.Value = ADDdados.t_pessoa;
                MySqlParameter cnpj_Parameter = cmd.Parameters.Add("cnpj", MySqlDbType.VarChar);
                cnpj_Parameter.Value = ADDdados.cnpj;
                MySqlParameter cep_Parameter = cmd.Parameters.Add("cep", MySqlDbType.VarChar);
                cep_Parameter.Value = ADDdados.cep;
                MySqlParameter ins_Est_Parameter = cmd.Parameters.Add("ins_Est", MySqlDbType.VarChar);
                ins_Est_Parameter.Value = ADDdados.ins_Est;
                MySqlParameter cidade_Parameter = cmd.Parameters.Add("cidade", MySqlDbType.VarChar);
                cidade_Parameter.Value = ADDdados.cidade;
                MySqlParameter bairro_Parameter = cmd.Parameters.Add("bairro", MySqlDbType.VarChar);
                bairro_Parameter.Value = ADDdados.bairro;
                MySqlParameter uf_Parameter = cmd.Parameters.Add("uf", MySqlDbType.VarChar);
                uf_Parameter.Value = ADDdados.uf;


                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
        }
        public void DEL(Fornecedor_Dados DELdados)
        {
            Conexao.AC();

            string sql = "delete from fornecedor where for_id  = @for_id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter for_id_Parameter = cmd.Parameters.Add("for_id", MySqlDbType.Int32);
                for_id_Parameter.Value = DELdados.for_id;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
        }
        public void ALT(Fornecedor_Dados ALTdados)
        {
            Conexao.AC();

            string sql = "update fornecedor set Nome = @Nome,data_nasc = @data_nasc ,telefone = @telefone,email = @email,site = @site,RG = @RG,CPf = @CPf,endereco = @endereco,razao_social = @razao_social,t_Pessoa = @t_Pessoa,cnpj = @cnpj,cep = @cep,ins_Est = @ins_Est,cidade = @cidade,bairro = @bairro,uf = @uf where for_id  = @for_id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter for_id_Parameter = cmd.Parameters.Add("for_id", MySqlDbType.Int32);
                for_id_Parameter.Value = ALTdados.for_id;
                MySqlParameter nome_Parameter = cmd.Parameters.Add("Nome", MySqlDbType.VarChar);
                nome_Parameter.Value = ALTdados.Nome;
                MySqlParameter data_nasc_Parameter = cmd.Parameters.Add("data_nasc", MySqlDbType.VarChar);
                data_nasc_Parameter.Value = ALTdados.data_nasc;
                MySqlParameter telefone_Parameter = cmd.Parameters.Add("telefone", MySqlDbType.VarChar);
                telefone_Parameter.Value = ALTdados.Telefone;
                MySqlParameter email_Parameter = cmd.Parameters.Add("email", MySqlDbType.VarChar);
                email_Parameter.Value = ALTdados.Email;
                MySqlParameter site_Parameter = cmd.Parameters.Add("site", MySqlDbType.VarChar);
                site_Parameter.Value = ALTdados.site;
                MySqlParameter RG_Parameter = cmd.Parameters.Add("RG", MySqlDbType.VarChar);
                RG_Parameter.Value = ALTdados.RG;
                MySqlParameter CPf_Parameter = cmd.Parameters.Add("CPf", MySqlDbType.VarChar);
                CPf_Parameter.Value = ALTdados.CPF;
                MySqlParameter endereco_Parameter = cmd.Parameters.Add("endereco", MySqlDbType.VarChar);
                endereco_Parameter.Value = ALTdados.endereco;
                MySqlParameter razao_social_Parameter = cmd.Parameters.Add("razao_social", MySqlDbType.VarChar);
                razao_social_Parameter.Value = ALTdados.razao_social;
                MySqlParameter t_Pessoa_Parameter = cmd.Parameters.Add("t_Pessoa", MySqlDbType.VarChar);
                t_Pessoa_Parameter.Value = ALTdados.t_pessoa;
                MySqlParameter cnpj_Parameter = cmd.Parameters.Add("cnpj", MySqlDbType.VarChar);
                cnpj_Parameter.Value = ALTdados.cnpj;
                MySqlParameter cep_Parameter = cmd.Parameters.Add("cep", MySqlDbType.VarChar);
                cep_Parameter.Value = ALTdados.cep;
                MySqlParameter ins_Est_Parameter = cmd.Parameters.Add("ins_Est", MySqlDbType.VarChar);
                ins_Est_Parameter.Value = ALTdados.ins_Est;
                MySqlParameter cidade_Parameter = cmd.Parameters.Add("cidade", MySqlDbType.VarChar);
                cidade_Parameter.Value = ALTdados.cidade;
                MySqlParameter bairro_Parameter = cmd.Parameters.Add("bairro", MySqlDbType.VarChar);
                bairro_Parameter.Value = ALTdados.bairro;
                MySqlParameter uf_Parameter = cmd.Parameters.Add("uf", MySqlDbType.VarChar);
                uf_Parameter.Value = ALTdados.uf;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }

        }
        public Dados.Fornecedor.Fornecedor_Dados pesquisaViaCod(int id)
        {
            
            Conexao.AC();
            Fornecedor_Dados fornecedor = null;
            string sql = "select * from fornecedor where for_id = @for_id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter for_id_Parameter = cmd.Parameters.Add("for_id", MySqlDbType.Int32);
                for_id_Parameter.Value = id;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        fornecedor = new Fornecedor_Dados();
                        fornecedor.for_id = reader.GetInt32("for_id");
                        fornecedor.Nome = reader.GetString("Nome");
                        fornecedor.data_nasc = reader.GetString("data_nasc");
                        fornecedor.Telefone = reader.GetString("telefone");
                        fornecedor.Email = reader.GetString("email");
                        fornecedor.RG = reader.GetString("RG");
                        fornecedor.CPF = reader.GetString("CPf");
                        fornecedor.endereco = reader.GetString("endereco");
                        fornecedor.cep = reader.GetString("cep");
                        fornecedor.ins_Est = reader.GetString("ins_Est");
                        fornecedor.site = reader.GetString("site");
                        fornecedor.razao_social = reader.GetString("razao_social");
                        fornecedor.t_pessoa = reader.GetString("t_pessoa");
                        fornecedor.cnpj = reader.GetString("cnpj");
                        fornecedor.bairro = reader.GetString("bairro");
                        fornecedor.cidade = reader.GetString("cidade");
                        fornecedor.uf = reader.GetString("uf");

                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
                return fornecedor;
            }
        }

        public Fornecedor_Dados pesquisaViaNome(string nome)
        {
            Fornecedor_Dados fornecedor = null;
            Conexao.AC();

            string sql = "select * from fornecedor where Nome like '%@Nome%'";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter Nome_Parameter = cmd.Parameters.Add("Nome", MySqlDbType.Int32);
                Nome_Parameter.Value = nome;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fornecedor = new Fornecedor_Dados();
                        fornecedor.for_id = reader.GetInt32("for_id");
                        fornecedor.Nome = reader.GetString("Nome");
                        fornecedor.data_nasc = reader.GetString("data_nasc");
                        fornecedor.Telefone = reader.GetString("telefone");
                        fornecedor.Email = reader.GetString("email");
                        fornecedor.RG = reader.GetString("RG");
                        fornecedor.CPF = reader.GetString("CPf");
                        fornecedor.endereco = reader.GetString("endereco");
                        fornecedor.cep = reader.GetString("cep");
                        fornecedor.ins_Est = reader.GetString("ins_Est");
                        fornecedor.site = reader.GetString("site");
                        fornecedor.razao_social = reader.GetString("razao_social");
                        fornecedor.t_pessoa = reader.GetString("t_pessoa");
                        fornecedor.cnpj = reader.GetString("cnpj");
                        fornecedor.bairro = reader.GetString("bairro");
                        fornecedor.cidade = reader.GetString("cidade");
                        fornecedor.uf = reader.GetString("uf");

                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
                return fornecedor;
            }
        }

        public List<Fornecedor_Dados> Select()
        {
            List<Fornecedor_Dados> fornecedores = new List<Fornecedor_Dados>();
            Fornecedor_Dados fornecedor = null;
            Conexao.AC();

            string sql = "select * from fornecedor";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fornecedor = new Fornecedor_Dados();
                        fornecedor.for_id = reader.GetInt32("for_id");
                        fornecedor.Nome = reader.GetString("Nome");
                        fornecedor.data_nasc = reader.GetString("data_nasc");
                        fornecedor.Telefone = reader.GetString("telefone");
                        fornecedor.Email = reader.GetString("email");
                        fornecedor.RG = reader.GetString("RG");
                        fornecedor.CPF = reader.GetString("CPf");
                        fornecedor.endereco = reader.GetString("endereco");
                        fornecedor.cep = reader.GetString("cep");
                        fornecedor.ins_Est = reader.GetString("ins_Est");
                        fornecedor.site = reader.GetString("site");
                        fornecedor.razao_social = reader.GetString("razao_social");
                        fornecedor.t_pessoa = reader.GetString("t_pessoa");
                        fornecedor.cnpj = reader.GetString("cnpj");
                        fornecedor.bairro = reader.GetString("bairro");
                        fornecedor.cidade = reader.GetString("cidade");
                        fornecedor.uf = reader.GetString("uf");

                        fornecedores.Add(fornecedor);
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return fornecedores;
        }

        public List<Fornecedor_Dados> SelectbyCod(int cod)
        {
            List<Fornecedor_Dados> fornecedores = new List<Fornecedor_Dados>();
            Fornecedor_Dados fornecedor = null;
            Conexao.AC();

            string sql = "select * from fornecedor where for_id = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = cod;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fornecedor = new Fornecedor_Dados();
                        fornecedor.for_id = reader.GetInt32("for_id");
                        fornecedor.Nome = reader.GetString("Nome");
                        fornecedor.data_nasc = reader.GetString("data_nasc");
                        fornecedor.Telefone = reader.GetString("telefone");
                        fornecedor.Email = reader.GetString("email");
                        fornecedor.RG = reader.GetString("RG");
                        fornecedor.CPF = reader.GetString("CPf");
                        fornecedor.endereco = reader.GetString("endereco");
                        fornecedor.cep = reader.GetString("cep");
                        fornecedor.ins_Est = reader.GetString("ins_Est");
                        fornecedor.site = reader.GetString("site");
                        fornecedor.razao_social = reader.GetString("razao_social");
                        fornecedor.t_pessoa = reader.GetString("t_pessoa");
                        fornecedor.cnpj = reader.GetString("cnpj");
                        fornecedor.bairro = reader.GetString("bairro");
                        fornecedor.cidade = reader.GetString("cidade");
                        fornecedor.uf = reader.GetString("uf");

                        fornecedores.Add(fornecedor);
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return fornecedores;
        }

        public List<Fornecedor_Dados> SelectbyNome(string nome)
        {
            List<Fornecedor_Dados> fornecedores = new List<Fornecedor_Dados>();
            Fornecedor_Dados fornecedor = null;
            Conexao.AC();

            string sql = "select * from fornecedor where Nome like '%" + nome + "%';";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fornecedor = new Fornecedor_Dados();
                        fornecedor.for_id = reader.GetInt32("for_id");
                        fornecedor.Nome = reader.GetString("Nome");
                        fornecedor.data_nasc = reader.GetString("data_nasc");
                        fornecedor.Telefone = reader.GetString("telefone");
                        fornecedor.Email = reader.GetString("email");
                        fornecedor.RG = reader.GetString("RG");
                        fornecedor.CPF = reader.GetString("CPf");
                        fornecedor.endereco = reader.GetString("endereco");
                        fornecedor.cep = reader.GetString("cep");
                        fornecedor.ins_Est = reader.GetString("ins_Est");
                        fornecedor.site = reader.GetString("site");
                        fornecedor.razao_social = reader.GetString("razao_social");
                        fornecedor.t_pessoa = reader.GetString("t_pessoa");
                        fornecedor.cnpj = reader.GetString("cnpj");
                        fornecedor.bairro = reader.GetString("bairro");
                        fornecedor.cidade = reader.GetString("cidade");
                        fornecedor.uf = reader.GetString("uf");

                        fornecedores.Add(fornecedor);
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return fornecedores;
        }
    }
}
