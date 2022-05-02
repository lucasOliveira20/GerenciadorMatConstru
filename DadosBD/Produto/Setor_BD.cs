using Dados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosBD
{
    public class Setor_BD
    {
        public void ADD(Setor_Dados ADDdados)
        {
            Conexao.AC();

            string sql = "insert into Setor(setor_produto,sub_setor_produto,tipo) values (@setor_produto,@sub_setor_produto,@tipo)";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter set = cmd.Parameters.Add("setor_produto", MySqlDbType.VarChar);
                set.Value = ADDdados.setor_produto;

                MySqlParameter sub = cmd.Parameters.Add("sub_setor_produto", MySqlDbType.VarChar);
                sub.Value = ADDdados.sub_setor_produto;

                MySqlParameter tipo = cmd.Parameters.Add("tipo", MySqlDbType.VarChar);
                tipo.Value = ADDdados.tipo;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }

        }

        public void ALT(Setor_Dados ALTdados)
        {
            Conexao.AC();

            string sql = "update Setor set setor_produto = @setor_produto, sub_setor_produto = @sub_setor_produto, tipo = @tipo where id_setor=@id_setor";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id = cmd.Parameters.Add("id_setor", MySqlDbType.Int32);
                id.Value = ALTdados.id_setor;

                MySqlParameter set = cmd.Parameters.Add("setor_produto", MySqlDbType.VarChar);
                set.Value = ALTdados.setor_produto;

                MySqlParameter sub = cmd.Parameters.Add("sub_setor_produto", MySqlDbType.VarChar);
                sub.Value = ALTdados.sub_setor_produto;

                MySqlParameter tipo = cmd.Parameters.Add("tipo", MySqlDbType.VarChar);
                tipo.Value = ALTdados.tipo;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }

        }

        public void DEL(Setor_Dados DELdados)
        {
            Conexao.AC();

            string sql = "delete from Setor where id_setor = @id_setor";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id = cmd.Parameters.Add("id_setor", MySqlDbType.Int32);
                id.Value = DELdados.id_setor;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }

        }

        public Dados.Setor_Dados BviaCod(int id)
        {
            Conexao.AC();
            Dados.Setor_Dados setor = null;
            string sql = "select * from Setor where id_setor = @id_setor";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_Parameter = cmd.Parameters.Add("id_setor", MySqlDbType.Int32);
                id_Parameter.Value = id;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        setor = new Setor_Dados();
                        setor.id_setor = reader.GetInt32("id_setor");
                        setor.setor_produto = reader.GetString("setor_produto");
                        setor.sub_setor_produto = reader.GetString("sub_setor_produto");
                        setor.tipo = reader.GetString("tipo");
                    }
                    reader.Close();
                    reader.Dispose();
                }

                cmd.ExecuteNonQuery();

                Conexao.FC();
                return setor;
            }
        }

        public Setor_Dados BviaNome(string nome)
        {
            Conexao.AC();
            Dados.Setor_Dados setor = null;
            string sql = "select * from setor where nome_fabricante like '%@nome_fabricante%'";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter setor_produto = cmd.Parameters.Add("setor_produto", MySqlDbType.VarChar);
                setor_produto.Value = nome;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        setor = new Setor_Dados();
                        setor.id_setor = reader.GetInt32("id_setor");
                        setor.setor_produto = reader.GetString("setor_produto");
                        setor.sub_setor_produto = reader.GetString("sub_setor_produto");
                        setor.tipo = reader.GetString("tipo");
                    }
                    reader.Close();
                    reader.Dispose();
                }

                cmd.ExecuteNonQuery();

                Conexao.FC();
                return setor;
            }
        }

        

        public List<Setor_Dados> Select()
        {
            List<Setor_Dados> setores = new List<Setor_Dados>();
            Setor_Dados setor = null;
            Conexao.AC();

            string sql = "select * from setor";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        setor = new Setor_Dados();
                        setor.id_setor = reader.GetInt32("id_setor");
                        setor.setor_produto = reader.GetString("setor_produto");
                        setor.sub_setor_produto = reader.GetString("sub_setor_produto");
                        setor.tipo = reader.GetString("tipo");
                        setores.Add(setor);


                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return setores;
        }

        public List<Setor_Dados> SelectbyCod(int cod)
        {
            List<Setor_Dados> setores = new List<Setor_Dados>();
            Setor_Dados setor = null;
            Conexao.AC();

            string sql = "select * from setor where id_setor = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = cod;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        setor = new Setor_Dados();
                        setor.id_setor = reader.GetInt32("id_setor");
                        setor.setor_produto = reader.GetString("setor_produto");
                        setor.sub_setor_produto = reader.GetString("sub_setor_produto");
                        setor.tipo = reader.GetString("tipo");
                        setores.Add(setor);


                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return setores;
        }

        public List<Setor_Dados> SelectbyDesc(string desc)
        {
            List<Setor_Dados> setores = new List<Setor_Dados>();
            Setor_Dados setor = null;
            Conexao.AC();

            string sql = "select * from setor where setor_produto like '%" + desc + "%';";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter descParameter = cmd.Parameters.Add("desc", MySqlDbType.VarChar);
                descParameter.Value = desc;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        setor = new Setor_Dados();
                        setor.id_setor = reader.GetInt32("id_setor");
                        setor.setor_produto = reader.GetString("setor_produto");
                        setor.sub_setor_produto = reader.GetString("sub_setor_produto");
                        setor.tipo = reader.GetString("tipo");
                        setores.Add(setor);


                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return setores;
        }
    }
}
