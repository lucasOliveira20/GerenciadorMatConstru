using Dados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DadosBD
{
    public class Produto_BD
    {
        public void ADD(Produto_Dados ADDdados)
        {
            Conexao.AC();

            string sql = "insert into Produto (id_setor,id_fabricante,cod_barra,descricao,marca,unidade_med,preco_compra,preco_venda,margem_lucro) values (@id_setor,@id_fabricante,@cod_barra,@descricao,@marca,@unidade_med,@preco_compra,@preco_venda,@margem_lucro)";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_setor = cmd.Parameters.Add("id_setor", MySqlDbType.Int32);
                id_setor.Value = ADDdados.id_setor;

                MySqlParameter id_fabricante = cmd.Parameters.Add("id_fabricante", MySqlDbType.Int32);
                id_fabricante.Value = ADDdados.id_fabricante;

                MySqlParameter cod_barra = cmd.Parameters.Add("cod_barra", MySqlDbType.Double);
                cod_barra.Value = ADDdados.cod_barra;

                MySqlParameter descricao = cmd.Parameters.Add("descricao", MySqlDbType.VarChar);
                descricao.Value = ADDdados.descricao;

                MySqlParameter marca = cmd.Parameters.Add("marca", MySqlDbType.VarChar);
                marca.Value = ADDdados.Marca;

                MySqlParameter unidade_med = cmd.Parameters.Add("unidade_med", MySqlDbType.VarChar);
                unidade_med.Value = ADDdados.unidade_med;

                MySqlParameter preco_compra = cmd.Parameters.Add("preco_compra", MySqlDbType.Double);
                preco_compra.Value = ADDdados.preco_compra;

                MySqlParameter preco_venda = cmd.Parameters.Add("preco_venda", MySqlDbType.Double);
                preco_venda.Value = ADDdados.preco_venda;

                MySqlParameter margem_lucro = cmd.Parameters.Add("margem_lucro", MySqlDbType.Double);
                margem_lucro.Value = ADDdados.margem_lucro;

                //
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
        }

        public void ALT(Produto_Dados ALTdados)
        {
            Conexao.AC();

            string sql = "update Produto set id_setor = @id_setor, descricao = @descricao, id_fabricante = @id_fabricante, cod_barra = @cod_barra, marca = @marca, unidade_med = @unidade_med, preco_compra = @preco_compra, preco_venda = @preco_venda, margem_lucro = @margem_lucro  where id_produto = @id_produto";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_produto = cmd.Parameters.Add("id_produto", MySqlDbType.Int32);
                id_produto.Value = ALTdados.id_produto;

                MySqlParameter id_setor = cmd.Parameters.Add("id_setor", MySqlDbType.Int32);
                id_setor.Value = ALTdados.id_setor;

                MySqlParameter descricao = cmd.Parameters.Add("descricao", MySqlDbType.VarChar);
                descricao.Value = ALTdados.descricao;

                MySqlParameter id_fabricante = cmd.Parameters.Add("id_fabricante", MySqlDbType.VarChar);
                id_fabricante.Value = ALTdados.id_fabricante;

                MySqlParameter cod_barra = cmd.Parameters.Add("cod_barra", MySqlDbType.Double);
                cod_barra.Value = ALTdados.cod_barra;

                MySqlParameter marca = cmd.Parameters.Add("marca", MySqlDbType.VarChar);
                marca.Value = ALTdados.Marca;

                MySqlParameter unidade_med = cmd.Parameters.Add("unidade_med", MySqlDbType.VarChar);
                unidade_med.Value = ALTdados.unidade_med;

                MySqlParameter preco_compra = cmd.Parameters.Add("preco_compra", MySqlDbType.VarChar);
                preco_compra.Value = ALTdados.preco_compra;

                MySqlParameter preco_venda = cmd.Parameters.Add("preco_venda", MySqlDbType.VarChar);
                preco_venda.Value = ALTdados.preco_venda;

                MySqlParameter margem_lucro = cmd.Parameters.Add("margem_lucro", MySqlDbType.VarChar);
                margem_lucro.Value = ALTdados.margem_lucro;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
        }

        public void DEL(Produto_Dados ALTdados)
        {
            Conexao.AC();

            string sql = "delete from Produto where id_produto = @id_produto";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_produto = cmd.Parameters.Add("id_produto", MySqlDbType.Int32);
                id_produto.Value = ALTdados.id_produto;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }

        }

        public Produto_Dados BviaCod(int id)
        {
            Conexao.AC();
            Dados.Produto_Dados produto = null;
            string sql = "select * from Produto where id_produto = @id_produto";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_produto = cmd.Parameters.Add("id_produto", MySqlDbType.Int32);
                id_produto.Value = id;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        produto = new Produto_Dados();
                        produto.id_produto = reader.GetInt32("id_produto");
                        produto.id_setor = reader.GetInt32("id_setor");
                        produto.id_fabricante = reader.GetInt32("id_fabricante");
                        produto.cod_barra = reader.GetDouble("cod_barra");
                        produto.descricao = reader.GetString("descricao");
                        produto.Marca = reader.GetString("marca");
                        produto.unidade_med = reader.GetString("unidade_med");
                        produto.preco_compra = reader.GetDouble("preco_compra");
                        produto.preco_venda = reader.GetDouble("preco_venda");
                        produto.margem_lucro = reader.GetDouble("margem_lucro");
                        
                    
                    }
                    reader.Close();
                    reader.Dispose();
                }

                cmd.ExecuteNonQuery();

                Conexao.FC();
                return produto;
            }
        }

        public Produto_Dados BviaDesc(string descricao)
        {
            Conexao.AC();
            Dados.Produto_Dados produto = null;
            string sql = "select * from Produto where descricao like '%@descricao%'";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter D = cmd.Parameters.Add("descricao", MySqlDbType.VarChar);
                D.Value = descricao;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        produto = new Produto_Dados();
                        produto.id_produto = reader.GetInt32("id_produto");
                        produto.id_setor = reader.GetInt32("id_setor");
                        produto.id_fabricante = reader.GetInt32("id_fabricante");
                        produto.cod_barra = reader.GetDouble("cod_barra");
                        produto.descricao = reader.GetString("descricao");
                        produto.Marca = reader.GetString("marca");
                        produto.unidade_med = reader.GetString("unidade_med");
                        produto.preco_compra = reader.GetDouble("preco_compra");
                        produto.preco_venda = reader.GetDouble("preco_venda");
                        produto.margem_lucro = reader.GetDouble("margem_lucro");

                    }
                    reader.Close();
                    reader.Dispose();
                }

                cmd.ExecuteNonQuery();

                Conexao.FC();
                return produto;
            }
        }

        public List<Produto_Dados> Select()
        {
            List<Produto_Dados> produtos = new List<Produto_Dados>();
            Produto_Dados produto = null;
            Conexao.AC();

            string sql = "select * from Produto";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        produto = new Produto_Dados();
                     
                        produto.id_produto = reader.GetInt32("id_produto");
                        produto.id_setor = reader.GetInt32("id_setor");
                        produto.id_fabricante = reader.GetInt32("id_fabricante");
                        produto.cod_barra = reader.GetDouble("cod_barra");
                        produto.descricao = reader.GetString("descricao");
                        produto.Marca = reader.GetString("marca");
                        produto.unidade_med = reader.GetString("unidade_med");
                        produto.preco_compra = reader.GetDouble("preco_compra");
                        produto.preco_venda = reader.GetDouble("preco_venda");
                        produto.margem_lucro = reader.GetDouble("margem_lucro");
                        produtos.Add(produto);

                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return produtos;
        }

        public List<Produto_Dados> SelectbyCod(Double cod)
        {
            List<Produto_Dados> produtos = new List<Produto_Dados>();
            Produto_Dados produto = null;
            Conexao.AC();

            string sql = "select * from Produto where cod_barra = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Double);
                idParameter.Value = cod;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        produto = new Produto_Dados();

                        produto.id_produto = reader.GetInt32("id_produto");
                        produto.id_setor = reader.GetInt32("id_setor");
                        produto.id_fabricante = reader.GetInt32("id_fabricante");
                        produto.cod_barra = reader.GetDouble("cod_barra");
                        produto.descricao = reader.GetString("descricao");
                        produto.Marca = reader.GetString("marca");
                        produto.unidade_med = reader.GetString("unidade_med");
                        produto.preco_compra = reader.GetDouble("preco_compra");
                        produto.preco_venda = reader.GetDouble("preco_venda");
                        produto.margem_lucro = reader.GetDouble("margem_lucro");
                        produtos.Add(produto);

                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return produtos;
        }

        public Double SelectPrecobyCod(Double cod)
        {
            Produto_Dados produto = null;
            Conexao.AC();

            string sql = "select preco_venda from Produto where cod_barra = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Double);
                idParameter.Value = cod;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        produto = new Produto_Dados();                        
                        produto.preco_venda = reader.GetDouble("preco_venda");


                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return produto.preco_venda;
        }

        public List<Produto_Dados> SelectbyNome(string nome)
        {
            List<Produto_Dados> produtos = new List<Produto_Dados>();
            Produto_Dados produto = null;
            Conexao.AC();

            string sql = "select * from Produto where descricao like '%" + nome + "%';";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        produto = new Produto_Dados();

                        produto.id_produto = reader.GetInt32("id_produto");
                        produto.id_setor = reader.GetInt32("id_setor");
                        produto.id_fabricante = reader.GetInt32("id_fabricante");
                        produto.cod_barra = reader.GetDouble("cod_barra");
                        produto.descricao = reader.GetString("descricao");
                        produto.Marca = reader.GetString("marca");
                        produto.unidade_med = reader.GetString("unidade_med");
                        produto.preco_compra = reader.GetDouble("preco_compra");
                        produto.preco_venda = reader.GetDouble("preco_venda");
                        produto.margem_lucro = reader.GetDouble("margem_lucro");
                        produtos.Add(produto);

                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return produtos;
        }

        public string GetSetor(int id)
        {
            Conexao.AC();
            string Nome_Funcao = null;
            string sql = "Select setor_produto, sub_setor_produto, tipo from Setor where id_Setor = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = id;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Nome_Funcao = "Setor: " + reader.GetString("setor_produto") + "Sub-Setor: " + reader.GetString("sub_setor_produto") + "Tipo: " + reader.GetString("tipo");
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
            return Nome_Funcao;
        }

        public string GetFabricante(int id)
        {
            Conexao.AC();
            string Nome_Funcao = null;
            string sql = "Select nome_fabricante from Fabricante where id_fabricante = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = id;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Nome_Funcao = reader.GetString("nome_fabricante");
                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
            return Nome_Funcao;
        }
    }
}
