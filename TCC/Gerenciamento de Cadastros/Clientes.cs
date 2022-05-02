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
    public partial class Clientes_Cad : Form
    {
        Cadastros antigo;

        public Clientes_Cad(Cadastros antigo)
        {
            this.antigo = antigo;

            InitializeComponent();
            AtualizarGrid();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void AtualizarGrid()
        {
            Cliente_BD cliBanco = new Cliente_BD();
            dataGridView1.DataSource = cliBanco.Select();
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "Data de nascimento";
            dataGridView1.Columns[3].HeaderText = "Telefone";
            dataGridView1.Columns[4].HeaderText = "E-Mail";
            dataGridView1.Columns[5].HeaderText = "Registro Geral (RG)";
            dataGridView1.Columns[6].HeaderText = "Cadastro de Pessoa Física (CPF)";
            dataGridView1.Columns[7].HeaderText = "Rua";
            dataGridView1.Columns[8].HeaderText = "Razão Social";
            dataGridView1.Columns[9].HeaderText = "Tipo de Pessoa";
            dataGridView1.Columns[10].HeaderText = "CEP";
            dataGridView1.Columns[11].HeaderText = "Cidade";
            dataGridView1.Columns[12].HeaderText = "Bairro";
            dataGridView1.Columns[13].HeaderText = "Unidade da Federação";

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                Cliente_BD clibd = new Cliente_BD();
                Dados.Cliente_Dados cliDel = new Dados.Cliente_Dados();
                cliDel.cli_id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                clibd.DEL(cliDel);
                AtualizarGrid();

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.Close();
            antigo.alterar_Cli(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),2);        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (rbCod.Checked == false && rbNome.Checked == false && rbTodos.Checked == false)
            {
                MessageBox.Show("Selecione o modo des pesquisa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
            if (textBox2.Text != "" && rbCod.Checked == true)
            {
                DadosBD.Cliente_BD c = new DadosBD.Cliente_BD();
                dataGridView1.DataSource = c.SelectbyCod(int.Parse(textBox2.Text));
                dataGridView1.Refresh();
            }

            if (textBox2.Text != "" && rbNome.Checked == true)
            { 
                DadosBD.Cliente_BD c = new DadosBD.Cliente_BD();
                dataGridView1.DataSource = c.SelectbyNome(textBox2.Text);
                dataGridView1.Refresh();
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
