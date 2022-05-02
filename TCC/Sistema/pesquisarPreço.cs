using Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Sistema
{
    public partial class pesquisarPreço : Form
    {
        public pesquisarPreço()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtCodBar_KeyDown(object sender, KeyEventArgs e)
        {
             Produto_Dados informacoes = new Produto_Dados();
            

            if (txtCodBar.Focused)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        if (txtCodBar.Text != "")
                        {

                            DadosBD.Produto_BD proBanco = new DadosBD.Produto_BD();
                       
                                List<Dados.Produto_DadosGrid> todos = new List<Dados.Produto_DadosGrid>();
                                foreach (Dados.Produto_Dados item in proBanco.SelectbyCod(Double.Parse(txtCodBar.Text)))
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

                            lblPreco.Text = (proBanco.SelectPrecobyCod(Double.Parse(txtCodBar.Text)).ToString());
                            //dataGridView1.Columns[0].HeaderText = "Código";
                            //dataGridView1.Columns[1].HeaderText = "Funcionario";
                            //dataGridView1.Columns[2].HeaderText = "Item";
                            //dataGridView1.Columns[3].HeaderText = "Valor do Orçamento";
                            //dataGridView1.Columns[4].HeaderText = "Data do orçamento";

                        }

                        else
                        {
                            MessageBox.Show("Código de barras não inserido", "Mensagem do Sustema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    catch (Exception erro)
                    {
                        MessageBox.Show("Código de Barras NÂO CADASTRADO", "Mensagem do Sistema" + erro, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void pesquisarPreço_Load(object sender, EventArgs e)
        {
            txtCodBar.Focus();
        }
    }
}
