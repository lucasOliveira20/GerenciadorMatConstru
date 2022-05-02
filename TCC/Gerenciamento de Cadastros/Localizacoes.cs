using DadosBD.Localizacao;
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
    public partial class Localizacoes : Form
    {
        Cadastros antigo;

        public Localizacoes(Cadastros antigo)
        {
            this.antigo = antigo;

            InitializeComponent();
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            Localizacao_BD uBanco = new Localizacao_BD();
            dataGridView1.DataSource = uBanco.Select();
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Corredor";
            dataGridView1.Columns[2].HeaderText = "Prateleira";
            dataGridView1.Columns[3].HeaderText = "Gaveta";
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                Localizacao_BD funcBanco = new Localizacao_BD();
                Dados.Localização.Localizacao_Dados funcDel = new Dados.Localização.Localizacao_Dados();
                funcDel.id_loc = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                funcBanco.DEL(funcDel);
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
            antigo.alterar_Loc(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),9);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (rbCod.Checked == false && rbC.Checked == false && rbP.Checked == false && rbTodos.Checked == false)
            {
                MessageBox.Show("Selecione o modo des pesquisa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBox2.Text != "" && rbCod.Checked == true)
                {
                    DadosBD.Localizacao.Localizacao_BD a = new DadosBD.Localizacao.Localizacao_BD();
                    dataGridView1.DataSource = a.SelectbyCod(int.Parse(textBox2.Text));
                    dataGridView1.Refresh();
                }

                if (textBox2.Text != "" && rbC.Checked == true)
                {
                    DadosBD.Localizacao.Localizacao_BD a = new DadosBD.Localizacao.Localizacao_BD();
                    dataGridView1.DataSource = a.SelectbyCorredor(textBox2.Text);
                    dataGridView1.Refresh();
                }

                if (textBox2.Text != "" && rbP.Checked == true)
                {
                    DadosBD.Localizacao.Localizacao_BD a = new DadosBD.Localizacao.Localizacao_BD();
                    dataGridView1.DataSource = a.SelectbyPratelheira(textBox2.Text);
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
