using Dados.Veiculos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosBD.Veiculo
{

    public class Veiculo_BD
    {
        public void ADD(VeiculosDados ADDdados)
        {
            Conexao.AC();
            string sql = "insert into veiculo(desc_veiculo,ano_veiculo,placa_veiculo)values(@desc_veiculo,@ano_veiculo,@placa_veiculo)";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter desc_veiculo_Parameter = cmd.Parameters.Add("desc_veiculo", MySqlDbType.VarChar);
                desc_veiculo_Parameter.Value = ADDdados.desc_veiculo;
                MySqlParameter ano_veiculo_Parameter = cmd.Parameters.Add("ano_veiculo", MySqlDbType.VarChar);
                ano_veiculo_Parameter.Value = ADDdados.ano_veiculo;
                MySqlParameter placaveiculo_Parameter = cmd.Parameters.Add("placa_veiculo", MySqlDbType.VarChar);
                placaveiculo_Parameter.Value = ADDdados.placa_veiculo;
                cmd.ExecuteNonQuery();
            }
        }

        public void ALT(VeiculosDados ALTdados)
        {
            Conexao.AC();

            string sql = "update veiculo set desc_veiculo = @desc_veiculo, ano_veiculo = @ano_veiculo,placa_veiculo = @placa_veiculo where id_veiculo = @id_veiculo";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_veiculo_Parameter = cmd.Parameters.Add("id_veiculo", MySqlDbType.Int32);
                id_veiculo_Parameter.Value = ALTdados.id_veiculo;
                MySqlParameter desc_veiculo_Parameter = cmd.Parameters.Add("desc_veiculo", MySqlDbType.VarChar);
                desc_veiculo_Parameter.Value = ALTdados.desc_veiculo;
                MySqlParameter ano_veiculo_Parameter = cmd.Parameters.Add("ano_veiculo", MySqlDbType.VarChar);
                ano_veiculo_Parameter.Value = ALTdados.ano_veiculo;
                MySqlParameter placaveiculo_Parameter = cmd.Parameters.Add("placa_veiculo", MySqlDbType.VarChar);
                placaveiculo_Parameter.Value = ALTdados.placa_veiculo;
                cmd.ExecuteNonQuery();
                Conexao.FC();
            }
        }
        public void DEL(VeiculosDados DELdados)
        {
            Conexao.AC();

            string sql = "delete from Veiculo where id_veiculo = @id_veiculo";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_veiculo_Parameter = cmd.Parameters.Add("id_veiculo", MySqlDbType.Int32);
                id_veiculo_Parameter.Value = DELdados.id_veiculo;

                cmd.ExecuteNonQuery();
                Conexao.FC();
            }
        }
        public VeiculosDados pesquisaViaCodigo(int id)
        {
            Conexao.AC();
            string sql = "select * from veiculo where id_veiculo = @id_veiculo";
            VeiculosDados veiculo = null;
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_veiculo_Parameter = cmd.Parameters.Add("id_veiculo", MySqlDbType.Int32);
                id_veiculo_Parameter.Value = id;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        veiculo = new VeiculosDados();
                        veiculo.id_veiculo = reader.GetInt32("id_veiculo");
                        veiculo.desc_veiculo = reader.GetString("desc_veiculo");
                        veiculo.ano_veiculo = reader.GetString("ano_veiculo");
                        veiculo.placa_veiculo = reader.GetString("placa_veiculo");
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
                return veiculo;
            }
        }

        public VeiculosDados pesquisaViaDescricao(string pDados)
        {
            Conexao.AC();

            string sql = "select * from veiculo where desc_veiculo like '%@desc_veiculo%'";
            VeiculosDados veiculo = null;
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter desc_veiculo_Parameter = cmd.Parameters.Add("desc_veiculo", MySqlDbType.VarChar);
                desc_veiculo_Parameter.Value = pDados;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        veiculo = new VeiculosDados();
                        veiculo.id_veiculo = reader.GetInt32("id_veiculo");
                        veiculo.desc_veiculo = reader.GetString("desc_veiculo");
                        veiculo.ano_veiculo = reader.GetString("ano_veiculo");
                        veiculo.placa_veiculo = reader.GetString("placa_veiculo");
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
                return veiculo;
            }
        }
        public VeiculosDados pesquisaViaAno(string pDados)
        {
            Conexao.AC();

            string sql = "select * from veiculo where ano_veiculo = @ano_veiculo";
            VeiculosDados veiculo = null;
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter ano_veiculo_Parameter = cmd.Parameters.Add("ano_veiculo", MySqlDbType.VarChar);
                ano_veiculo_Parameter.Value = pDados;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        veiculo = new VeiculosDados();
                        veiculo.id_veiculo = reader.GetInt32("id_veiculo");
                        veiculo.desc_veiculo = reader.GetString("desc_veiculo");
                        veiculo.ano_veiculo = reader.GetString("ano_veiculo");
                        veiculo.placa_veiculo = reader.GetString("placa_veiculo");
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
                return veiculo;
            }

        }
        public VeiculosDados pesquisaViaplaca(string pDados)
        {
            Conexao.AC();

            string sql = "select * from veiculo where placa_veiculo = @placa_veiculo";
            VeiculosDados veiculo = null;
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter placa_veiculo_Parameter = cmd.Parameters.Add("placa_veiculo", MySqlDbType.VarChar);
                placa_veiculo_Parameter.Value = pDados;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        veiculo = new VeiculosDados();
                        veiculo.id_veiculo = reader.GetInt32("id_veiculo");
                        veiculo.desc_veiculo = reader.GetString("desc_veiculo");
                        veiculo.ano_veiculo = reader.GetString("ano_veiculo");
                        veiculo.placa_veiculo = reader.GetString("placa_veiculo");
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
                return veiculo;
            }
        }
        

        public List<VeiculosDados> Select()
        {
            Conexao.AC();
            List<VeiculosDados> veiculos = new List<VeiculosDados>();
            string sql = "select * from veiculo";
            VeiculosDados veiculo = null;
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        veiculo = new VeiculosDados();
                        veiculo.id_veiculo = reader.GetInt32("id_veiculo");
                        veiculo.desc_veiculo = reader.GetString("desc_veiculo");
                        veiculo.ano_veiculo = reader.GetString("ano_veiculo");
                        veiculo.placa_veiculo = reader.GetString("placa_veiculo");
                        veiculos.Add(veiculo);
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return veiculos;

        }

        public List<VeiculosDados> SelectbyCOD(int cod)
        {
            Conexao.AC();
            List<VeiculosDados> veiculos = new List<VeiculosDados>();
            string sql = "select * from veiculo where id_veiculo = @id";
            VeiculosDados veiculo = null;
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = cod;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        veiculo = new VeiculosDados();
                        veiculo.id_veiculo = reader.GetInt32("id_veiculo");
                        veiculo.desc_veiculo = reader.GetString("desc_veiculo");
                        veiculo.ano_veiculo = reader.GetString("ano_veiculo");
                        veiculo.placa_veiculo = reader.GetString("placa_veiculo");
                        veiculos.Add(veiculo);
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return veiculos;

        }

        public List<VeiculosDados> SelectbyAno(String ano)
        {
            Conexao.AC();
            List<VeiculosDados> veiculos = new List<VeiculosDados>();
            string sql = "select * from veiculo where ano_veiculo like '%" + ano + "%';";
            VeiculosDados veiculo = null;
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        veiculo = new VeiculosDados();
                        veiculo.id_veiculo = reader.GetInt32("id_veiculo");
                        veiculo.desc_veiculo = reader.GetString("desc_veiculo");
                        veiculo.ano_veiculo = reader.GetString("ano_veiculo");
                        veiculo.placa_veiculo = reader.GetString("placa_veiculo");
                        veiculos.Add(veiculo);
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return veiculos;

        }

        public List<VeiculosDados> SelectbyDesc(string desc)
        {
            Conexao.AC();
            List<VeiculosDados> veiculos = new List<VeiculosDados>();
            string sql = "select * from veiculo where desc_veiculo like '%" + desc + "%';";
            VeiculosDados veiculo = null;
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        veiculo = new VeiculosDados();
                        veiculo.id_veiculo = reader.GetInt32("id_veiculo");
                        veiculo.desc_veiculo = reader.GetString("desc_veiculo");
                        veiculo.ano_veiculo = reader.GetString("ano_veiculo");
                        veiculo.placa_veiculo = reader.GetString("placa_veiculo");
                        veiculos.Add(veiculo);
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return veiculos;

        }
        public List<VeiculosDados> SelectbyPlaca(string placa)
        {
            Conexao.AC();
            List<VeiculosDados> veiculos = new List<VeiculosDados>();
            string sql = "select * from veiculo where placa_veiculo like '%" + placa + "%';";
            VeiculosDados veiculo = null;
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        veiculo = new VeiculosDados();
                        veiculo.id_veiculo = reader.GetInt32("id_veiculo");
                        veiculo.desc_veiculo = reader.GetString("desc_veiculo");
                        veiculo.ano_veiculo = reader.GetString("ano_veiculo");
                        veiculo.placa_veiculo = reader.GetString("placa_veiculo");
                        veiculos.Add(veiculo);
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return veiculos;

        }
    }
}
