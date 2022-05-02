using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.Orçamento;

namespace DadosBD.Orçamento
{
  public class Orcamento_BD
    {
        public int Insert_ORC(orcamento_Dados orcRealizado)
        {
            int qtdLinhasAfetadas = 0;
            try
            {
                Conexao.AC();
                String sql = "insert into orcamento (fun_id,id_ItemOrcamento,valor_orcamento,data_orcamento) values (@fun_id, @id_ItemOrcamento, @valor_orcamento, @data_orcamento)";
                using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                {
                    MySqlParameter FuncionarioParameter = cmd.Parameters.Add("fun_id", MySqlDbType.Int32);
                    FuncionarioParameter.Value = orcRealizado.fun_id;
                    MySqlParameter ItemsParameter = cmd.Parameters.Add("id_ItemOrcamento", MySqlDbType.Int32);
                    ItemsParameter.Value = orcRealizado.id_ItemOrcamento;
                    MySqlParameter ValorVendaParameter = cmd.Parameters.Add("valor_orcamento", MySqlDbType.Double);
                    ValorVendaParameter.Value = orcRealizado.valor_orcamento;
                    MySqlParameter DataParameter = cmd.Parameters.Add("data_orcamento", MySqlDbType.DateTime);
                    DataParameter.Value = orcRealizado.data_orcamento;
                    qtdLinhasAfetadas = cmd.ExecuteNonQuery();
                }
                Conexao.FC();
            }
            catch (Exception)
            {


            }
            return qtdLinhasAfetadas;
        }

        public int Delete_ORC(orcamento_Dados orcDel)
        {
            int qtdLinhasAfetadas = 0;
            try
            {
                Conexao.AC();
                String sql = "delete from orcamento where id_orcamento = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                {
                    MySqlParameter idORCParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                    idORCParameter.Value = orcDel.id_orcamento;
                    qtdLinhasAfetadas = cmd.ExecuteNonQuery();
                }
                Conexao.FC();
            }

            catch (Exception)
            {


            }

            return qtdLinhasAfetadas;
        }

        public int Update_ORC(orcamento_Dados orcAlterando)
        {
            int qtdLinhasAfetadas = 0;
            try
            {
                Conexao.AC();
                String sql = "update orcamento set fun_id = @fun_id, id_ItemOrcamento = @id_ItemOrcamento, valor_orcamento = @valor_orcamento, data_orcamento = @data_orcamento where id_orcamento = @id_orcamento";
                using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                {
                    MySqlParameter idParameter = cmd.Parameters.Add("id_orcamento", MySqlDbType.Int32);
                    idParameter.Value = orcAlterando.id_orcamento;
                    MySqlParameter FuncionarioParameter = cmd.Parameters.Add("fun_id", MySqlDbType.Int32);
                    FuncionarioParameter.Value = orcAlterando.fun_id;
                    MySqlParameter ItemsParameter = cmd.Parameters.Add("id_ItemOrcamento", MySqlDbType.Int32);
                    ItemsParameter.Value = orcAlterando.id_ItemOrcamento;
                    MySqlParameter ValorORCParameter = cmd.Parameters.Add("valor_orcamento", MySqlDbType.Double);
                    ValorORCParameter.Value = orcAlterando.valor_orcamento;
                    MySqlParameter DataParameter = cmd.Parameters.Add("data_orcamento", MySqlDbType.DateTime);
                    DataParameter.Value = orcAlterando.data_orcamento;
                    qtdLinhasAfetadas = cmd.ExecuteNonQuery();
                }
                Conexao.FC();
            }
            catch (Exception)
            {


            }
            return qtdLinhasAfetadas;
        }

        public orcamento_Dados getPorCodigo(int id)
        {
            orcamento_Dados obj = null;
            Conexao.AC();
            String sql = "Select * from orcamento where id_orcamento = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idVendaParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idVendaParameter.Value = id;
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        obj = new orcamento_Dados();
                        obj.id_orcamento = dataReader.GetInt32("id_orcamento");
                        obj.fun_id = dataReader.GetInt32("fun_id ");
                        obj.id_ItemOrcamento = dataReader.GetInt32("id_ItemOrcamento");
                        obj.data_orcamento = dataReader.GetDateTime("data_orcamento");
                        
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return obj;
        }

        public List<orcamento_Dados> GetTodos()
        {
            List<orcamento_Dados> orc = new List<orcamento_Dados>();
            Conexao.AC();
            String sql = "Select * from orcamento";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        orcamento_Dados obj = new orcamento_Dados();
                        obj.id_orcamento = dataReader.GetInt32("id_orcamento");
                        obj.fun_id = dataReader.GetInt32("fun_id");
                        obj.id_ItemOrcamento = dataReader.GetInt32("id_ItemOrcamento");
                        obj.valor_orcamento = dataReader.GetDouble("valor_orcamento");
                        obj.data_orcamento = dataReader.GetDateTime("data_orcamento");
                        orc.Add(obj);
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return orc;
        }

        public List<orcamento_Dados> GetPorCodigo(int id)
        {
            List<orcamento_Dados> orc = new List<orcamento_Dados>();
            Conexao.AC();
            String sql = "Select * from orcamento where id_orcamento  = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = id;
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        orcamento_Dados obj = new orcamento_Dados();
                        obj.id_orcamento = dataReader.GetInt32("id_orcamento");
                        obj.fun_id = dataReader.GetInt32("fun_id ");
                        obj.id_ItemOrcamento = dataReader.GetInt32("id_ItemOrcamento");
                        obj.valor_orcamento = dataReader.GetDouble("valor_orcamento");
                        obj.data_orcamento = dataReader.GetDateTime("data_orcamento");
                        orc.Add(obj);
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return orc;
        }

        public List<orcamento_Dados> GetPorFuncionario(int id)
        {
            List<orcamento_Dados> orc = new List<orcamento_Dados>();
            Conexao.AC();
            String sql = "Select * from orcamento where fun_id = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = id;
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        orcamento_Dados obj = new orcamento_Dados();
                        obj.id_orcamento = dataReader.GetInt32("id_orcamento");
                        obj.fun_id = dataReader.GetInt32("fun_id ");
                        obj.id_ItemOrcamento = dataReader.GetInt32("id_ItemOrcamento");
                        obj.valor_orcamento = dataReader.GetDouble("valor_orcamento");
                        obj.data_orcamento = dataReader.GetDateTime("data_orcamento");
                        orc.Add(obj);
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return orc;
        }

        public List<orcamento_Dados> GetPorData(DateTime data)
        {
            List<orcamento_Dados> orc = new List<orcamento_Dados>();
            Conexao.AC();
            String sql = "Select * from Vendas where data_venda = @data";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter dataParameter = cmd.Parameters.Add("data", MySqlDbType.Int32);
                dataParameter.Value = data;
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        orcamento_Dados obj = new orcamento_Dados();
                        obj.id_orcamento = dataReader.GetInt32("id_orcamento");
                        obj.fun_id = dataReader.GetInt32("fun_id ");
                        obj.id_ItemOrcamento = dataReader.GetInt32("id_ItemOrcamento");
                        obj.valor_orcamento = dataReader.GetDouble("valor_orcamento");
                        obj.data_orcamento = dataReader.GetDateTime("data_orcamento");
                        orc.Add(obj);
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return orc;
        }

        
        public string GetFuncionario(int id)
        {
            Conexao.AC();
            string Nome_Funcao = null;
            string sql = "Select Nome from funcionario where fun_id = @id";
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
    }
}
