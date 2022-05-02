using DadosBD;
using DadosBD.Produto;
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
    public partial class Fabricantes : Form
    {
        Cadastros antigo;

        public Fabricantes(Cadastros antigo)
        {
            this.antigo = antigo;

            InitializeComponent();
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            Fabricante_BD fabBanco = new Fabricante_BD();
            dataGridView1.DataSource = fabBanco.Select();
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Nome do Fabricante";
            dataGridView1.Columns[2].HeaderText = "Marca do Fabricante";
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                Fabricante_BD uBanco = new Fabricante_BD();
                Dados.Fabricante_Dados uDel = new Dados.Fabricante_Dados();
                uDel.id_fabricante = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
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
            antigo.alterar_Fabricante(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 7);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (rbCod.Checked == false && rbNome.Checked == false && rbMarca.Checked == false && rbTodos.Checked == false)
            {
                MessageBox.Show("Selecione o modo des pesquisa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBox2.Text != "" && rbCod.Checked == true)
                {
                    DadosBD.Produto.Fabricante_BD a = new DadosBD.Produto.Fabricante_BD();
                    dataGridView1.DataSource = a.SelectbyCod(int.Parse(textBox2.Text));
                    dataGridView1.Refresh();
                }

                if (textBox2.Text != "" && rbNome.Checked == true)
                {
                    DadosBD.Produto.Fabricante_BD a = new DadosBD.Produto.Fabricante_BD();
                    dataGridView1.DataSource = a.SelectbyNome(textBox2.Text);
                    dataGridView1.Refresh();
                }

                if (textBox2.Text != "" && rbMarca.Checked == true)
                {
                    DadosBD.Produto.Fabricante_BD a = new DadosBD.Produto.Fabricante_BD();
                    dataGridView1.DataSource = a.SelectbyMarca(textBox2.Text);
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
