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
    public partial class Cadastro_Estoque : Form
    {
        Dados.Estoque_Dados estoqueAlteradoGlobal = null;
        Gerenciamento_de_Estoque formGlobal;

        public Cadastro_Estoque(Gerenciamento_de_Estoque form, Dados.Estoque_Dados formAlterado = null)
        {
            InitializeComponent();

            DadosBD.Produto_BD prod = new DadosBD.Produto_BD();
            List<Dados.Produto_Dados> pd = new List<Dados.Produto_Dados>();
            Dados.Produto_Dados p = new Dados.Produto_Dados();
            p.id_produto = 0;
            p.descricao = "";
            pd = prod.Select();
            pd.Insert(0, p);

            cbID_Prod.DisplayMember = "id_produto";
            cbID_Prod.ValueMember = "id_produto";
            cbID_Prod.DataSource = pd;
            //cbID_Prod.SelectionStart = 0;

            DadosBD.Localizacao.Localizacao_BD loc = new DadosBD.Localizacao.Localizacao_BD();
            List<Dados.Localização.Localizacao_Dados> ld = new List<Dados.Localização.Localizacao_Dados>();
            Dados.Localização.Localizacao_Dados l = new Dados.Localização.Localizacao_Dados();
            l.id_loc = 0;
            l.corredor = "";
            l.pratileira = "";
            l.gaveta = "";
            ld = loc.Select();
            ld.Insert(0, l);

            cbID_loc.DisplayMember = "id_loc";
            cbID_loc.ValueMember = "id_loc";
            cbID_loc.DataSource = ld;
            //cbID_loc.SelectionStart = 0;

            DadosBD.Fornecedor.Fornecedor_BD forn = new DadosBD.Fornecedor.Fornecedor_BD();
            List<Dados.Fornecedor.Fornecedor_Dados> fd = new List<Dados.Fornecedor.Fornecedor_Dados>();
            Dados.Fornecedor.Fornecedor_Dados f = new Dados.Fornecedor.Fornecedor_Dados();
            f.for_id = 0;
            f.Nome = "";
            fd = forn.Select();
            fd.Insert(0, f);

            cbID_forn.DisplayMember = "for_id";
            cbID_forn.ValueMember = "for_id";
            cbID_forn.DataSource = fd;
            //cbID_forn.SelectionStart = 0;

            formGlobal = form;
            mtbDataCad.Text = DateTime.Now.ToString();

            if (formAlterado != null)
            {
                estoqueAlteradoGlobal = formAlterado;
                cbID_Prod.Text = formAlterado.id_produto.ToString();
                cbID_loc.Text = formAlterado.id_loc.ToString();
                cbID_forn.Text = formAlterado.id_fornecedor.ToString();
                mtbDataCad.Text = formAlterado.dataADD.ToString();
                txtQuantProd.Text = formAlterado.quant_disponivel.ToString();

            }
        }

        public void limparCapos()
        {
            cbID_forn.Text = string.Empty;
            cbID_loc.Text = string.Empty;
            cbID_Prod.Text = string.Empty;
            txtQuantProd.Text = string.Empty;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cancelar a operação?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DadosBD.Estoque.Estoque_BD bd = new DadosBD.Estoque.Estoque_BD();
            int conversion;
            if (txtQuantProd.Text == null || int.TryParse(txtQuantProd.Text, out conversion) == false)
            {
                MessageBox.Show("Quantidade de produtos não pode se nula em nem letras o caracteres");
            }
            else
            {
                if (estoqueAlteradoGlobal != null)
                {
                    try
                    {
                        //estoqueAlteradoGlobal.id_fornecedor = bd.GetCodigofornecedor(cbID_forn.Text);
                        estoqueAlteradoGlobal.id_fornecedor = int.Parse(cbID_forn.Text);
                        estoqueAlteradoGlobal.id_loc = int.Parse(cbID_loc.Text);
                        //estoqueAlteradoGlobal.id_produto = bd.GetCodigo(cbID_Prod.Text);
                        estoqueAlteradoGlobal.id_produto = int.Parse(cbID_Prod.Text);
                        estoqueAlteradoGlobal.quant_disponivel = int.Parse(txtQuantProd.Text);
                        estoqueAlteradoGlobal.dataADD = DateTime.Parse(DateTime.Parse(mtbDataCad.Text).ToString("yyyy/MM/dd , HH:mm:ss"));

                        bd.ALT(estoqueAlteradoGlobal);
                        limparCapos();
                        MessageBox.Show("Informações de Estoque alteradas com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception erro)
                    {
                        MessageBox.Show("ERRO ->" + erro.Message);
                    }
                }

                else
                {
                    try
                    {
                        Dados.Estoque_Dados novo = new Dados.Estoque_Dados();
                        //novo.id_fornecedor = bd.GetCodigofornecedor(cbID_forn.Text);
                        novo.id_fornecedor = int.Parse(cbID_forn.Text);
                        novo.id_loc = int.Parse(cbID_loc.Text);
                        //novo.id_produto = bd.GetCodigo(cbID_Prod.Text);
                        novo.id_produto = int.Parse(cbID_Prod.Text);
                        novo.quant_disponivel = int.Parse(txtQuantProd.Text);
                        novo.dataADD = DateTime.Parse(DateTime.Parse(mtbDataCad.Text).ToString("yyyy/MM/dd , HH:mm:ss"));
                        bd.ADD(novo);
                        limparCapos();
                        MessageBox.Show("Estoque computado com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception erro)
                    {
                        MessageBox.Show("ERRO ->" + erro.Message);
                    }
                }

            }

            formGlobal.AtualizarGrid();
            this.Close();
        }
    }
}
