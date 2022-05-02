using Dados.Entrega;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosBD
{
    public class Entrega_BD
    {
        public int Insert_Entrega(Entrega_Dados entregaAgenda)
        {
            int qtdLinhasAfetadas = 0;
            try
            {
                Conexao.AC();
                String sql = "insert into entrega (id_venda,id_veiculo,situacao_Entrega,Data_Entrega) values(@id_venda,@id_veiculo,@situacao_Entrega,@Data_Entrega)";
                using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                {
                    MySqlParameter ClienteParamete = cmd.Parameters.Add("id_venda", MySqlDbType.Int32);
                    ClienteParamete.Value = entregaAgenda.id_venda;
                    MySqlParameter ItemsParameter = cmd.Parameters.Add("id_veiculo", MySqlDbType.Int32);
                    ItemsParameter.Value = entregaAgenda.id_veiculo;
                    MySqlParameter ValorVendaParameter = cmd.Parameters.Add("situacao_Entrega", MySqlDbType.VarChar);
                    ValorVendaParameter.Value = entregaAgenda.situacao_Entrega;
                    MySqlParameter DataParameter = cmd.Parameters.Add("Data_Entrega", MySqlDbType.DateTime);
                    DataParameter.Value = entregaAgenda.Data_Entrega;

                    qtdLinhasAfetadas = cmd.ExecuteNonQuery();
                }
                Conexao.FC();
            }
            catch (Exception)
            {


            }
            return qtdLinhasAfetadas;
        }

        public int Delete_entrega(Entrega_Dados entDel)
        {
            int qtdLinhasAfetadas = 0;
            try
            {
                Conexao.AC();
                String sql = "delete from entrega where id_entrega = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                {
                    MySqlParameter idVendaParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                    idVendaParameter.Value = entDel.id_entrega;
                    qtdLinhasAfetadas = cmd.ExecuteNonQuery();
                }
                Conexao.FC();
            }

            catch (Exception)
            {


            }

            return qtdLinhasAfetadas;
        }

        public int altSituacao_Entrega(Entrega_Dados entAlt)
        {
            int qtdLinhasAfetadas = 0;
            try
            {
                Conexao.AC();
                String sql = "update entrega set situacao_Entrega = @situacao_Entrega where id_entrega = @id_entrega";
                using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                {

                    MySqlParameter ValorID = cmd.Parameters.Add("id_entrega", MySqlDbType.Int32);
                    ValorID.Value = entAlt.id_entrega;
                    
                    MySqlParameter ValorVendaParameter = cmd.Parameters.Add("situacao_Entrega", MySqlDbType.VarChar);
                    ValorVendaParameter.Value = entAlt.situacao_Entrega;
                    qtdLinhasAfetadas = cmd.ExecuteNonQuery();
                }
                Conexao.FC();
            }
            catch (Exception)
            {


            }
            return qtdLinhasAfetadas;
        }

        public List<Entrega_Dados> GetTodos()
        {
            List<Entrega_Dados> entrega = new List<Entrega_Dados>();
            Conexao.AC();
            String sql = "Select * from entrega";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Entrega_Dados obj = new Entrega_Dados();
                        obj.id_entrega = dataReader.GetInt32("id_entrega");
                        obj.id_venda = dataReader.GetInt32("id_venda");
                        obj.id_veiculo = dataReader.GetInt32("id_veiculo");
                        obj.situacao_Entrega = dataReader.GetString("situacao_Entrega");
                        obj.Data_Entrega = dataReader.GetDateTime("Data_Entrega");
                        entrega.Add(obj);
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return entrega;
        }
        
        public List<Entrega_Dados> GetPorData(DateTime data)
        {
            List<Entrega_Dados> entrega = new List<Entrega_Dados>();
            Conexao.AC();
            String sql = "Select * from entrega where data_venda = @data";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter dataParameter = cmd.Parameters.Add("data", MySqlDbType.Int32);
                dataParameter.Value = data;
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Entrega_Dados obj = new Entrega_Dados();
                        obj.id_entrega = dataReader.GetInt32("id_entrega");
                        obj.id_venda = dataReader.GetInt32("id_venda");
                        obj.id_veiculo = dataReader.GetInt32("id_veiculo");
                        obj.situacao_Entrega = dataReader.GetString("situacao_Entrega");
                        obj.Data_Entrega = dataReader.GetDateTime("Data_Entrega");
                        
                        entrega.Add(obj);
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return entrega;
        }

        public string getEndereco(int id_cliente)
        {
            string endereco = "";
            Conexao.AC();
            String sql = "Select endereco from cliente where cli_id = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idVendaParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idVendaParameter.Value = id_cliente;
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        endereco = dataReader.GetString("endereco");
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return endereco;
        }
        
        public string GetCliente(int id)
        {
            Conexao.AC();
            string Nome_Funcao = null;
            string sql = "Select Nome from cliente where cli_id = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = id;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Nome_Funcao = reader.GetString("Nome");
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
            return Nome_Funcao;
        }

        public int GetIDCliente(int id)
        {
            Conexao.AC();
            int idCli = 0;
            string sql = "Select cli_id from vendas where id_venda = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = id;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idCli = reader.GetInt32("cli_id");
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
            return idCli;
        }

        public String GetVeiculo(int id)
        {
            Conexao.AC();
            String veiculo = "";
            string sql = "Select desc_veiculo from veiculo where id_veiculo = @id_veiculo";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id_veiculo", MySqlDbType.VarChar);
                idParameter.Value = id;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        veiculo = reader.GetString("desc_veiculo");
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
            return veiculo;
        }

        public String GetPlaca(int id)
        {
            Conexao.AC();
            String placa = "";
            string sql = "Select placa_veiculo from veiculo where id_veiculo = @id_veiculo";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id_veiculo", MySqlDbType.VarChar);
                idParameter.Value = id;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        placa = reader.GetString("placa_veiculo");
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
            return placa;
        }

        public int pesquisaIdVenda()
        {
            Conexao.AC();

            string sql = "select max(id_venda) from vendas";
            int id = 0;
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader.GetInt32("max(id_venda)");
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
                return id;
            }

        }
    }
}
