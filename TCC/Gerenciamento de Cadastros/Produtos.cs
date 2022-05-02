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
    public partial class Produtos_Cad : Form
    {
        Cadastros antigo;

        public Produtos_Cad(Cadastros antigo)
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
            Produto_BD proBanco = new Produto_BD();
            List<Dados.Produto_DadosGrid> todos = new List<Dados.Produto_DadosGrid>();
            foreach (Dados.Produto_Dados item in proBanco.Select())
            {
                Dados.Produto_DadosGrid add = new Dados.Produto_DadosGrid();
                add.cod_barra = item.cod_barra.ToString();
                add.descricao = item.descricao;
                add.id_fabricante = proBanco.GetFabricante(item.id_fabricante);
                add.id_produto = item.id_produto.ToString();
                add.id_setor = proBanco.GetSetor(item.id_setor);
                add.Marca = item.Marca;
                add.margem_lucro = item.margem_lucro.ToString();
                add.preco_compra = item.preco_compra.ToString();
                add.preco_venda = item.preco_venda.ToString();
                add.unidade_med = item.unidade_med;
                todos.Add(add);
            }
            dataGridView1.DataSource = todos;
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Setor";
            dataGridView1.Columns[2].HeaderText = "Fabricante";
            dataGridView1.Columns[3].HeaderText = "Código de Barras";
            dataGridView1.Columns[4].HeaderText = "Descrição";
            dataGridView1.Columns[5].HeaderText = "Marca";
            dataGridView1.Columns[6].HeaderText = "Unidade de Medida";
            dataGridView1.Columns[7].HeaderText = "Preço de Compra (R$)";
            dataGridView1.Columns[8].HeaderText = "Preço de Venda (R$)";
            dataGridView1.Columns[9].HeaderText = "Margem de Lucro (%)";
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                Produto_BD pBanco = new Produto_BD();
                Dados.Produto_Dados pDel = new Dados.Produto_Dados();
                pDel.id_produto = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                pBanco.DEL(pDel);
                AtualizarGrid();

            }
        }

        private void btnAlterarProd_Click(object sender, EventArgs e)
        {
            this.Close();
            antigo.alterar_Prod(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 6);
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
                    DadosBD.Produto_BD a = new DadosBD.Produto_BD();
                    dataGridView1.DataSource = a.SelectbyCod(Double.Parse(textBox2.Text));
                    dataGridView1.Refresh();
                }

                if (textBox2.Text != "" && rbDesc.Checked == true)
                {
                    DadosBD.Produto_BD a = new DadosBD.Produto_BD();
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
