using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DadosBD;
using Dados;
namespace TCC.Gerenciamento_de_Vendas
{
    public partial class ExibirVendas : Form
    {
        Principal principal = null;
        public ExibirVendas(Principal principal)
        {
            InitializeComponent();
            AtualizarGrid();
            this.principal = principal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                Vendas_BD vendaBanco = new Vendas_BD();
                Venda_Dados deletar = new Venda_Dados();
                deletar.id_venda = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                vendaBanco.Delete_Venda(deletar);
                this.AtualizarGrid();
            }
        }

        public void AtualizarGrid()
        {
            Vendas_BD vendaBanco = new Vendas_BD();
            List<Venda_DadosGrid> todos = new List<Venda_DadosGrid>();
            foreach (Venda_Dados item in vendaBanco.GetTodos())
            {
                Venda_DadosGrid add = new Venda_DadosGrid();
                add.cli_id = vendaBanco.GetCliente(item.cli_id);
                add.data_venda = item.data_venda.ToString("dd/MM/yyyy");
                add.entrega = item.entrega;
                add.fun_id = vendaBanco.GetFuncionario(item.fun_id);
                add.id_formaPag = vendaBanco.GetFormaPag(item.id_formaPag);
                add.id_itemVenda = item.id_itemVenda.ToString();
                add.id_venda = item.id_venda.ToString();
                add.troco = item.troco.ToString();
                add.valor_recebido = item.valor_recebido.ToString();
                add.valor_venda = item.valor_venda.ToString();
                todos.Add(add);
            }
            dataGridView1.DataSource = vendaBanco.GetTodos();

            dataGridView1.Columns[0].HeaderText = "Código da Venda";
            dataGridView1.Columns[1].HeaderText = "Vendedor";
            dataGridView1.Columns[2].HeaderText = "Cliente";
            dataGridView1.Columns[3].HeaderText = "Código dos Itens Vendidos";
            dataGridView1.Columns[4].HeaderText = "Forma de Pagamento";
            dataGridView1.Columns[5].HeaderText = "Total (R$)";
            dataGridView1.Columns[6].HeaderText = "Data da venda";
            dataGridView1.Columns[7].HeaderText = "Valor Recebido (R$)";    
            dataGridView1.Columns[8].HeaderText = "Troco (R$)";    
            dataGridView1.Columns[9].HeaderText = "Entrega";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vendas dialog = new Vendas();
            dialog.Show();
            AtualizarGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vendas_BD vendaBanco = new Vendas_BD();
            Venda_Dados atualizar = new Venda_Dados();
            atualizar.id_venda = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            Vendas form = new Vendas(principal,this, atualizar);
            form.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
