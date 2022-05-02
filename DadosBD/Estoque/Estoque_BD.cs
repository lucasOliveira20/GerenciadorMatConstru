using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosBD.Estoque
{
    public class Estoque_BD
    {
        //Cadastrar 
        public void ADD(Dados.Estoque_Dados ADDdados)
        {
            try
            {
                Conexao.AC();
                String sql = "insert into estoque (id_loc,for_id,id_produto,quant_disponivel,dataADD) values (@id_loc,@for_id,@id_produto,@quant_disponivel,@dataADD)";
                using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                {

                    MySqlParameter idlocParameter = cmd.Parameters.Add("id_loc", MySqlDbType.Int32);
                    idlocParameter.Value = ADDdados.id_loc;

                    MySqlParameter idforParameter = cmd.Parameters.Add("for_id", MySqlDbType.Int32);
                    idforParameter.Value = ADDdados.id_fornecedor;

                    MySqlParameter idProParameter = cmd.Parameters.Add("id_produto", MySqlDbType.Int32);
                    idProParameter.Value = ADDdados.id_produto;

                    MySqlParameter quantParameter = cmd.Parameters.Add("quant_disponivel", MySqlDbType.Int32);
                    quantParameter.Value = ADDdados.quant_disponivel;

                    MySqlParameter dataADDParameter = cmd.Parameters.Add("dataADD", MySqlDbType.DateTime);
                    dataADDParameter.Value = ADDdados.dataADD;

                    cmd.ExecuteNonQuery();
                }
                Conexao.FC();
            }

            catch (Exception)
            {

            }
        }

        //Deletar
        public void DEL(Dados.Estoque_Dados delEst)
        {
            
            try
            {
                Conexao.AC();
                String sql = "delete from estoque where id_estoque = @id_estoque";
                using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                {
                    MySqlParameter idParameter = cmd.Parameters.Add("id_estoque", MySqlDbType.Int32);
                    idParameter.Value = delEst.id_estoque;


                    cmd.ExecuteNonQuery();
                }
                Conexao.FC();
            }
            catch (Exception)
            {

            }

        }

        //Alterar
        public void ALT(Dados.Estoque_Dados ALTdados)
        {
            try
            {
                Conexao.AC();
                String sql = "update estoque set id_loc = @id_loc, for_id = @for_id, id_produto = @id_produto, quant_disponivel = @quant_disponivel, dataADD = @dataADD  where id_estoque = @id_estoque";
                using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                {
                    MySqlParameter idestParameter = cmd.Parameters.Add("id_estoque", MySqlDbType.Int32);
                    idestParameter.Value = ALTdados.id_estoque;

                    MySqlParameter idlocParameter = cmd.Parameters.Add("id_loc", MySqlDbType.Int32);
                    idlocParameter.Value = ALTdados.id_loc;

                    MySqlParameter idforParameter = cmd.Parameters.Add("for_id", MySqlDbType.Int32);
                    idforParameter.Value = ALTdados.id_fornecedor;

                    MySqlParameter idProParameter = cmd.Parameters.Add("id_produto", MySqlDbType.Int32);
                    idProParameter.Value = ALTdados.id_produto;

                    MySqlParameter quantParameter = cmd.Parameters.Add("quant_disponivel", MySqlDbType.Int32);
                    quantParameter.Value = ALTdados.quant_disponivel;

                    MySqlParameter dataADDParameter = cmd.Parameters.Add("dataADD", MySqlDbType.DateTime);
                    dataADDParameter.Value = ALTdados.dataADD;

                    cmd.ExecuteNonQuery();
                }
                Conexao.FC();
            }
            catch (Exception)
            {

            }
        }


        public Dados.Estoque_Dados BviaCod(int id)
        {
            Dados.Estoque_Dados est = null;
            Conexao.AC();
            String sql = "Select * from estoque where id_estoque = @id_estoque";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id_estoque", MySqlDbType.Int32);
                idParameter.Value = id;

                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        est = new Dados.Estoque_Dados();

                        est.id_estoque = dataReader.GetInt32("id_estoque");
                        est.id_loc = dataReader.GetInt32("id_loc");
                        est.id_fornecedor = dataReader.GetInt32("for_id");
                        est.id_produto = dataReader.GetInt32("id_produto");
                        est.dataADD = dataReader.GetDateTime("dataADD");
                        est.quant_disponivel = dataReader.GetInt32("quant_disponivel");
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();

            return est;
        }

        public List<Dados.Estoque_Dados> Select()
        {
            List<Dados.Estoque_Dados> estoque = new List<Dados.Estoque_Dados>();
            Conexao.AC();
            String sql = "Select * from estoque";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {

                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Dados.Estoque_Dados est = new Dados.Estoque_Dados();

                        est.id_estoque = dataReader.GetInt32("id_estoque");
                        est.id_loc = dataReader.GetInt32("id_loc");
                        est.id_fornecedor = dataReader.GetInt32("for_id");
                        est.id_produto = dataReader.GetInt32("id_produto");
                        est.dataADD = dataReader.GetDateTime("dataADD");
                        est.quant_disponivel = dataReader.GetInt32("quant_disponivel");
                        estoque.Add(est);
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return estoque;
        }

        /*int id;

        public int GetCodigo(string desc)
        {
            Conexao.AC();
            String sql = "Select id_produto from produto where descricao = @descricao";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter tamParameter = cmd.Parameters.Add("descricao", MySqlDbType.VarChar);
                tamParameter.Value = desc;

                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        id = dataReader.GetInt32("id_produto");

                    }
                }
            }
            Conexao.FC();
            return id;
            
        }

        public int GetCodigofornecedor(string desc)
        {
            Conexao.AC();
            String sql = "Select for_id from fornecedor where Nome = @Nome";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter tamParameter = cmd.Parameters.Add("Nome", MySqlDbType.VarChar);
                tamParameter.Value = desc;

                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        id = dataReader.GetInt32("for_id");

                    }
                }
            }
            Conexao.FC();
            return id;
        }

        public int GetCodigoLoc(string c,string p, string g)
        {
            Conexao.AC();
            String sql = "select id_loc from Localizacao_Prod where Corredor=@Corredor and partilhera=@partilhera and gaveta=@gaveta";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter cParameter = cmd.Parameters.Add("Corredor", MySqlDbType.VarChar);
                cParameter.Value = c;

                MySqlParameter pParameter = cmd.Parameters.Add("partilhera", MySqlDbType.VarChar);
                pParameter.Value = p;

                MySqlParameter gParameter = cmd.Parameters.Add("gaveta", MySqlDbType.VarChar);
                gParameter.Value = g;

                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        id = dataReader.GetInt32("for_id");
                    }

                }
            }
            Conexao.FC();
            return id;
        }

        string desc;

        public string SetCodigo(int id)
        {
            Conexao.AC();
            String sql = "Select descricao from produto where id_produto = @id_produto";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter tamParameter = cmd.Parameters.Add("id_produto", MySqlDbType.VarChar);
                tamParameter.Value = id;

                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        desc = dataReader.GetString("descricao");

                    }
                }
            }
            Conexao.FC();
            return desc;

        }

        public string SetCodigofornecedor(int id)
        {
            Conexao.AC();
            String sql = "Select Nome from fornecedor where for_id = @for_id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter tamParameter = cmd.Parameters.Add("for_id", MySqlDbType.VarChar);
                tamParameter.Value = id;

                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        desc = dataReader.GetString("Nome");

                    }
                }
            }
            Conexao.FC();
            return desc;
        }

        public int SetCodigoLoc(string c, string p, string g)
        {
            Conexao.AC();
            String sql = "select id_loc from Localizacao_Prod where Corredor=@Corredor and partilhera=@partilhera and gaveta=@gaveta";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter cParameter = cmd.Parameters.Add("Corredor", MySqlDbType.VarChar);
                cParameter.Value = c;

                MySqlParameter pParameter = cmd.Parameters.Add("partilhera", MySqlDbType.VarChar);
                pParameter.Value = p;

                MySqlParameter gParameter = cmd.Parameters.Add("gaveta", MySqlDbType.VarChar);
                gParameter.Value = g;

                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        id = dataReader.GetInt32("for_id");
                    }
                }
            }
            Conexao.FC();
            return id;
        }*/
        public string GetFornecedor(int id)
        {
            Conexao.AC();
            string Nome_Fornc = null;
            string sql = "Select Nome from fornecedor where for_id = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = id;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Nome_Fornc = reader.GetString("Nome");
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
            return Nome_Fornc;
        }

        public string GetLocalizacao(int id)
        {
            Conexao.AC();
            string Nome_Fornc = null;
            string sql = "Select Corredor, partilhera, gaveta from Localizacao_Prod where id_loc = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = id;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Nome_Fornc = "Corredor: " + reader.GetString("Corredor") + " Prateleira: " + reader.GetString("partilhera") + " Gaveta: " + reader.GetString("gaveta");
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
            return Nome_Fornc;
        }

        public string GetProduto(int id)
        {
            Conexao.AC();
            string Nome_Fornc = null;
            string sql = "Select descricao from Produto where id_produto = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = id;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Nome_Fornc = reader.GetString("descricao");
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
            return Nome_Fornc;
        }
    }
}
