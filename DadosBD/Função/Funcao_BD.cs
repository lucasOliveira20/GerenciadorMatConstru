using Dados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosBD
{
    public class Funcao_BD
    {
        public void ADD(Funcao_Dados ADDdados)
        {
            Conexao.AC();

            string sql = "insert into funcao(desc_funcao,salario,carga_horaria) values (@desc_funcao,@salario,@carga_horaria)";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {

                MySqlParameter desc_funcao = cmd.Parameters.Add("desc_funcao", MySqlDbType.VarChar);
                desc_funcao.Value = ADDdados.desc_funcao;

                MySqlParameter salario = cmd.Parameters.Add("salario", MySqlDbType.Double);
                salario.Value = ADDdados.salario;

                MySqlParameter carga_horaria = cmd.Parameters.Add("carga_horaria", MySqlDbType.VarChar);
                carga_horaria.Value = ADDdados.carga_horaria;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
        }

        public void ALT(Funcao_Dados ALTdados)
        {
            Conexao.AC();

            string sql = "update funcao set desc_funcao = @desc_funcao,salario = @salario,carga_horaria = @carga_horaria  where id_funcao = @id_funcao";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_funcao = cmd.Parameters.Add("id_funcao", MySqlDbType.Int32);
                id_funcao.Value = ALTdados.id_funcao;

                MySqlParameter desc_funcao = cmd.Parameters.Add("desc_funcao", MySqlDbType.VarChar);
                desc_funcao.Value = ALTdados.desc_funcao;

                MySqlParameter salario = cmd.Parameters.Add("salario", MySqlDbType.Double);
                salario.Value = ALTdados.salario;

                MySqlParameter carga_horaria = cmd.Parameters.Add("carga_horaria", MySqlDbType.VarChar);
                carga_horaria.Value = ALTdados.carga_horaria;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
        }


        public void DEL(Funcao_Dados DELdados)
        {
            Conexao.AC();

            string sql = "delete from funcao where id_funcao = @id_funcao";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_funcao = cmd.Parameters.Add("id_funcao", MySqlDbType.Int32);
                id_funcao.Value = DELdados.id_funcao;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }

        }

        public Dados.Funcao_Dados BviaCod(int id)
        {
            Conexao.AC();
            Funcao_Dados funcao = null;
            string sql = "select * from funcao where id_funcao = @id_funcao";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_funcao = cmd.Parameters.Add("id_funcao", MySqlDbType.Int32);
                id_funcao.Value = id;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        funcao = new Funcao_Dados();
                        funcao.id_funcao = reader.GetInt32("id_funcao");
                        funcao.desc_funcao = reader.GetString("desc_funcao");
                        funcao.carga_horaria = reader.GetString("carga_horaria");
                        funcao.salario = reader.GetDouble("salario");
                    }
                    reader.Close();
                    reader.Dispose();
                }

                cmd.ExecuteNonQuery();

                Conexao.FC();
                return funcao;
            }
        }

        public Funcao_Dados BviaNome(string nome)
        {
            Conexao.AC();
            Funcao_Dados funcao = null;
            string sql = "select * from funcao where desc_funcao like '%@desc_funcao%'";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter Nome = cmd.Parameters.Add("desc_funcao", MySqlDbType.VarChar);
                Nome.Value = nome;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        funcao = new Funcao_Dados();
                        funcao.id_funcao = reader.GetInt32("id_funcao");
                        funcao.desc_funcao = reader.GetString("desc_funcao");
                        funcao.carga_horaria = reader.GetString("carga_horaria");
                        funcao.salario = reader.GetDouble("salario");                     

                    }
                    reader.Close();
                    reader.Dispose();
                }

                cmd.ExecuteNonQuery();

                Conexao.FC();
                return funcao;
            }
        }

        public List<Funcao_Dados> Select()
        {
            List<Funcao_Dados> func = new List<Funcao_Dados>();
            Funcao_Dados funcao = null;
            Conexao.AC();

            string sql = "select * from funcao";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        funcao = new Funcao_Dados();
                        funcao.id_funcao = reader.GetInt32("id_funcao");
                        funcao.desc_funcao = reader.GetString("desc_funcao");
                        funcao.carga_horaria = reader.GetString("carga_horaria");
                        funcao.salario = reader.GetDouble("salario");
                        func.Add(funcao);
                        
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return func;
        }

        public List<Funcao_Dados> SelectbyNome(string nome)
        {
            List<Funcao_Dados> func = new List<Funcao_Dados>();
            Funcao_Dados funcao = null;
            Conexao.AC();

            string sql = "select * from funcao where desc_funcao like '%" + nome + "%';";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                //MySqlParameter nomeParameter = cmd.Parameters.Add("nome",MySqlDbType.VarChar);
                //nomeParameter.Value = nome;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        funcao = new Funcao_Dados();
                        funcao.id_funcao = reader.GetInt32("id_funcao");
                        funcao.desc_funcao = reader.GetString("desc_funcao");
                        funcao.carga_horaria = reader.GetString("carga_horaria");
                        funcao.salario = reader.GetDouble("salario");
                        func.Add(funcao);

                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return func;
        }

        public List<Funcao_Dados> SelectbyCod(int cod)
        {
            List<Funcao_Dados> func = new List<Funcao_Dados>();
            Funcao_Dados funcao = null;
            Conexao.AC();

            string sql = "select * from funcao where id_funcao = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.VarChar);
                idParameter.Value = cod;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        funcao = new Funcao_Dados();
                        funcao.id_funcao = reader.GetInt32("id_funcao");
                        funcao.desc_funcao = reader.GetString("desc_funcao");
                        funcao.carga_horaria = reader.GetString("carga_horaria");
                        funcao.salario = reader.GetDouble("salario");
                        func.Add(funcao);

                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return func;
        }
    }
}
