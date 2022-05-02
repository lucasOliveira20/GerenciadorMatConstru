using DadosBD;
using DadosBD.FormaDePagamento;
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
    public partial class FormasdePagamento : Form
    {
        Cadastros antigo;

        public FormasdePagamento(Cadastros antigo)
        {
            this.antigo = antigo;

            InitializeComponent();
            AtualizarGrid();

        }

        public void AtualizarGrid()
        {
            FormaDePagamento_BD uBanco = new FormaDePagamento_BD();
            dataGridView1.DataSource = uBanco.Select();
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Descrição";
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                FormaDePagamento_BD uBanco = new FormaDePagamento_BD();
                Dados.FormaDePagamento.FormaDePagamento_Dados uDel = new Dados.FormaDePagamento.FormaDePagamento_Dados();
                uDel.id_FormaPag = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                uBanco.DEL(uDel);
                AtualizarGrid();

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnALT_Click(object sender, EventArgs e)
        {
            this.Close();
            antigo.alterar_FormaPg(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),10);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (rbCod.Checked == false && rbForma.Checked == false && rbTodos.Checked == false)
            {
                MessageBox.Show("Selecione o modo des pesquisa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBox2.Text != "" && rbCod.Checked == true)
                {
                    DadosBD.FormaDePagamento.FormaDePagamento_BD a = new DadosBD.FormaDePagamento.FormaDePagamento_BD();
                    dataGridView1.DataSource = a.SelectbyCod(int.Parse(textBox2.Text));
                    dataGridView1.Refresh();
                }

                if (textBox2.Text != "" && rbForma.Checked == true)
                {
                    DadosBD.FormaDePagamento.FormaDePagamento_BD a = new DadosBD.FormaDePagamento.FormaDePagamento_BD();
                    dataGridView1.DataSource = a.SelectbyDesc(textBox2.Text);
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
