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
using DadosBD;
using DadosBD.Venda;
using TCC.Gerenciamento_de_Vendas;
using Dados;
using TCC.Localizacao;
using Dados.Entrega;
namespace TCC.Gerenciamento_de_Vendas
{
    public partial class FormPagamento : Form
    {
        Venda_Dados vendaGlobal;
        Vendas_BD bd = new Vendas_BD();
        List<Item_venda> produtos = new List<Item_venda>();
        Item_venda_BD that = new Item_venda_BD();
        Vendas vendas = null;
        public FormPagamento(Venda_Dados vendaRealizada, List<Item_venda> produtos_vendidos,Vendas vendas)
        {
            InitializeComponent();
            mtbDataCad.Text = DateTime.Now.ToString();
            vendaGlobal = vendaRealizada;
            mtbTotal.Text = vendaGlobal.valor_venda.ToString();
            produtos = produtos_vendidos;
            this.vendas = vendas;
            DadosBD.FormaDePagamento.FormaDePagamento_BD forma = new DadosBD.FormaDePagamento.FormaDePagamento_BD();
            List<Dados.FormaDePagamento.FormaDePagamento_Dados> pd = new List<Dados.FormaDePagamento.FormaDePagamento_Dados>();
            Dados.FormaDePagamento.FormaDePagamento_Dados p = new Dados.FormaDePagamento.FormaDePagamento_Dados();
            p.id_FormaPag = 0;
            p.desc_formade = "";
            pd = forma.Select();
            pd.Insert(0, p);

            cbForma.DisplayMember = "desc_formade";
            cbForma.ValueMember = "id_produto";
            cbForma.DataSource = pd;
            //cbID_Prod.SelectionStart = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double comparasion;
            if (Double.TryParse(mtbRecebido.Text, out comparasion) == false)
            {
                MessageBox.Show("Apenas numeros no valor recebido","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                that.Insert_item(produtos);
                that.Update_estoque(produtos);
                vendaGlobal.valor_recebido = Double.Parse(mtbRecebido.Text);
                vendaGlobal.troco = Double.Parse(mtbTroco.Text);
                vendaGlobal.id_formaPag = bd.GetCodigo(cbForma.Text);

                DateTime data = DateTime.Parse(mtbDataCad.Text);
                string data1 = data.ToString("yyyy/MM/dd , HH:mm:ss");
                vendaGlobal.data_venda = DateTime.Parse(data1);


                if (checkBox1.Checked == true)
                {
                    vendaGlobal.entrega = "S";
                }
                else
                {
                    vendaGlobal.entrega = "N";
                }

                bd.Insert_Venda(vendaGlobal);

            }

            
            bd.Insert_Venda(vendaGlobal);
            if (checkBox1.Checked == true)
            {
                // RouteTracer rotas = new RouteTracer(bd.getEndereco(vendaGlobal.cli_id));
                //insert entrega

                Entrega.agendarEntrega finalizar = new Entrega.agendarEntrega(vendaGlobal.data_venda,vendaGlobal.id_venda);
                finalizar.ShowDialog();
                
            }
            
            this.Close();
            this.Dispose();
        }    
        private void mtbRecebido_TextChanged(object sender, EventArgs e)
        {
            double comparasion;
            if (mtbRecebido.Text != "")
            {
                if (Double.TryParse(mtbRecebido.Text, out comparasion) == false)
                {
                    MessageBox.Show("Apenas numeros no valor recebido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Double.Parse(mtbRecebido.Text) >= double.Parse(mtbTotal.Text))
                    {
                        mtbTroco.Text = (Double.Parse(mtbRecebido.Text) - vendaGlobal.valor_venda).ToString();
                    }

                    else
                    {
                        mtbTroco.Text = "";
                    }
                }
            }

            //else
            //{
               // MessageBox.Show("Insira um valorno campo: valor Recebido","Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               // mtbTroco.Text = "";
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FormPagamento_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
