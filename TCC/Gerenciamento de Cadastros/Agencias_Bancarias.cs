using DadosBD.AgenciaBancaria;
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
    public partial class Agencias_Bancarias : Form
    {
        Cadastros antigo;

        public Agencias_Bancarias(Cadastros antigo)
        {
            this.antigo = antigo;

            InitializeComponent();
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            AgBanq aBanco = new AgBanq();
            dataGridView1.DataSource = aBanco.Select();
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Agência";
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            AgBanq pBanco = new AgBanq();
            Dados.Agencia_Bancaria.BancoDados pDel = new Dados.Agencia_Bancaria.BancoDados();
            pDel.id_banco = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            pBanco.DEL(pDel);
            AtualizarGrid();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAlterarAb_Click(object sender, EventArgs e)
        {
            this.Close();
            antigo.alterar_AB(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),12);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (rbCod.Checked == false && rbDesc.Checked == false && rbTodos.Checked == false)
            {
                MessageBox.Show("Selecione o modo des pesquisa","Atenção",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBox2.Text != "" && rbCod.Checked == true)
                {
                    DadosBD.AgenciaBancaria.AgBanq a = new DadosBD.AgenciaBancaria.AgBanq();
                    dataGridView1.DataSource = a.SelectbyCodigo(int.Parse(textBox2.Text));
                    dataGridView1.Refresh();
                }

                if (textBox2.Text != "" && rbDesc.Checked == true)
                {
                    DadosBD.AgenciaBancaria.AgBanq a = new DadosBD.AgenciaBancaria.AgBanq();
                    dataGridView1.DataSource = a.SelectbyNome(textBox2.Text);
                    dataGridView1.Refresh();
                }
                if (textBox2.Text == "")
                    AtualizarGrid();
                
            }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
            textBox2.Text = "";
        }
    }
}
