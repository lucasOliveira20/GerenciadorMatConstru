 using Dados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosBD
{
    public class Usuario_BD
    {
        public void ADD(Usuario_Dados ADDdados)
        {
            Conexao.AC();

            string sql = "insert into usuario(func_id,user_log,user_pwd) values (@func_id,@user_log,@user_pwd)";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter func_id = cmd.Parameters.Add("func_id", MySqlDbType.VarChar);
                func_id.Value = ADDdados.func_id;

                MySqlParameter user_log = cmd.Parameters.Add("user_log", MySqlDbType.VarChar);
                user_log.Value = ADDdados.user_log;

                MySqlParameter user_pwd = cmd.Parameters.Add("user_pwd", MySqlDbType.VarChar);
                user_pwd.Value = ADDdados.user_pwd;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
        }

        public void ALT(Usuario_Dados ALTdados)
        {
            Conexao.AC();

            string sql = "update usuario set func_id = @func_id, user_log = @user_log,user_pwd = @user_pwd where user_id = @user_id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter user_id = cmd.Parameters.Add("user_id", MySqlDbType.Int32);
                user_id.Value = ALTdados.user_id;

                MySqlParameter func_id = cmd.Parameters.Add("func_id", MySqlDbType.Int32);
                func_id.Value = ALTdados.func_id;

                MySqlParameter user_log = cmd.Parameters.Add("user_log", MySqlDbType.VarChar);
                user_log.Value = ALTdados.user_log;

                MySqlParameter user_pwd = cmd.Parameters.Add("user_pwd", MySqlDbType.VarChar);
                user_pwd.Value = ALTdados.user_pwd;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
        }


        public void DEL(Usuario_Dados DELdados)
        {
            Conexao.AC();

            string sql = "delete from usuario where user_id = @user_id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter func_id = cmd.Parameters.Add("user_id", MySqlDbType.Int32);
                func_id.Value = DELdados.user_id;

                cmd.ExecuteNonQuery();

                Conexao.FC();
            }

        }

        public Dados.Usuario_Dados BviaCod(int id)
        {
            Conexao.AC();
            Usuario_Dados usuario = null;
            string sql = "select * from usuario where user_id = @user_id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter func_id = cmd.Parameters.Add("user_id", MySqlDbType.Int32);
                func_id.Value = id;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new Usuario_Dados();

                        usuario.user_id = reader.GetInt32("user_id");
                        usuario.func_id = reader.GetInt32("func_id");
                        usuario.user_log = reader.GetString("user_log");
                        usuario.user_pwd = reader.GetString("user_pwd");
                        
                    }
                }

                cmd.ExecuteNonQuery();

                Conexao.FC();
                return usuario;
            }
        }

        public Usuario_Dados BviaUsuario(string user)
        {
            Conexao.AC();
            Usuario_Dados usuario = null;
            string sql = "select * from usuario where user_log like '%@user_log%'";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter user_log = cmd.Parameters.Add("user_log", MySqlDbType.VarChar);
                user_log.Value = user;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usuario = new Usuario_Dados();
                        usuario.user_id = reader.GetInt32("user_id");
                        usuario.func_id = reader.GetInt32("func_id");
                        usuario.user_log = reader.GetString("user_log");
                        usuario.user_pwd = reader.GetString("user_pwd");

                    }
                    reader.Close();
                    reader.Dispose();
                }

                cmd.ExecuteNonQuery();

                Conexao.FC();
                return usuario;
            }
        }

        public List<Usuario_Dados> Select()
        {
            List<Usuario_Dados> usuarios = new List<Usuario_Dados>();
            Usuario_Dados usuario = null;
            Conexao.AC();

            string sql = "select * from usuario";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usuario = new Usuario_Dados();
                        usuario.user_id = reader.GetInt32("user_id");
                        usuario.func_id = reader.GetInt32("func_id");
                        usuario.user_log = reader.GetString("user_log");
                        usuario.user_pwd = reader.GetString("user_pwd");
                        usuarios.Add(usuario);

                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return usuarios;
        }

        public List<Usuario_Dados> SelectbyFunc(int id)
        {
            List<Usuario_Dados> usuarios = new List<Usuario_Dados>();
            Usuario_Dados usuario = null;
            Conexao.AC();

            string sql = "select * from usuario where func_id = @id";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter idParameter = cmd.Parameters.Add("id", MySqlDbType.Int32);
                idParameter.Value = id;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usuario = new Usuario_Dados();
                        usuario.user_id = reader.GetInt32("user_id");
                        usuario.func_id = reader.GetInt32("func_id");
                        usuario.user_log = reader.GetString("user_log");
                        usuario.user_pwd = reader.GetString("user_pwd");
                        usuarios.Add(usuario);

                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return usuarios;
        }

        public List<Usuario_Dados> SelectByLogin(string login)
        {
            List<Usuario_Dados> usuarios = new List<Usuario_Dados>();
            Usuario_Dados usuario = null;
            Conexao.AC();

            string sql = "select * from usuario where user_log like '%" + login + "%';";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usuario = new Usuario_Dados();
                        usuario.user_id = reader.GetInt32("user_id");
                        usuario.func_id = reader.GetInt32("func_id");
                        usuario.user_log = reader.GetString("user_log");
                        usuario.user_pwd = reader.GetString("user_pwd");
                        usuarios.Add(usuario);

                    }
                    reader.Close();
                    reader.Dispose();
                }
                cmd.ExecuteNonQuery();

                Conexao.FC();
            }
            return usuarios;
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
    }
}
