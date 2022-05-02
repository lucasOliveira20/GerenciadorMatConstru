using DadosBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Gerenciamento_de_Cadastros
{
    public partial class Usuarios : Form
    {
        Cadastros antigo;

        public Usuarios(Cadastros antigo)
        {
            this.antigo = antigo;

            InitializeComponent();
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            Usuario_BD uBanco = new Usuario_BD();
            List<Dados.Usuario_DadosGrid> todos = new List<Dados.Usuario_DadosGrid>();
            foreach (Dados.Usuario_Dados item in uBanco.Select())
            {
                Dados.Usuario_DadosGrid add = new Dados.Usuario_DadosGrid();
                add.func_id = uBanco.GetFuncionario(item.func_id);
                add.user_id = item.user_id.ToString();
                add.user_log = item.user_log;
                add.user_pwd = item.user_pwd;
                todos.Add(add);
            } 
            dataGridView1.DataSource = todos;
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Funcionário";
            dataGridView1.Columns[2].HeaderText = "Login";
            dataGridView1.Columns[3].HeaderText = "Senha";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (rbCod.Checked == false && rbDesc.Checked == false && rbTodos.Checked == false)
            {
                MessageBox.Show("Selecione o modo des pesquisa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                if (textBox2.Text != "" && rbCod.Checked == true)
                {
                    DadosBD.Usuario_BD a = new DadosBD.Usuario_BD();
                    dataGridView1.DataSource = a.SelectbyFunc(int.Parse(textBox2.Text));
                    dataGridView1.Refresh();
                }

                if (textBox2.Text != "" && rbDesc.Checked == true)
                {
                    DadosBD.Usuario_BD a = new DadosBD.Usuario_BD();
                    dataGridView1.DataSource = a.SelectByLogin(textBox2.Text);
                    dataGridView1.Refresh();
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                Usuario_BD uBanco = new Usuario_BD();
                Dados.Usuario_Dados uDel = new Dados.Usuario_Dados();
                uDel.user_id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                uBanco.DEL(uDel);
                AtualizarGrid();

            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.Close();
            antigo.alterar_User(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 3);
        }

        private void btnVolt_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
            textBox2.Text = "";
        }
    }
}
