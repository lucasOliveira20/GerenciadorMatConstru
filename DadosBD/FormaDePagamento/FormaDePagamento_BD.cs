using Dados.FormaDePagamento;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosBD.FormaDePagamento
{
    public class FormaDePagamento_BD
    {
        public void ADD(FormaDePagamento_Dados ADDados)
        {
            Conexao.AC();

            string sql = "insert into Forma_pag(desc_formPag)value(@desc_formPag)";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter desc_FormPag_Parameter = cmd.Parameters.Add("desc_formPag", MySqlDbType.VarChar);
                desc_FormPag_Parameter.Value = ADDados.desc_formade;
                cmd.ExecuteNonQuery();
                Conexao.FC();
            }
        }

        public void ALT(FormaDePagamento_Dados ALTdados)
        {
            Conexao.AC();
            string sql = "update Forma_pag set desc_formPag = @desc_formPag where id_formaPag = @id_formaPag";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_formaPag_Parameter = cmd.Parameters.Add("id_formaPag", MySqlDbType.Int32);
                id_formaPag_Parameter.Value = ALTdados.id_FormaPag;

                MySqlParameter desc_FormPag_Parameter = cmd.Parameters.Add("desc_formPag", MySqlDbType.VarChar);
                desc_FormPag_Parameter.Value = ALTdados.desc_formade;

                cmd.ExecuteNonQuery();
                Conexao.FC();
            }

        }

        public void DEL(FormaDePagamento_Dados DELdados)
        {
            Conexao.AC();

            string sql = "delete from Forma_pag where id_formaPag = @id_formaPag";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_formaPag_Parameter = cmd.Parameters.Add("id_formaPag", MySqlDbType.Int32);
                id_formaPag_Parameter.Value = DELdados.id_FormaPag;
                cmd.ExecuteNonQuery();
                Conexao.FC();
            }

        }

        public FormaDePagamento_Dados buscarViaCod(int id)
        {
            Conexao.AC();

            FormaDePagamento_Dados Formapag = null;
            string sql = "select * from Forma_Pag where id_formaPag = @id_formaPag";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter id_formaPag_Parameter = cmd.Parameters.Add("id_formaPag", MySqlDbType.Int32);
                id_formaPag_Parameter.Value = id;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Formapag = new FormaDePagamento_Dados();
                        Formapag.id_FormaPag = reader.GetInt32("id_formaPag");
                        Formapag.desc_formade = reader.GetString("desc_formPag");
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();
                Conexao.FC();
                return Formapag;
            }
        }

        public FormaDePagamento_Dados pesquisaViaDescricao(string desc)
        {
            Conexao.AC();

            FormaDePagamento_Dados Formapag = null;
            string sql = "select * from Forma_pag where desc_formPag like '%@desc_formPag%'";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter desc_formPag_Parameter = cmd.Parameters.Add("desc_formPag", MySqlDbType.VarChar);
                desc_formPag_Parameter.Value = desc;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Formapag = new FormaDePagamento_Dados();
                        Formapag.id_FormaPag = reader.GetInt32("id_formaPag");
                        Formapag.desc_formade = reader.GetString("desc_formPag");
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
                return Formapag;
            }


        }
        public List<FormaDePagamento_Dados> Select()
        {

            List<FormaDePagamento_Dados> Formas = new List<FormaDePagamento_Dados>();
            FormaDePagamento_Dados forma = new FormaDePagamento_Dados();
            Conexao.AC();
            string sql = "select * from Forma_pag";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        forma = new FormaDePagamento_Dados();
                        forma.id_FormaPag = reader.GetInt32("id_formaPag");
                        forma.desc_formade = reader.GetString("desc_formPag");
                        Formas.Add(forma);
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return Formas;
        }

        public List<FormaDePagamento_Dados> SelectbyCod(int id)
        {

            List<FormaDePagamento_Dados> Formas = new List<FormaDePagamento_Dados>();
            FormaDePagamento_Dados forma = new FormaDePagamento_Dados();
            Conexao.AC();
            string sql = "select * from Forma_pag where id_formaPag = @id;";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = id;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        forma = new FormaDePagamento_Dados();
                        forma.id_FormaPag = reader.GetInt32("id_formaPag");
                        forma.desc_formade = reader.GetString("desc_formPag");
                        Formas.Add(forma);
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return Formas;
        }

        public List<FormaDePagamento_Dados> SelectbyDesc(string desc)
        {

            List<FormaDePagamento_Dados> Formas = new List<FormaDePagamento_Dados>();
            FormaDePagamento_Dados forma = new FormaDePagamento_Dados();
            Conexao.AC();
            string sql = "select * from Forma_pag where desc_formPag like '%" + desc + "%';";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        forma = new FormaDePagamento_Dados();
                        forma.id_FormaPag = reader.GetInt32("id_formaPag");
                        forma.desc_formade = reader.GetString("desc_formPag");
                        Formas.Add(forma);
                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return Formas;
        }
    }
}
