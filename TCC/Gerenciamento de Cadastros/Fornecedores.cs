using Dados.Fornecedor;
using DadosBD;
using DadosBD.Fornecedor;
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
    public partial class Fornecedores_Cad : Form
    {
        Cadastros antigo;

        public Fornecedores_Cad(Cadastros antigo)
        {
            this.antigo = antigo;

            InitializeComponent();
            AtualizarGrid();
            
        }

        public void AtualizarGrid()
        {
            Fornecedor_BD forBanco = new Fornecedor_BD();
            dataGridView1.DataSource = forBanco.Select();
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "Data de Nascimento";
            dataGridView1.Columns[3].HeaderText = "Telefone";
            dataGridView1.Columns[4].HeaderText = "E-Mail";
            dataGridView1.Columns[5].HeaderText = "Registro Geral (RG)";
            dataGridView1.Columns[6].HeaderText = "Cadastro de Pessoa Física (CPF)";
            dataGridView1.Columns[7].HeaderText = "Rua";
            dataGridView1.Columns[8].HeaderText = "CEP";
            dataGridView1.Columns[9].HeaderText = "Inscrição Estadual";
            dataGridView1.Columns[10].HeaderText = "Site";
            dataGridView1.Columns[11].HeaderText = "Razão Social";
            dataGridView1.Columns[12].HeaderText = "Tipo de Pessoa";
            dataGridView1.Columns[13].HeaderText = "CNPJ";
            dataGridView1.Columns[14].HeaderText = "Bairro";
            dataGridView1.Columns[15].HeaderText = "Cidade";
            dataGridView1.Columns[16].HeaderText = "Unidade da Federação";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                DadosBD.Fornecedor.Fornecedor_BD uBanco = new DadosBD.Fornecedor.Fornecedor_BD();
                Dados.Fornecedor.Fornecedor_Dados uDel = new Dados.Fornecedor.Fornecedor_Dados();
                uDel.for_id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                uBanco.DEL(uDel);
                AtualizarGrid();

            }
        }

        private void btnALTforn_Click(object sender, EventArgs e)
        {
            this.Close();
            antigo.alterar_Forn(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 5);
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
                    DadosBD.Fornecedor.Fornecedor_BD a = new DadosBD.Fornecedor.Fornecedor_BD();
                    dataGridView1.DataSource = a.SelectbyCod(int.Parse(textBox2.Text));
                    dataGridView1.Refresh();
                }

                if (textBox2.Text != "" && rbDesc.Checked == true)
                {
                    DadosBD.Fornecedor.Fornecedor_BD a = new DadosBD.Fornecedor.Fornecedor_BD();
                    dataGridView1.DataSource = a.SelectbyNome(textBox2.Text);
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
