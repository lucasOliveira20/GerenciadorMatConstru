using Dados.Agencia_Bancaria;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosBD.AgenciaBancaria
{
    public class AgBanq
    {
        public void ADD(BancoDados ADDdados)
        {
            Conexao.AC();

            string sql = "insert into Banco(desc_banco)values(@desc_banco)";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter desc_banco_Parameter = cmd.Parameters.Add("desc_banco", MySqlDbType.VarChar);
                desc_banco_Parameter.Value = ADDdados.desc_banco;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
        }

        public void ALT(BancoDados ALTdados)
        {
            Conexao.AC();

            string sql = "update Banco set desc_banco = @desc_banco where id_banco = @id_banco";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_banco_Parameter = cmd.Parameters.Add("id_banco", MySqlDbType.Int32);
                id_banco_Parameter.Value = ALTdados.id_banco;
                MySqlParameter desc_banco_Parameter = cmd.Parameters.Add("desc_banco", MySqlDbType.VarChar);
                desc_banco_Parameter.Value = ALTdados.desc_banco;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
        }
        public void DEL(BancoDados DELdados)
        {
            Conexao.AC();

            string sql = "delete from Banco where id_banco = @id_banco";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_banco_Parameter = cmd.Parameters.Add("id_banco", MySqlDbType.Int32);
                id_banco_Parameter.Value = DELdados.id_banco;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
        }
        public BancoDados pesquisaViaCodigo(int id)
        {
            Conexao.AC();

            BancoDados dados = null;
            string sql = "select * from Banco where id_banco = @id_banco";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {

                MySqlParameter id_banco_Parameter = cmd.Parameters.Add("id_banco", MySqlDbType.Int32);
                id_banco_Parameter.Value = id;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        dados = new BancoDados();
                        dados.id_banco = reader.GetInt32("id_banco");
                        dados.desc_banco = reader.GetString("desc_banco");
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
                return dados;
            }
        }
        public BancoDados pesquisaViaDesc(string desc)
        {
            Conexao.AC();

            BancoDados dados = null;

            string sql = "select * from Banco where desc_banco like '%" + desc + "%';";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        dados = new BancoDados();
                        dados.id_banco = reader.GetInt32("id_banco");
                        dados.desc_banco = reader.GetString("desc_banco");
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
                return dados;
            }

        }
        public List<BancoDados> Select()
        {
            Conexao.AC();

            BancoDados dados = null;
            List<BancoDados> dado = new List<BancoDados>();
            string sql = "select * from Banco";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        dados = new BancoDados();
                        dados.id_banco = reader.GetInt32("id_banco");
                        dados.desc_banco = reader.GetString("desc_banco");
                        dado.Add(dados);
                    }
                    reader.Close();
                    reader.Dispose();
                }
                

                Conexao.FC();
            }
            return dado;
        }

        public List<BancoDados> SelectbyNome(string nome)
        {
            Conexao.AC();

            BancoDados dados = null;
            List<BancoDados> dado = new List<BancoDados>();
            string sql = "select * from Banco where desc_banco like '%" + nome + "%';";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        dados = new BancoDados();
                        dados.id_banco = reader.GetInt32("id_banco");
                        dados.desc_banco = reader.GetString("desc_banco");
                        dado.Add(dados);
                    }
                    reader.Close();
                    reader.Dispose();
                }


                Conexao.FC();
            }
            return dado;
        }

        public List<BancoDados> SelectbyCodigo(int id)
        {
            Conexao.AC();

            BancoDados dados = null;
            List<BancoDados> dado = new List<BancoDados>();
            string sql = "select * from Banco where id_banco = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.VarChar);
                idParameter.Value = id;
                    

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        dados = new BancoDados();
                        dados.id_banco = reader.GetInt32("id_banco");
                        dados.desc_banco = reader.GetString("desc_banco");
                        dado.Add(dados);
                    }
                    reader.Close();
                    reader.Dispose();
                }


                Conexao.FC();
            }
            return dado;
        }
    }
}
