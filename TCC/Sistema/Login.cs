using DadosBD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TCC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            /*Thread t = new Thread(new ThreadStart(SplachScren));
            t.Start();
            Thread.Sleep(5000);
            t.Abort();*/
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            logar();
            
            txtLogin.Text = String.Empty;
            txtSenha.Text = String.Empty;

        }

        public string logar()
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            Conexao.AC();

            String sql = "select * from usuario where user_log = @user_log and user_pwd = @user_pwd";
            using (MySqlCommand cmd = new MySqlCommand(sql, Conexao.conexao))
            {
                MySqlParameter loginParameter = cmd.Parameters.Add("user_log", MySqlDbType.VarChar);
                loginParameter.Value = login;
                MySqlParameter senhaParameter = cmd.Parameters.Add("user_pwd", MySqlDbType.VarChar);
                senhaParameter.Value = senha;

                bool busca = cmd.ExecuteReader().HasRows;
                {
                    if (busca == true)
                    {
                        this.Close();
                        Principal principal = new Principal(this);   
                        principal.ShowDialog();
                        
                    }
                    else
                    {
                        MessageBox.Show("Login e/ou senha inválidos!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                Conexao.FC();
                return "OK";

            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

    }
}
