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

namespace TCC.Entrega
{
    public partial class GerenciamentoDeEntregas : Form
    {
        Entrega_BD bd = new Entrega_BD();
        public GerenciamentoDeEntregas()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        public void AtualizarGrid()
        {
            Entrega_BD entBanco = new Entrega_BD();
            dataGridView1.DataSource = entBanco.GetTodos();
            dataGridView1.Columns[0].HeaderText = "Código da Entrega";
            dataGridView1.Columns[1].HeaderText = "Código da venda";
            dataGridView1.Columns[2].HeaderText = "Código do Veiculo";
            dataGridView1.Columns[3].HeaderText = "Data Prevista da Entrega";
            dataGridView1.Columns[4].HeaderText = "Situação da entrega";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Entrega_BD bd = new Entrega_BD();
            Dados.Entrega.Entrega_Dados eConfirm = new Dados.Entrega.Entrega_Dados();
            eConfirm.id_entrega = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            eConfirm.situacao_Entrega = "REALIZADA";
            bd.altSituacao_Entrega(eConfirm);
            AtualizarGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Entrega_BD bd = new Entrega_BD();
            Dados.Entrega.Entrega_Dados eConfirm = new Dados.Entrega.Entrega_Dados();
            eConfirm.id_entrega = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            eConfirm.situacao_Entrega = "CANCELADA";
            bd.altSituacao_Entrega(eConfirm);
            AtualizarGrid();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Entrega_BD bd = new Entrega_BD();
            Dados.Entrega.Entrega_Dados eDEL = new Dados.Entrega.Entrega_Dados();
            eDEL.id_entrega = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            bd.Delete_entrega(eDEL);
            AtualizarGrid();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            int id_cliente = bd.GetIDCliente(int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()));
            int id_veiculo = int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            Localizacao.RouteTracer mapinha = new Localizacao.RouteTracer(bd.getEndereco(id_cliente), bd.GetCliente(id_cliente), bd.GetVeiculo(id_veiculo), bd.GetPlaca(id_veiculo),dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            mapinha.ShowDialog();
            
        }
    }
}
