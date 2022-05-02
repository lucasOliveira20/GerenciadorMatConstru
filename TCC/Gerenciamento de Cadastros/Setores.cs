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
    public partial class Setores : Form
    {
        Cadastros antigo;

        public Setores(Cadastros antigo)
        {
            this.antigo = antigo;

            InitializeComponent();
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            Setor_BD sBanco = new Setor_BD();
            dataGridView1.DataSource = sBanco.Select();
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Setor";
            dataGridView1.Columns[2].HeaderText = "Sub-Setor";
            dataGridView1.Columns[3].HeaderText = "Tipo";
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                Setor_BD pBanco = new Setor_BD();
                Dados.Setor_Dados pDel = new Dados.Setor_Dados();
                pDel.id_setor = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                pBanco.DEL(pDel);
                AtualizarGrid();

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAlterarSetor_Click(object sender, EventArgs e)
        {
            this.Close();
            antigo.alterar_Setor(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 8);
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
                    DadosBD.Setor_BD a = new DadosBD.Setor_BD();
                    dataGridView1.DataSource = a.SelectbyCod(int.Parse(textBox2.Text));
                    dataGridView1.Refresh();
                }

                if (textBox2.Text != "" && rbDesc.Checked == true)
                {
                    DadosBD.Setor_BD a = new DadosBD.Setor_BD();
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
