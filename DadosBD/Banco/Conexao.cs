using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosBD
{
    public class Conexao
    {
        public static MySqlConnection conexao = null;
        public static void AC()
        {
            try
            {

                conexao = new MySqlConnection("Server=localhost;Port=3306;Database=matconstru;Uid=root;Password=root;");
                if (conexao.State != ConnectionState.Open)
                {
                    conexao.Open();
                }
            }
            catch (Exception)
            {
               //tratamento de possiveis erros
            }

        }

        public static void FC()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
