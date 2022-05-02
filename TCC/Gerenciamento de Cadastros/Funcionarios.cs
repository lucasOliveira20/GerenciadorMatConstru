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
    public partial class Funcionarios_Cad : Form
    {
        Cadastros antigo;

        public Funcionarios_Cad(Cadastros antigo)
        {

            this.antigo = antigo;
            
            InitializeComponent();
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            Func_BD funcBanco = new Func_BD();
            List<Dados.Func_DadosGrid> todos = new List<Dados.Func_DadosGrid>();
            foreach (Dados.Func_Dados item in funcBanco.Todos())
            {
                Dados.Func_DadosGrid add = new Dados.Func_DadosGrid();
                add.id_funcao = funcBanco.GetFuncao(item.id_funcao);
                add.id_banco =  funcBanco.GetBanco(item.id_banco);
                add.Nome = item.Nome;
                add.agencia = item.agencia;
                add.bairro = item.bairro;
                add.cat = item.cat;
                add.cep = item.cep;
                add.cidade = item.cidade;
                add.cnh = item.cnh;
                add.conta = item.conta;
                add.CPf = item.CPf;
                add.ctps = item.ctps;
                add.data_nasc = item.data_nasc.ToString("dd/MM/yyyy");
                add.email = item.email;
                add.endereco = item.endereco;
                add.fun_id = item.fun_id.ToString();
                add.razao_social = item.razao_social;
                add.RG = item.RG;
                add.telefone = item.telefone;
                add.t_pessoa = item.t_pessoa;
                add.uf = item.uf;
                todos.Add(add);
            }
            dgvGerenciar.DataSource = todos;
            dgvGerenciar.Columns[0].HeaderText = "Código";
            dgvGerenciar.Columns[1].HeaderText = "Função";
            dgvGerenciar.Columns[2].HeaderText = "Banco";
            dgvGerenciar.Columns[3].HeaderText = "Nome";
            dgvGerenciar.Columns[4].HeaderText = "Data de Nascimento";
            dgvGerenciar.Columns[5].HeaderText = "Telefone";
            dgvGerenciar.Columns[6].HeaderText = "E-Mail";
            dgvGerenciar.Columns[7].HeaderText = "Razão Social";
            dgvGerenciar.Columns[8].HeaderText = "Tipo de Pessoa";
            dgvGerenciar.Columns[9].HeaderText = "Registro Geral (RG)";
            dgvGerenciar.Columns[10].HeaderText = "Cadastro de Pessoa Fisica (CPF)";
            dgvGerenciar.Columns[11].HeaderText = "Rua";
            dgvGerenciar.Columns[12].HeaderText = "CEP";
            dgvGerenciar.Columns[13].HeaderText = "Bairro";
            dgvGerenciar.Columns[14].HeaderText = "Cidade";
            dgvGerenciar.Columns[15].HeaderText = "Unidade da Federação";
            dgvGerenciar.Columns[16].HeaderText = "Carteira Nacional de Habilitação (CNH)";
            dgvGerenciar.Columns[17].HeaderText = "Categoria da CNH";
            dgvGerenciar.Columns[18].HeaderText = "Carteira de Trabalho e Previdência Social";
            dgvGerenciar.Columns[19].HeaderText = "Agência";
            dgvGerenciar.Columns[20].HeaderText = "Conta";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.Close();

            antigo.alterar_Func(int.Parse(dgvGerenciar.SelectedRows[0].Cells[0].Value.ToString()),1);
        }

        private void Funcionarios_Cad_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvGerenciar != null)
            {
                Func_BD funcBanco = new Func_BD();
                Dados.Func_Dados funcDel = new Dados.Func_Dados();
                funcDel.fun_id = (int)dgvGerenciar.SelectedRows[0].Cells[0].Value;
                funcBanco.DEL(funcDel);
                AtualizarGrid();

            }
        }

        private void Funcionarios_Cad_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
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
                    DadosBD.Func_BD a = new DadosBD.Func_BD();
                    dgvGerenciar.DataSource = a.GetPorCodigo(int.Parse(textBox2.Text));
                    dgvGerenciar.Refresh();
                }

                if (textBox2.Text != "" && rbDesc.Checked == true)
                {
                    DadosBD.Func_BD a = new DadosBD.Func_BD();
                    dgvGerenciar.DataSource = a.BviaNome(textBox2.Text);
                    dgvGerenciar.Refresh();
                }
            }
                if (textBox2.Text == "")
                {
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
