using Dados;
using Dados.Orçamento;
using DadosBD.Orçamento;
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
    public partial class Efetuar_Orcamento : Form
    {
        orcamento_Dados orcAlteradoGlobal = null;
        Exibir_Orcamento formGlobal;
        item_ORC_BD metodos = new item_ORC_BD();
        List<itemOrcamento_Dados> produtos_vendidos = new List<itemOrcamento_Dados>();
        int id_orc;
        Principal principal = null;
        public Efetuar_Orcamento(Principal principal = null, Exibir_Orcamento form = null, orcamento_Dados orcAlterado = null)
        {
            InitializeComponent();
            this.principal = principal;
            DadosBD.Func_BD func = new DadosBD.Func_BD();
            List<Dados.Func_Dados> fd = new List<Func_Dados>();
            Dados.Func_Dados fu = new Func_Dados();
            fu.fun_id = 0;
            //fu.Nome = "";
            fd = func.Todos();
            fd.Insert(0, fu);
            cbFuncionario.DisplayMember = "Nome";
            cbFuncionario.ValueMember = "fun_id";
            cbFuncionario.DataSource = fd;
            this.principal = principal;
            if (form != null)
            {
                formGlobal = form;
            }
            if (orcAlterado != null)
            {
                id_orc = orcAlterado.id_orcamento;
                orcAlteradoGlobal = orcAlterado;
                produtos_vendidos = metodos.GetTodos(id_orc);
                cbFuncionario.Text = orcAlterado.fun_id.ToString();
                dataGridView1.DataSource = produtos_vendidos;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cancelar a venda?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int conversion;
            double conversion1;
            item_ORC_BD bd = new item_ORC_BD();
            if (int.TryParse(txtQuantidade.Text, out conversion) == false || Double.TryParse(txtDescPç.Text, out conversion1) == false)
            {
                MessageBox.Show("Digite Apenas Numeros","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (orcAlteradoGlobal != null)
                {
                    itemOrcamento_Dados obj = new itemOrcamento_Dados();
                    obj.Id_Item = orcAlteradoGlobal.id_orcamento;
                    obj.prec_Unitario = Double.Parse(txtPrecoVenda.Text) - (Double.Parse(txtPrecoVenda.Text) * (Double.Parse(txtDescPç.Text) / 100));
                    obj.Id_Produto = bd.GetCodigo(txtproduto.Text);
                    obj.quant_vendida = int.Parse(txtQuantidade.Text);
                    if (metodos.isInEstoque(obj))
                    {
                        produtos_vendidos.Add(obj);
                        dataGridView1.DataSource = produtos_vendidos.ToList(); ;
                        dataGridView1.Refresh();
                        limparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Você não possui a quantidade necessária desse produto");
                    }
                }
                else
                {
                    id_orc = bd.GetNextORC();
                    itemOrcamento_Dados obj1 = new itemOrcamento_Dados();
                    obj1.Id_Item = id_orc;
                    obj1.prec_Unitario = Double.Parse(txtPrecoVenda.Text) - (Double.Parse(txtPrecoVenda.Text) * (Double.Parse(txtDescPç.Text) / 100));
                    obj1.Id_Produto = bd.GetCodigo(txtproduto.Text);
                    obj1.quant_vendida = int.Parse(txtQuantidade.Text);
                    if (metodos.isInEstoque(obj1))
                    {
                        produtos_vendidos.Add(obj1);
                        dataGridView1.DataSource = produtos_vendidos.ToList();
                        dataGridView1.Refresh();
                        limparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Você não possui a quantidade necessária desse produto");
                    }
                }
            }
        }

        public void limparCampos()
        {
            txtMarca.Text = "";
            txtPrecoVenda.Text = "";
            txtQuantidade.Text = "";
            txtFabricante.Text = "";
            txtPrecoVenda.Text = "";
            txtCodigoBarra.Text = "";
            txtUnidade.Text = "";
            txtPrecoVenda.Text = "";
            txtQuantidade.Text = "";
            txtDescPç.Text = "";
            txtproduto.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            item_ORC_BD bd = new item_ORC_BD();
            int indice = dataGridView1.SelectedRows.Count > 0 ? dataGridView1.SelectedRows[0].Index : -1;
            produtos_vendidos.RemoveAt(indice);
            dataGridView1.DataSource = produtos_vendidos.ToList();
            dataGridView1.Refresh();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja finalizar o Pedido? Você não poderá adicionar mais nenhum item!", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Double sub_total = 0;
                item_ORC_BD bd = new item_ORC_BD();
                txtMarca.Enabled = false;
                txtCodigoBarra.Enabled = false;
                txtUnidade.Enabled = false;
                txtPrecoVenda.Enabled = false;
                txtQuantidade.Enabled = false;
                txtDescPç.Enabled = false;
                btnAdicionar.Enabled = false;
                btnExcluir.Enabled = false;
                cbFuncionario.Enabled = false;
                txtproduto.Enabled = false;
                foreach (var item in produtos_vendidos)
                {
                    sub_total += item.prec_Unitario * item.quant_vendida;
                }
                txtSub.Text = sub_total.ToString();
            }
        }

        private void btnORC_Click(object sender, EventArgs e)
        {

            int id = 0;

            if (MessageBox.Show("Deseja finalizar o Orçamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                double conversion;
                if (double.TryParse(txtDesc.Text, out conversion) == false)
                {
                    MessageBox.Show("Digite numeros no desconto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (orcAlteradoGlobal != null)
                    {
                        orcAlteradoGlobal.fun_id = metodos.GetFunc(cbFuncionario.Text);
                        orcAlteradoGlobal.data_orcamento = DateTime.Now;
                        id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                        orcAlteradoGlobal.id_ItemOrcamento = id;
                        orcAlteradoGlobal.valor_orcamento = (Double.Parse(txtSub.Text) - (Double.Parse(txtSub.Text) * (Double.Parse(txtDesc.Text) / 100)));
                        metodos.Insert_item(produtos_vendidos);
                        DateTime data = DateTime.Now;
                        string data1 = data.ToString("yyyy/MM/dd , HH:mm:ss");
                        orcAlteradoGlobal.data_orcamento = DateTime.Parse(data1);
                        DadosBD.Orçamento.Orcamento_BD bd = new Orcamento_BD();
                        bd.Update_ORC(orcAlteradoGlobal);
                        this.Close();
                        this.Dispose();
                    }
                    else
                    {
                        orcamento_Dados novo = new orcamento_Dados();
                        novo.fun_id = metodos.GetFunc(cbFuncionario.Text);
                        novo.valor_orcamento = (Double.Parse(txtSub.Text) - (Double.Parse(txtSub.Text) * (Double.Parse(txtDesc.Text) / 100)));
                        id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                        novo.id_ItemOrcamento = id;
                        metodos.Insert_item(produtos_vendidos);
                        DateTime data = DateTime.Now;
                        string data1 = data.ToString("yyyy/MM/dd , HH:mm:ss");
                        novo.data_orcamento = DateTime.Parse(data1);
                        DadosBD.Orçamento.Orcamento_BD bd = new Orcamento_BD();
                        bd.Insert_ORC(novo);
                        this.Close();
                        this.Dispose();
                    }
                }
            }
        }

        private void txtCodigoBarra_KeyDown(object sender, KeyEventArgs e)
        {
            Produto_Dados informacoes = new Produto_Dados();

            if (txtCodigoBarra.Focused)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        if (txtCodigoBarra.Text != "")
                        {

                            informacoes = metodos.InformaProduto(Double.Parse(txtCodigoBarra.Text));
                            txtproduto.Text = informacoes.descricao;
                            txtPrecoVenda.Text = informacoes.preco_venda.ToString();
                            txtMarca.Text = informacoes.Marca.ToString();
                            txtUnidade.Text = informacoes.unidade_med.ToString();
                            Fabricante_Dados nome = new Fabricante_Dados();
                            nome = metodos.Nome_Fabricante(informacoes);
                            txtFabricante.Text = nome.nome_fabricante.ToString();
                        }

                        else
                        {
                            limparCampos();
                            MessageBox.Show("Código de barras não inserido", "Mensagem do Sustema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    catch (Exception erro)
                    {
                        limparCampos();
                        MessageBox.Show("Código de Barras NÂO CADASTRADO", "Mensagem do Sistema" + erro, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void Efetuar_Orcamento_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
