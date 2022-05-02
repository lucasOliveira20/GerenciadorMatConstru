using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using MySql.Data.MySqlClient;
namespace DadosBD
{
    public class Vendas_BD
    {
        public int Insert_Venda(Venda_Dados vendarealizada)
        {
            int qtdLinhasAfetadas = 0;
            try
            {
                Conexao.AC();
                String sql = "insert into vendas (fun_id,cli_id,id_itemVenda,id_formaPag,valor_venda,data_venda,valor_recebido,troco,entrega) values(@fun_id,@cli_id,@id_item,@id_formaPag,@valor_venda,@data,@valor_recebido,@troco,@entrega)";
                using (MySqlCommand cmd = new MySqlCommand(sql,Conexao.conexao))
                {
                    MySqlParameter FuncionarioParameter = cmd.Parameters.Add("fun_id", MySqlDbType.Int32);
                    FuncionarioParameter.Value = vendarealizada.fun_id;
                    MySqlParameter ClienteParamete = cmd.Parameters.Add("cli_id", MySqlDbType.Int32);
                    ClienteParamete.Value = vendarealizada.cli_id;
                    MySqlParameter ItemsParameter = cmd.Parameters.Add("id_item", MySqlDbType.Int32);
                    ItemsParameter.Value = vendarealizada.id_itemVenda;
                    MySqlParameter PagParameter = cmd.Parameters.Add("id_formaPag", MySqlDbType.Int32);
                    PagParameter.Value = vendarealizada.id_formaPag;
                    MySqlParameter ValorVendaParameter = cmd.Parameters.Add("valor_venda", MySqlDbType.Double);
                    ValorVendaParameter.Value = vendarealizada.valor_venda;
                    MySqlParameter DataParameter = cmd.Parameters.Add("data", MySqlDbType.DateTime);
                    DataParameter.Value = vendarealizada.data_venda;
                    MySqlParameter ValorRecebidoParameter = cmd.Parameters.Add("valor_recebido", MySqlDbType.Double);
                    ValorRecebidoParameter.Value = vendarealizada.valor_recebido;
                    MySqlParameter TrocoParameter = cmd.Parameters.Add("troco", MySqlDbType.Double);
                    TrocoParameter.Value = vendarealizada.troco;
                    MySqlParameter EntregaParameter = cmd.Parameters.Add("entrega", MySqlDbType.VarChar);
                    EntregaParameter.Value = vendarealizada.entrega;
                    qtdLinhasAfetadas = cmd.ExecuteNonQuery();
                }
                Conexao.FC();
            }
            catch (Exception)
            {
                 
               
            }
            return qtdLinhasAfetadas;
        }

        public int Delete_Venda(Venda_Dados vendaDel)
        {
            int qtdLinhasAfetadas = 0;
            try
            {
                Conexao.AC();
                String sql = "delete from vendas where id_venda = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql,Conexao.conexao))
                {
                    MySqlParameter idVendaParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                    idVendaParameter.Value = vendaDel.id_venda;
                    qtdLinhasAfetadas = cmd.ExecuteNonQuery();
                }
                Conexao.FC();
            }

            catch (Exception)
            {
                
                
            }
            
            return qtdLinhasAfetadas;
        }

        public int Update_Venda(Venda_Dados vendaAlteranda)
        {
            int qtdLinhasAfetadas = 0;
            try
            {
                Conexao.AC();
                String sql = "update vendas set fun_id = @funcionario,cli_id = @cliente, id_itemVenda = @itens, id_formaPag = @id_formaPag, valor_venda = @valor_vendido, data_venda = @data, valor_recebido = @valor_recebido, troco = @troco, entrega = @entrega where id_venda = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql,Conexao.conexao))
                {
                     MySqlParameter FuncionarioParameter = cmd.Parameters.Add("funcionario", MySqlDbType.Int32);
                    FuncionarioParameter.Value = vendaAlteranda.fun_id;
                    MySqlParameter ClienteParamete = cmd.Parameters.Add("cliente", MySqlDbType.Int32);
                    ClienteParamete.Value = vendaAlteranda.cli_id;
                    MySqlParameter ItemsParameter = cmd.Parameters.Add("itens", MySqlDbType.Int32);
                    ItemsParameter.Value = vendaAlteranda.id_itemVenda;
                    MySqlParameter PagParameter = cmd.Parameters.Add("id_formaPag", MySqlDbType.Int32);
                    PagParameter.Value = vendaAlteranda.id_formaPag;
                    MySqlParameter ValorVendaParameter = cmd.Parameters.Add("valor_vendido", MySqlDbType.Double);
                    ValorVendaParameter.Value = vendaAlteranda.valor_venda;
                    MySqlParameter DataParameter = cmd.Parameters.Add("data", MySqlDbType.DateTime);
                    DataParameter.Value = vendaAlteranda.data_venda;
                    MySqlParameter ValorRecebidoParameter = cmd.Parameters.Add("valor_recebido", MySqlDbType.Double);
                    ValorRecebidoParameter.Value = vendaAlteranda.valor_recebido;
                    MySqlParameter TrocoParameter = cmd.Parameters.Add("troco", MySqlDbType.Double);
                    TrocoParameter.Value = vendaAlteranda.troco;
                    MySqlParameter EntregaParameter = cmd.Parameters.Add("entrega", MySqlDbType.VarChar);
                    EntregaParameter.Value = vendaAlteranda.entrega;
                    MySqlParameter idVendaParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                    idVendaParameter.Value = vendaAlteranda.id_venda;
                    qtdLinhasAfetadas = cmd.ExecuteNonQuery();
                }
                Conexao.FC();
            }
            catch (Exception)
            {
                
                
            }
            return qtdLinhasAfetadas;
        }

