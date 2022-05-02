using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Gerenciamento_de_Orçamento
{
    public partial class Exibir_Orcamento : Form
    {
        public Exibir_Orcamento()
        {
            InitializeComponent();
            AtualizarGrid();

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            Efetuar_Orcamento ef = new Efetuar_Orcamento();
            ef.ShowDialog();
            AtualizarGrid();
        }

        private void btnVolt_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DadosBD.Orçamento.Orcamento_BD orcBD = new DadosBD.Orçamento.Orcamento_BD();
            Dados.Orçamento.orcamento_Dados deletar = new Dados.Orçamento.orcamento_Dados();
            deletar.id_orcamento = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            orcBD.Delete_ORC(deletar);
            this.AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            DadosBD.Orçamento.Orcamento_BD orc = new DadosBD.Orçamento.Orcamento_BD();
            dataGridView1.DataSource = orc.GetTodos();
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Funcionario";
            dataGridView1.Columns[2].HeaderText = "Item";
            dataGridView1.Columns[3].HeaderText = "Valor do Orçamento";
            dataGridView1.Columns[4].HeaderText = "Data do orçamento";
           
        }
    }
}
