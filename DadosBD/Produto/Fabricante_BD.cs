using Dados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosBD.Produto
{
    public class Fabricante_BD
    {
        public void ADD(Fabricante_Dados ADDdados)
        {
            Conexao.AC();

            string sql = "insert into Fabricante(nome_fabricante,marca_fabricante) values (@nome_fabricante,@marca_fabricante)";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            { 
                 MySqlParameter nome = cmd.Parameters.Add("nome_fabricante", MySqlDbType.VarChar);
                 nome.Value = ADDdados.nome_fabricante;

                 MySqlParameter marca = cmd.Parameters.Add("marca_fabricante", MySqlDbType.VarChar);
                 marca.Value = ADDdados.marca_fabricante;

                 cmd.ExecuteNonQuery();

                 Conexao.FC();
            }
        
        }

        public void ALT(Fabricante_Dados ALTdados)
        {
            Conexao.AC();

            string sql = "update Fabricante set nome_fabricante = @nome_fabricante, marca_fabricante = @marca_fabricante where id_fabricante=@id_fabricante";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id = cmd.Parameters.Add("id_fabricante", MySqlDbType.Int32);
                id.Value = ALTdados.id_fabricante; 
                
                MySqlParameter nome = cmd.Parameters.Add("nome_fabricante", MySqlDbType.VarChar);
                nome.Value = ALTdados.nome_fabricante;

                MySqlParameter marca = cmd.Parameters.Add("marca_fabricante", MySqlDbType.VarChar);
                marca.Value = ALTdados.marca_fabricante;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }

        }

        public void DEL(Fabricante_Dados DELdados)
        {
            Conexao.AC();

            string sql = "delete from Fabricante where id_fabricante=@id_fabricante";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id = cmd.Parameters.Add("id_fabricante", MySqlDbType.Int32);
                id.Value = DELdados.id_fabricante;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }

        }

        public Dados.Fabricante_Dados BviaCod(int id)
        {
            Conexao.AC();
            Dados.Fabricante_Dados fabricante = null;
            string sql = "select * from Fabricante where id_fabricante = @id_fabricante";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_prod = cmd.Parameters.Add("id_fabricante", MySqlDbType.Int32);
                id_prod.Value = id;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        fabricante = new Fabricante_Dados();
                        fabricante.id_fabricante = reader.GetInt32("id_fabricante");
                        fabricante.nome_fabricante = reader.GetString("nome_fabricante");
                        fabricante.marca_fabricante = reader.GetString("marca_fabricante");
                    }
                    reader.Close();
                    reader.Dispose();
                }

                cmd.ExecuteNonQuery();

                Conexao.FC();
                return fabricante;
            }
        }

        public Fabricante_Dados BviaNome(string nome)
        {
            Conexao.AC();
            Dados.Fabricante_Dados fabricante = null;
            string sql = "select * from Fabricante where nome_fabricante like '%@fabricante%'";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter nome_fabricante = cmd.Parameters.Add("nome_fabricante", MySqlDbType.VarChar);
                nome_fabricante.Value = nome;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fabricante = new Fabricante_Dados();
                        fabricante.id_fabricante = reader.GetInt32("id_fabricante");
                        fabricante.nome_fabricante = reader.GetString("nome_fabricante");
                        fabricante.marca_fabricante = reader.GetString("marca_fabricante");
                    }
                    reader.Close();
                    reader.Dispose();
                }

                cmd.ExecuteNonQuery();

                Conexao.FC();
                return fabricante;
            }
        }

        public Fabricante_Dados BviaMarca(string marca)
        {
            Conexao.AC();
            Dados.Fabricante_Dados fabricante = null;
            string sql = "select * from Fabricante where marca_fabricante like '%@marca_fabricante%'";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter marca_fabricante = cmd.Parameters.Add("marca_fabricante", MySqlDbType.VarChar);
                marca_fabricante.Value = marca;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fabricante = new Fabricante_Dados();
                        fabricante.id_fabricante = reader.GetInt32("id_fabricante");
                        fabricante.nome_fabricante = reader.GetString("nome_fabricante");
                        fabricante.marca_fabricante = reader.GetString("marca_fabricante");
                    }
                    reader.Close();
                    reader.Dispose();
                }

                cmd.ExecuteNonQuery();

                Conexao.FC();
                return fabricante;
            }
        }

        public List<Fabricante_Dados> Select()
        {
            List<Fabricante_Dados> fabricantes = new List<Fabricante_Dados>();
            Fabricante_Dados fabricante = null;
            Conexao.AC();

            string sql = "select * from Fabricante";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fabricante = new Fabricante_Dados();

                        fabricante.id_fabricante = reader.GetInt32("id_fabricante");
                        fabricante.nome_fabricante = reader.GetString("nome_fabricante");
                        fabricante.marca_fabricante = reader.GetString("marca_fabricante");
                        fabricantes.Add(fabricante);


                    }
                    reader.Close();
                    reader.Dispose();
                }

                Conexao.FC();
            }
            return fabricantes;
        }

        public List<Fabricante_Dados> SelectbyCod(int cod)
        {
            List<Fabricante_Dados> fabricantes = new List<Fabricante_Dados>();
            Fabricante_Dados fabricante = null;
            Conexao.AC();

            string sql = "select * from Fabricante where id_fabricante = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = cod;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fabricante = new Fabricante_Dados();

                        fabricante.id_fabricante = reader.GetInt32("id_fabricante");
                        fabricante.nome_fabricante = reader.GetString("nome_fabricante");
                        fabricante.marca_fabricante = reader.GetString("marca_fabricante");
                        fabricantes.Add(fabricante);


                    }
                    reader.Close();
                    reader.Dispose();
                }

                Conexao.FC();
            }
            return fabricantes;
        }

        public List<Fabricante_Dados> SelectbyNome(string nome)
        {
            List<Fabricante_Dados> fabricantes = new List<Fabricante_Dados>();
            Fabricante_Dados fabricante = null;
            Conexao.AC();

            string sql = "select * from Fabricante where nome_fabricante like '%" + nome + "%';";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter nomeParameter = cmd.Parameters.Add("nome", MySqlDbType.VarChar);
                nomeParameter.Value = nome;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fabricante = new Fabricante_Dados();

                        fabricante.id_fabricante = reader.GetInt32("id_fabricante");
                        fabricante.nome_fabricante = reader.GetString("nome_fabricante");
                        fabricante.marca_fabricante = reader.GetString("marca_fabricante");
                        fabricantes.Add(fabricante);


                    }
                    reader.Close();
                    reader.Dispose();
                }

                Conexao.FC();
            }
            return fabricantes;
        }
        public List<Fabricante_Dados> SelectbyMarca(string marca)
        {
            List<Fabricante_Dados> fabricantes = new List<Fabricante_Dados>();
            Fabricante_Dados fabricante = null;
            Conexao.AC();

            string sql = "select * from Fabricante where marca_fabricante like '%" + marca + "%';";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fabricante = new Fabricante_Dados();

                        fabricante.id_fabricante = reader.GetInt32("id_fabricante");
                        fabricante.nome_fabricante = reader.GetString("nome_fabricante");
                        fabricante.marca_fabricante = reader.GetString("marca_fabricante");
                        fabricantes.Add(fabricante);


                    }
                    reader.Close();
                    reader.Dispose();
                }

                Conexao.FC();
            }
            return fabricantes;
        }
    }
}