        public Venda_Dados getPorCodigo(int id)
        {
            Venda_Dados venda = null;
            Conexao.AC();
            String sql = "Select * from vendas where id_venda = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql,Conexao.conexao))
            {
                MySqlParameter idVendaParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idVendaParameter.Value = id;
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        venda = new Venda_Dados();
                        venda.id_venda = dataReader.GetInt32("id_venda");
                        venda.fun_id = dataReader.GetInt32("fun_id");
                        venda.id_formaPag = dataReader.GetInt32("id_formaPag");
                        venda.valor_venda = dataReader.GetDouble("valor_venda");
                        venda.data_venda = dataReader.GetDateTime("data_venda");
                        venda.valor_recebido = dataReader.GetDouble("valor_recebido");
                        venda.troco = dataReader.GetDouble("troco");
                        venda.entrega = dataReader.GetString("entrega");
                        venda.cli_id = dataReader.GetInt32("cli_id");
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return venda;
        }

        public List<Venda_Dados> GetTodos()
        {
            List<Dados.Venda_Dados> venda = new List<Dados.Venda_Dados>();
            Conexao.AC();
            String sql = "Select * from vendas";
            using (MySqlCommand cmd = new MySqlCommand(sql,Conexao.conexao))
            {
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Venda_Dados obj = new Venda_Dados();
                        obj.id_venda = dataReader.GetInt32("id_venda");
                        obj.fun_id = dataReader.GetInt32("fun_id");
                        obj.id_itemVenda = dataReader.GetInt32("id_itemVenda");
                        obj.id_formaPag = dataReader.GetInt32("id_formaPag");
                        obj.valor_venda = dataReader.GetDouble("valor_venda");      
                        obj.valor_recebido = dataReader.GetDouble("valor_recebido");
                        obj.troco = dataReader.GetDouble("troco");
                        obj.data_venda = dataReader.GetDateTime("data_venda");
                        obj.entrega = dataReader.GetString("entrega");
                        obj.cli_id = dataReader.GetInt32("cli_id");
                        venda.Add(obj);
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return venda;
        }

        public List<Venda_Dados> GetPorCodigo(int id)
        {
            List<Venda_Dados> venda = new List<Venda_Dados>();
            Conexao.AC();
            String sql = "Select * from Vendas where id_venda = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = id;
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Venda_Dados obj = new Venda_Dados();
                        obj.id_venda = dataReader.GetInt32("id_venda");
                        obj.fun_id = dataReader.GetInt32("fun_id");
                        obj.id_itemVenda = dataReader.GetInt32("id_itemVenda");
                        obj.id_formaPag = dataReader.GetInt32("id_formaPag");
                        obj.valor_venda = dataReader.GetDouble("valor_venda");      
                        obj.valor_recebido = dataReader.GetDouble("valor_recebido");
                        obj.troco = dataReader.GetDouble("troco");
                        obj.data_venda = dataReader.GetDateTime("data_venda");
                        obj.entrega = dataReader.GetString("entrega");
                        obj.cli_id = dataReader.GetInt32("cli_id");
                        venda.Add(obj);
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return venda;
        }

        public List<Venda_Dados> GetPorFuncionario(int id)
        {
            List<Venda_Dados> venda = new List<Venda_Dados>();
            Conexao.AC();
            String sql = "Select * from Vendas where fun_id = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = id;
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Venda_Dados obj = new Venda_Dados();
                        obj.id_venda = dataReader.GetInt32("id_venda");
                        obj.fun_id = dataReader.GetInt32("fun_id");
                        obj.id_itemVenda = dataReader.GetInt32("id_itemVenda");
                        obj.id_formaPag = dataReader.GetInt32("id_formaPag");
                        obj.valor_venda = dataReader.GetDouble("valor_venda");
                        
                        obj.valor_recebido = dataReader.GetDouble("valor_recebido");
                        obj.troco = dataReader.GetDouble("troco");
                        obj.data_venda = dataReader.GetDateTime("data_venda");
                        obj.entrega = dataReader.GetString("entrega");
                        obj.cli_id = dataReader.GetInt32("cli_id");
                        venda.Add(obj);
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return venda;
        }

        public List<Venda_Dados> GetPorData(DateTime data)
        {
            List<Venda_Dados> venda = new List<Venda_Dados>();
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
                        Venda_Dados obj = new Venda_Dados();
                        obj.id_venda = dataReader.GetInt32("id_venda");
                        obj.fun_id = dataReader.GetInt32("fun_id");
                        obj.id_itemVenda = dataReader.GetInt32("id_itemVenda");
                        obj.id_formaPag = dataReader.GetInt32("id_formaPag");
                        obj.valor_venda = dataReader.GetDouble("valor_venda");
                        
                        obj.valor_recebido = dataReader.GetDouble("valor_recebido");
                        obj.troco = dataReader.GetDouble("troco");
                        obj.data_venda = dataReader.GetDateTime("data_venda");
                        obj.entrega = dataReader.GetString("entrega");
                        obj.cli_id = dataReader.GetInt32("cli_id");
                        venda.Add(obj);
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return venda;
        }

        public int GetCodigo(string desc)
        {
            int id = 0;
            Conexao.AC();
            String sql = "Select id_formaPag from Forma_pag where desc_formPag = @desc";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter tamParameter = cmd.Parameters.Add("desc", MySqlDbType.VarChar);
                tamParameter.Value = desc;

                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        id = dataReader.GetInt32("id_formaPag");

                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            return id;
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
        public string GetFormaPag(int id)
        {
            Conexao.AC();
            string Nome_Funcao = null;
            string sql = "Select desc_formPag from Forma_pag where id_formaPag = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = id;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Nome_Funcao = reader.GetString("desc_formPag");
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
            return Nome_Funcao;
        }

    }
}
