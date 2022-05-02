using DadosBD.Veiculo;
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
    public partial class Veiculos : Form
    {
        Cadastros antigo;

        public Veiculos(Cadastros antigo)
        {
            this.antigo = antigo;

            InitializeComponent();
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            Veiculo_BD vBanco = new Veiculo_BD();
            dataGridView1.DataSource = vBanco.Select();
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Descrição";
            dataGridView1.Columns[2].HeaderText = "Ano";
            dataGridView1.Columns[3].HeaderText = "Placa";
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                Veiculo_BD pBanco = new Veiculo_BD();
                Dados.Veiculos.VeiculosDados pDel = new Dados.Veiculos.VeiculosDados();
                pDel.id_veiculo = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                pBanco.DEL(pDel);
                AtualizarGrid();

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAlterarVei_Click(object sender, EventArgs e)
        {
            this.Close();
            antigo.alterar_Veiculo(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),11);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (rbCod.Checked == false && rbDesc.Checked == false && rbA.Checked == false && rbP.Checked == false && rbTodos.Checked == false)
            {
                MessageBox.Show("Selecione o modo des pesquisa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBox2.Text != "" && rbCod.Checked == true)
                {
                    DadosBD.Veiculo.Veiculo_BD a = new DadosBD.Veiculo.Veiculo_BD();
                    dataGridView1.DataSource = a.SelectbyCOD(int.Parse(textBox2.Text));
                    dataGridView1.Refresh();
                }

                if (textBox2.Text != "" && rbA.Checked == true)
                {
                    DadosBD.Veiculo.Veiculo_BD a = new DadosBD.Veiculo.Veiculo_BD();
                    dataGridView1.DataSource = a.SelectbyAno(textBox2.Text);
                    dataGridView1.Refresh();
                }

                if (textBox2.Text != "" && rbDesc.Checked == true)
                {
                    DadosBD.Veiculo.Veiculo_BD a = new DadosBD.Veiculo.Veiculo_BD();
                    dataGridView1.DataSource = a.SelectbyDesc(textBox2.Text);
                    dataGridView1.Refresh();
                }

                if (textBox2.Text != "" && rbP.Checked == true)
                {
                    DadosBD.Veiculo.Veiculo_BD a = new DadosBD.Veiculo.Veiculo_BD();
                    dataGridView1.DataSource = a.SelectbyPlaca(textBox2.Text);
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
