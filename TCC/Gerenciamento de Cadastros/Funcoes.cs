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
    public partial class Funcoes : Form
    {
        Cadastros antigo;

        public Funcoes(Cadastros antigo)
        {
            this.antigo = antigo;

            InitializeComponent();
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            Funcao_BD uBanco = new Funcao_BD();
            dataGridView1.DataSource = uBanco.Select();
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Descrição";
            dataGridView1.Columns[2].HeaderText = "Salário";
            dataGridView1.Columns[3].HeaderText = "Carga Horária";
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                Funcao_BD funcBanco = new Funcao_BD();
                Dados.Funcao_Dados funcDel = new Dados.Funcao_Dados();
                funcDel.id_funcao = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                funcBanco.DEL(funcDel);
                AtualizarGrid();

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAlterarFuncao_Click(object sender, EventArgs e)
        {
            this.Close();
            antigo.alterar_Funcao(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 4);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (rbCod.Checked == false && rbDesc.Checked == false && rbTodos.Checked == false)
            {
                MessageBox.Show("Selecione o modo des pesquisa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBox2.Text != "" && rbCod.Checked == true)
                {
                    DadosBD.Funcao_BD a = new DadosBD.Funcao_BD();
                    dataGridView1.DataSource = a.SelectbyCod(int.Parse(textBox2.Text));
                }

                if (textBox2.Text != "" && rbDesc.Checked == true)
                {
                    DadosBD.Funcao_BD a = new DadosBD.Funcao_BD();
                    dataGridView1.DataSource = a.SelectbyNome(textBox2.Text);
                }
            }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
            textBox2.Text = "";
        }
    }
}
