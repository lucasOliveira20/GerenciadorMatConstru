using Dados.Localização;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosBD.Localizacao
{
    public class Localizacao_BD
    {
        public void ADD(Localizacao_Dados ADDdados)
        {
            Conexao.AC();

            string sql = "insert into Localizacao_Prod(Corredor,partilhera,gaveta) values (@Corredor,@partilhera,@gaveta)";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter Corretor_Pararameter = cmd.Parameters.Add("Corredor", MySqlDbType.VarChar);
                Corretor_Pararameter.Value = ADDdados.corredor;

                MySqlParameter pratileira_Parameter = cmd.Parameters.Add("partilhera", MySqlDbType.VarChar);
                pratileira_Parameter.Value = ADDdados.pratileira;

                MySqlParameter gaveta = cmd.Parameters.Add("gaveta", MySqlDbType.VarChar);
                gaveta.Value = ADDdados.gaveta;
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
        }
        public void ALT(Localizacao_Dados ALTdados)
        {
            Conexao.AC();

            string sql = "update Localizacao_Prod set Corredor = @Corredor, partilhera = @partilhera, gaveta = @gaveta where id_loc = @id_loc";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_loc_Parameter = cmd.Parameters.Add("id_loc", MySqlDbType.Int32);
                id_loc_Parameter.Value = ALTdados.id_loc;

                MySqlParameter Corretor_Pararameter = cmd.Parameters.Add("Corredor", MySqlDbType.VarChar);
                Corretor_Pararameter.Value = ALTdados.corredor;

                MySqlParameter pratileira_Parameter = cmd.Parameters.Add("partilhera", MySqlDbType.VarChar);
                pratileira_Parameter.Value = ALTdados.pratileira;

                MySqlParameter gaveta = cmd.Parameters.Add("gaveta", MySqlDbType.VarChar);
                gaveta.Value = ALTdados.gaveta;

                cmd.ExecuteNonQuery();
                Conexao.FC();
            }
        }
        public void DEL(Localizacao_Dados DELdados)
        {
            Conexao.AC();

            string sql = "delete from Localizacao_Prod where id_loc = @id_loc";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_loc_Parameter = cmd.Parameters.Add("id_loc", MySqlDbType.Int32);
                id_loc_Parameter.Value = DELdados.id_loc;

                cmd.ExecuteNonQuery();
                Conexao.FC();
            }
        }

        public Dados.Localização.Localizacao_Dados pesquisaViaCOD(int id)
        {

            Conexao.AC();

            Dados.Localização.Localizacao_Dados localizacao = null;
            string sql = "select * from Localizacao_Prod where id_loc = @id_loc";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_loc_Parameter = cmd.Parameters.Add("id_loc", MySqlDbType.Int32);
                id_loc_Parameter.Value = id;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        localizacao = new Dados.Localização.Localizacao_Dados();
                        localizacao.id_loc = reader.GetInt32("id_loc");
                        localizacao.corredor = reader.GetString("Corredor");
                        localizacao.pratileira = reader.GetString("partilhera");
                        localizacao.gaveta = reader.GetString("gaveta");

                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();
                Conexao.FC();
                return localizacao;
            }

        }
        public Localizacao_Dados pesquisaViaCorredor(string corredor)
        {
            Conexao.AC();

            Localizacao_Dados localizacao = null;
            string sql = "select * Localizacao_Prod where Corredor like '%" + corredor +"%';";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
               // MySqlParameter id_loc_Parameter = cmd.Parameters.Add("id_loc", MySqlDbType.Int32);
                //id_loc_Parameter.Value = corredor;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        localizacao = new Localizacao_Dados();
                        localizacao.id_loc = reader.GetInt32("id_loc");
                        localizacao.corredor = reader.GetString("Corredor");
                        localizacao.pratileira = reader.GetString("partilhera");
                        localizacao.gaveta = reader.GetString("gaveta");

                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteReader();
                Conexao.FC();
                return localizacao;
            }
        }

        public Localizacao_Dados pesquisaViaPratileira(string pratilheira)
        {
            Conexao.AC();

            Localizacao_Dados localizacao = null;
            string sql = "select * Localizacao_Prod where partilhera like '%@partilhera%'";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter Pratileira_Parameter = cmd.Parameters.Add("partilhera", MySqlDbType.Int32);
                Pratileira_Parameter.Value = pratilheira;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        localizacao = new Localizacao_Dados();
                        localizacao.id_loc = reader.GetInt32("id_loc");
                        localizacao.corredor = reader.GetString("Corredor");
                        localizacao.pratileira = reader.GetString("partilhera");
                        localizacao.gaveta = reader.GetString("gaveta");
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteReader();
                Conexao.FC();
                return localizacao;
            }

        }
        public Localizacao_Dados pesquisaViaGaveta(string gaveta)
        {
            Conexao.AC();

            Localizacao_Dados localizacao = null;
            string sql = "select * Localizacao_Prod where gaveta like '%@gaveta%'";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter gaveta_Parameter = cmd.Parameters.Add("gaveta", MySqlDbType.Int32);
                gaveta_Parameter.Value = gaveta;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        localizacao = new Localizacao_Dados();
                        localizacao.id_loc = reader.GetInt32("id_loc");
                        localizacao.corredor = reader.GetString("Corredor");
                        localizacao.pratileira = reader.GetString("partilhera");
                        localizacao.gaveta = reader.GetString("gaveta");                        
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteReader();
                Conexao.FC();
                return localizacao;
            }
        }

        public List<Localizacao_Dados> Select()
        {

            List<Localizacao_Dados> Localizacoes = new List<Localizacao_Dados>();
            Localizacao_Dados localizacao = null;
            Conexao.AC();

            string sql = "select * from Localizacao_Prod";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        localizacao = new Localizacao_Dados();
                        localizacao.id_loc = reader.GetInt32("id_loc");
                        localizacao.corredor = reader.GetString("Corredor");
                        localizacao.pratileira = reader.GetString("partilhera");
                        localizacao.gaveta = reader.GetString("gaveta");
                        Localizacoes.Add(localizacao);
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }

            return Localizacoes;
        }

        public List<Localizacao_Dados> SelectbyCod(int cod)
        {

            List<Localizacao_Dados> Localizacoes = new List<Localizacao_Dados>();
            Localizacao_Dados localizacao = null;
            Conexao.AC();

            string sql = "select * from Localizacao_Prod where id_loc = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = cod;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        localizacao = new Localizacao_Dados();
                        localizacao.id_loc = reader.GetInt32("id_loc");
                        localizacao.corredor = reader.GetString("Corredor");
                        localizacao.pratileira = reader.GetString("partilhera");
                        localizacao.gaveta = reader.GetString("gaveta");
                        Localizacoes.Add(localizacao);
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }

            return Localizacoes;
        }

        public List<Localizacao_Dados> SelectbyCorredor(string corredor)
        {

            List<Localizacao_Dados> Localizacoes = new List<Localizacao_Dados>();
            Localizacao_Dados localizacao = null;
            Conexao.AC();

            string sql = "select * from Localizacao_Prod where Corredor like '%" + corredor + "%';";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        localizacao = new Localizacao_Dados();
                        localizacao.id_loc = reader.GetInt32("id_loc");
                        localizacao.corredor = reader.GetString("Corredor");
                        localizacao.pratileira = reader.GetString("partilhera");
                        localizacao.gaveta = reader.GetString("gaveta");
                        Localizacoes.Add(localizacao);
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }

            return Localizacoes;
        }

        public List<Localizacao_Dados> SelectbyPratelheira(string partilheira)
        {

            List<Localizacao_Dados> Localizacoes = new List<Localizacao_Dados>();
            Localizacao_Dados localizacao = null;
            Conexao.AC();

            string sql = "select * from Localizacao_Prod where partilhera like '%" + partilheira + "%';";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter partParameter = cmd.Parameters.Add("part", MySqlDbType.VarChar);
                partParameter.Value = partilheira;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        localizacao = new Localizacao_Dados();
                        localizacao.id_loc = reader.GetInt32("id_loc");
                        localizacao.corredor = reader.GetString("Corredor");
                        localizacao.pratileira = reader.GetString("partilhera");
                        localizacao.gaveta = reader.GetString("gaveta");
                        Localizacoes.Add(localizacao);
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }

            return Localizacoes;
        }

        public List<Localizacao_Dados> SelectbyGaveta(string gaveta)
        {
            
            List<Localizacao_Dados> Localizacoes = new List<Localizacao_Dados>();
            Localizacao_Dados localizacao = null;
            Conexao.AC();

            string sql = "select * from Localizacao_Prod where gaveta like '%"+ gaveta + "%';";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        localizacao = new Localizacao_Dados();
                        localizacao.id_loc = reader.GetInt32("id_loc");
                        localizacao.corredor = reader.GetString("Corredor");
                        localizacao.pratileira = reader.GetString("partilhera");
                        localizacao.gaveta = reader.GetString("gaveta");
                        Localizacoes.Add(localizacao);
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }

            return Localizacoes;
        }
    }
}
