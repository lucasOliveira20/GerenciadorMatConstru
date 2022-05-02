using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dados.Vendas;
using DadosBD.Venda;
using TCC.Gerenciamento_de_Vendas;
using Dados;
namespace TCC
{
    public partial class Vendas : Form
    {
        Venda_Dados vendaAlteradaGlobal = null;
        ExibirVendas formGlobal;
        Item_venda_BD metodos = new Item_venda_BD();
        List<Item_venda> produtos_vendidos = new List<Item_venda>();
        int id_venda;
        Principal principal = null;
        public Vendas(Principal principal = null,ExibirVendas form = null, Venda_Dados vendaAlterada = null)
        {
            InitializeComponent();
            this.principal = principal;
            DadosBD.Func_BD func = new DadosBD.Func_BD();
            List<Dados.Func_Dados> fd = new List<Func_Dados>();
            Dados.Func_Dados fu = new Func_Dados();
            fu.fun_id = 0;
            fd = func.Todos();
            fd.Insert(0, fu);
            cbFuncionario.DisplayMember = "Nome";
            cbFuncionario.ValueMember = "fun_id";
            cbFuncionario.DataSource = fd;
            this.principal = principal;
            DadosBD.Cliente_BD cliente = new DadosBD.Cliente_BD();
            List<Dados.Cliente_Dados> cd = new List<Cliente_Dados>();
            Dados.Cliente_Dados cu = new Cliente_Dados();
            cu.cli_id = 0;
            cd = cliente.Select();
            cd.Insert(0, cu);
            cbCliente.DisplayMember = "Nome";
            cbCliente.ValueMember = "cli_id";
            cbCliente.DataSource = cd;
         
            if (form != null)
            {
                formGlobal = form;
            }
            if (vendaAlterada != null)
            {
                id_venda = vendaAlterada.id_venda;
                vendaAlteradaGlobal = vendaAlterada;
                produtos_vendidos= metodos.GetTodos(id_venda);
                cbFuncionario.Text = vendaAlterada.fun_id.ToString();
                dataGridView1.DataSource = produtos_vendidos;
                metodos.Soma_Estoque(produtos_vendidos);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cancelar a venda?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnADDitem_Click(object sender, EventArgs e)
        {
            Item_venda_BD bd = new Item_venda_BD();
            int conversion;
            double conversion1;
            if (int.TryParse(txtQuantidade.Text, out conversion) == false || Double.TryParse(txtDescPç.Text, out conversion1) == false)
            {
                MessageBox.Show("Digite Apenas Numeros", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (vendaAlteradaGlobal != null)
                {
                    Item_venda obj = new Item_venda();
                    obj.Id_Item = vendaAlteradaGlobal.id_venda;
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
                    id_venda = bd.GetNextVenda();
                    Item_venda obj1 = new Item_venda();
                    obj1.Id_Item = id_venda;
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

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            Item_venda_BD bd = new Item_venda_BD();
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
                Item_venda_BD bd = new Item_venda_BD();
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

        private void btnVenda_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (MessageBox.Show("Deseja finalizar a Venda?  Você será direcionado à tela de Pagamento", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                double conversion;
                if (double.TryParse(txtDesc.Text, out conversion) == false)
                {
                    MessageBox.Show("Digite numeros no desconto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (vendaAlteradaGlobal != null)
                    {
                        vendaAlteradaGlobal.fun_id = metodos.GetFunc(cbFuncionario.Text);
                        vendaAlteradaGlobal.cli_id = metodos.getCliente(cbCliente.Text);
                        vendaAlteradaGlobal.data_venda = DateTime.Now;
                        id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                        vendaAlteradaGlobal.id_itemVenda = id;
                        vendaAlteradaGlobal.valor_venda = (Double.Parse(txtSub.Text) - (Double.Parse(txtSub.Text) * (Double.Parse(txtDesc.Text) / 100)));
                        FormPagamento form = new FormPagamento(vendaAlteradaGlobal, produtos_vendidos, this);
                        form.ShowDialog();
                        this.Dispose();
                        this.Close();
                    }
                    else
                    {
                        Venda_Dados novo = new Venda_Dados();
                        novo.fun_id = metodos.GetFunc(cbFuncionario.Text);
                        novo.cli_id = metodos.getCliente(cbCliente.Text);
                        novo.valor_venda = (Double.Parse(txtSub.Text) - (Double.Parse(txtSub.Text) * (Double.Parse(txtDesc.Text) / 100)));
                        id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                        novo.id_itemVenda = id;
                        FormPagamento form = new FormPagamento(novo, produtos_vendidos, this);

                        form.ShowDialog();
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
                        MessageBox.Show("Código de Barras NÂO CADASTRADO","Mensagem do Sistema"+ erro, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }     
                }
            }
        }

        private void cbProduto_TextChanged(object sender, EventArgs e)
        {
            /*if (txtCodigoBarra.Text != "")
            {
                Produto_Dados informacoes = new Produto_Dados();
                informacoes = metodos.InformaProduto(int.Parse(txtCodigoBarra.Text));
                cbProduto.Text = informacoes.descricao.ToString();
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
            }*/   
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

        private void Vendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            principal.popularLabels();
            principal.popularLabels1();
            principal.popularLabels2();
            principal.popularLabels3();
            principal.popularLabels4();
            principal.Show();
            principal.Focus();
        }
    }
}


