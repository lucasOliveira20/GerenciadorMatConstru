using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dados.Vendas;
using Dados;
namespace DadosBD.Venda
{
    public class Item_venda_BD
    {
        public int Insert_item(List<Item_venda> produtos)
        {
            int qtdLinhasAfetadas = 0;
            try
            {
                foreach (var item in produtos)
                {
                    Conexao.AC();
                    String sql = "insert into Item_venda (id_Item,id_produto,quant_vendida,prec_unitario) values (@Item,@Produto,@quant,@prec);";
                    using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                    {
                        MySqlParameter Id_item = cmd.Parameters.Add("Item", MySqlDbType.Int32);
                        Id_item.Value = item.Id_Item;
                        MySqlParameter Id_Prod = cmd.Parameters.Add("Produto", MySqlDbType.Int32);
                        Id_Prod.Value = item.Id_Produto;
                        MySqlParameter Quant = cmd.Parameters.Add("quant", MySqlDbType.Int32);
                        Quant.Value = item.quant_vendida;
                        MySqlParameter Preco = cmd.Parameters.Add("prec", MySqlDbType.Double);
                        Preco.Value = item.prec_Unitario;
                        qtdLinhasAfetadas = cmd.ExecuteNonQuery();
                    }
                    Conexao.FC();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return qtdLinhasAfetadas;
        }

        public int Update_estoque(List<Item_venda> produtos)
        {
            int qtdLinhasAfetadas = 0;
            int quant_atual = 0;
            try
            {
                foreach (var item in produtos)
                {
                    Conexao.AC();
                    String sql1 = "Select quant_disponivel from estoque where id_produto = @id1";
                    using (MySqlCommand cmd1 = new MySqlCommand(sql1, Conexao.conexao))
                    {
                        MySqlParameter idParameter = cmd1.Parameters.Add("id1", MySqlDbType.Int32);
                        idParameter.Value = item.Id_Produto;
                        using (MySqlDataReader dataReader = cmd1.ExecuteReader())
                        {
                            if (dataReader.Read())
                            {
                                quant_atual = dataReader.GetInt32("quant_disponivel");
                            }
                            dataReader.Close();
                            dataReader.Dispose();
                        }
                    }
                    Conexao.FC();
                    Conexao.AC();
                    String sql = "update estoque set quant_disponivel = @quant where id_produto = @id;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                    {
                        MySqlParameter quantParameter = cmd.Parameters.Add("quant", MySqlDbType.Int32);
                        quantParameter.Value = quant_atual - item.quant_vendida;
                        MySqlParameter idFParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                        idFParameter.Value = item.Id_Produto;
                        qtdLinhasAfetadas = cmd.ExecuteNonQuery();
                    }
                    Conexao.FC();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return qtdLinhasAfetadas;
        }

        public int Soma_Estoque(List<Item_venda> produtos)
        {
            int qtdLinhasAfetadas = 0;
            int quant_atual = 0;
            try
            {
                foreach (var item in produtos)
                {
                    Conexao.AC();
                    String sql1 = "Select quant_disponivel from estoque where id_produto = @id1";
                    using (MySqlCommand cmd1 = new MySqlCommand(sql1, Conexao.conexao))
                    {
                        MySqlParameter idParameter = cmd1.Parameters.Add("id1", MySqlDbType.Int32);
                        idParameter.Value = item.Id_Produto;
                        using (MySqlDataReader dataReader = cmd1.ExecuteReader())
                        {
                            if (dataReader.Read())
                            {
                                quant_atual = dataReader.GetInt32("quant_disponivel");
                            }
                            dataReader.Close();
                            dataReader.Dispose();
                        }
                    }
                    Conexao.FC();
                    Conexao.AC();
                    String sql = "update estoque set quant_disponivel = @quant where id_produto = @id;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                    {
                        MySqlParameter quantParameter = cmd.Parameters.Add("quant", MySqlDbType.Int32);
                        quantParameter.Value = quant_atual + item.quant_vendida;
                        MySqlParameter idFParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                        idFParameter.Value = item.Id_Produto;
                    }
                    Conexao.FC();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return qtdLinhasAfetadas;
        }
        
        public bool isInEstoque(Item_venda vendendo)
        {
          
            
            int quant_disponivel = 0;
            bool condicao = false;
            try
            {
                Conexao.AC();
                String sql = "select quant_disponivel from estoque where id_produto = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql,Conexao.conexao))
                {
                    
                    MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                    idParameter.Value = vendendo.Id_Produto;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            quant_disponivel = reader.GetInt32("quant_disponivel");
                        }
                        reader.Close();
                        reader.Dispose();
                    }
                }
                Conexao.FC();
                if (quant_disponivel>= vendendo.quant_vendida)
                {
                    condicao = true;
                }
                else
                {
                    condicao = false;
                }
                
            }
            catch (Exception e)
            {
                string erro = e.Message;               
            }
            return condicao;
        }

        public int Update_Items(List<Item_venda> produtos, int id_Item)
        {
            int qtdLinhasAfetadas = 0;
            try
            {
                Conexao.AC();
                String sql = "delete from Item_venda where id_Item = @id_item";
                using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                {
                    MySqlParameter ItemParameter = cmd.Parameters.Add("id_item", MySqlDbType.Int32);
                    ItemParameter.Value = id_Item;
                }
                Conexao.FC();
                foreach (var item in produtos)
                {
                    Conexao.AC();
                    String sql1 = "insert into Item_venda (id_Item,id_produto,quant_vendida,prec_unitario) values (@Item,@Produto,@quant,@prec);";
                    using (MySqlCommand cmd = new MySqlCommand(sql1, Conexao.conexao))
                    {
                        MySqlParameter Id_item = cmd.Parameters.Add("Item", MySqlDbType.Int32);
                        Id_item.Value = item.Id_Item;
                        MySqlParameter Id_Prod = cmd.Parameters.Add("Produto", MySqlDbType.Int32);
                        Id_Prod.Value = item.Id_Produto;
                        MySqlParameter Quant = cmd.Parameters.Add("quant", MySqlDbType.Int32);
                        Quant.Value = item.quant_vendida;
                        MySqlParameter Preco = cmd.Parameters.Add("prec", MySqlDbType.Double);
                        Preco.Value = item.prec_Unitario;
                        qtdLinhasAfetadas = cmd.ExecuteNonQuery();
                    }
                    Conexao.FC();
                    Update_estoque(produtos);
                }
            }
            catch (Exception)
            {

                throw;
            }


            return qtdLinhasAfetadas;
        }

        public int delete_Items(int id_item)
        {
            int qtdLinhasAfetadas = 0;
            try
            {
                Conexao.AC();
                String sql = "delete from Item_venda where id_Item = @id_item";
                using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                {
                    MySqlParameter ItemParameter = cmd.Parameters.Add("id_item", MySqlDbType.Int32);
                    ItemParameter.Value = id_item;
                }
                Conexao.FC();
            }
            catch (Exception)
            {

                throw;
            }
            return qtdLinhasAfetadas;
        }

        public List<Item_venda> GetTodos(int id_item)
        {
            List<Item_venda> items = new List<Item_venda>();
            try
            {
                Conexao.AC();
                String sql = "Select * from Item_venda where id_Item = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
                {
                    MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                    idParameter.Value = id_item;
                    using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Item_venda obj = new Item_venda();
                            obj.Id_Item = dataReader.GetInt32("id_Item");
                            obj.Id_Produto = dataReader.GetInt32("id_Produto");
                            obj.prec_Unitario = dataReader.GetDouble("prec_unitario");
                            obj.quant_vendida = dataReader.GetInt32("quant_vendida");
                            items.Add(obj);
                        }
                    }
                }
                Conexao.FC();
                return items;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int GetCodigo(string desc)
        {
            int id = 0;
            Conexao.AC();
            String sql = "Select id_produto from Produto where descricao = @desc_produto";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter tamParameter = cmd.Parameters.Add("desc_produto", MySqlDbType.VarChar);
                tamParameter.Value = desc;

                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        id = dataReader.GetInt32("id_produto");

                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return id;
        }

        public int GetNextVenda()
        {
            int id_venda = 0;
            Conexao.AC();
            String sql = "Select max(id_venda) from vendas group by id_venda";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        if (dataReader.HasRows)
                        {
                            id_venda = dataReader.GetInt32("max(id_venda)") + 1;
                        }
                    }
                    //if (!dataReader.Read())
                    //{
                      //  id_venda = 1;
                    //}
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return id_venda;
        }

        public int GetFunc(string desc)
        {
            int id = 0;
            Conexao.AC();
            String sql = "Select fun_id from funcionario where Nome = @nome";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter tamParameter = cmd.Parameters.Add("nome", MySqlDbType.VarChar);
                tamParameter.Value = desc;

                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        id = dataReader.GetInt32("fun_id");

                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return id;
        }

        public Produto_Dados InformaProduto(Double cod)
        {
            Produto_Dados informacoes = new Produto_Dados();
            Conexao.AC();
            String sql = "Select * from Produto where cod_barra = @cod_barra";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter tamParameter = cmd.Parameters.Add("cod_barra", MySqlDbType.Double);
                tamParameter.Value = cod;
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        informacoes.id_produto = dataReader.GetInt32("id_produto");
                        informacoes.id_fabricante = dataReader.GetInt32("id_fabricante");
                        informacoes.descricao = dataReader.GetString("descricao");
                        informacoes.Marca = dataReader.GetString("marca");
                        informacoes.unidade_med = dataReader.GetString("unidade_med");
                        informacoes.preco_venda = dataReader.GetDouble("preco_venda");
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return informacoes;
        }

        public Fabricante_Dados Nome_Fabricante(Produto_Dados informa)
        {
            Fabricante_Dados informacoes = new Fabricante_Dados();
            Conexao.AC();
            String sql = "Select nome_fabricante from Fabricante where id_fabricante = @nome";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter tamParameter = cmd.Parameters.Add("nome", MySqlDbType.VarChar);
                tamParameter.Value = informa.id_fabricante;
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        informacoes.nome_fabricante = dataReader.GetString("nome_fabricante");
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return informacoes;
        }

        public int getCliente(string cliente)
        {
            int id = 0;
            Conexao.AC();
            String sql = "Select cli_id from cliente where Nome like('" + cliente + "');";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        id = dataReader.GetInt32("cli_id");
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            Conexao.FC();
            return id;
        }
    }
}
