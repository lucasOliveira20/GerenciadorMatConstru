using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Estoque
{
    public partial class Gerenciamento_de_Estoque : Form
    {
        public Gerenciamento_de_Estoque()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            DadosBD.Estoque.Estoque_BD bd = new DadosBD.Estoque.Estoque_BD();
            List<Dados.Estoque_DadosGrid> todos = new List<Dados.Estoque_DadosGrid>();
            foreach (Dados.Estoque_Dados item in bd.Select())
            {
                Dados.Estoque_DadosGrid add = new Dados.Estoque_DadosGrid();
                add.id_estoque = item.id_estoque.ToString();
                add.id_fornecedor = bd.GetFornecedor(item.id_fornecedor);
                add.id_loc = bd.GetLocalizacao(item.id_loc);
                add.id_produto = bd.GetProduto(item.id_produto);
                add.quant_disponivel = item.quant_disponivel.ToString();
                add.dataADD = item.dataADD.ToString("dd/MM/yyyy");
                todos.Add(add);
            }
            dataGridView1.DataSource = todos;
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Localização";
            dataGridView1.Columns[2].HeaderText = "Fornecedor";
            dataGridView1.Columns[3].HeaderText = "Produto";
            dataGridView1.Columns[4].HeaderText = "Quantidade em Estoque";
            dataGridView1.Columns[5].HeaderText = "Data de Entrada";

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DadosBD.Estoque.Estoque_BD bd = new DadosBD.Estoque.Estoque_BD();
            Dados.Estoque_Dados eDel = new Dados.Estoque_Dados();
            eDel.id_estoque = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            bd.DEL(eDel);
            AtualizarGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cadastro_Estoque ce = new Cadastro_Estoque(this);
            ce.ShowDialog();
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DadosBD.Estoque.Estoque_BD estBanco = new DadosBD.Estoque.Estoque_BD();
            Dados.Estoque_Dados atualizar = estBanco.BviaCod(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            Cadastro_Estoque form = new Cadastro_Estoque(this, atualizar);
            form.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
