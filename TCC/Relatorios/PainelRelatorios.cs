using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Relatorios
{
    public partial class PainelRelatorios : Form
    {
        public PainelRelatorios()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnEST_Click(object sender, EventArgs e)
        {
            Relatorio_de_Estoque est = new Relatorio_de_Estoque();
            est.Show();
        }

        private void btnVND_Click(object sender, EventArgs e)
        {
            Relatorio_de_Vendas vnd = new Relatorio_de_Vendas();
            vnd.Show();
        }

        private void btnFORN_REL_Click(object sender, EventArgs e)
        {
            Relatorio_de_Fornecedores rel = new Relatorio_de_Fornecedores();
            rel.Show();
        }

        private void btn_Rel_Entr_Click(object sender, EventArgs e)
        {
            Relatorio_de_Entrega rel = new Relatorio_de_Entrega();
            rel.Show();
        }
    }
}
