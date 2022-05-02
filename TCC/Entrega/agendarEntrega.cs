using Dados.Entrega;
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
    public partial class agendarEntrega : Form
    {
        Entrega_BD bd_entrega = new Entrega_BD();
        Entrega_Dados dados = new Entrega_Dados();
        DateTime data = new DateTime();
        public agendarEntrega(DateTime datavenda,int id_venda)
        {
            InitializeComponent();
            
            DadosBD.Veiculo.Veiculo_BD loc = new DadosBD.Veiculo.Veiculo_BD();
            List<Dados.Veiculos.VeiculosDados> ld = new List<Dados.Veiculos.VeiculosDados>();
            Dados.Veiculos.VeiculosDados l = new Dados.Veiculos.VeiculosDados();
            l.id_veiculo = 0;
            l.desc_veiculo = "";
            l.placa_veiculo = "";
            l.ano_veiculo = "";
            ld = loc.Select();
            ld.Insert(0, l);

            cbVeiculo.DisplayMember = "desc_veiculo";
            cbVeiculo.ValueMember = "id_veiculo";
            cbVeiculo.DataSource = ld;
            //cbID_loc.SelectionStart = 0;
            data = datavenda;
            dados.id_venda = bd_entrega.pesquisaIdVenda();
            dados.situacao_Entrega = "AGENDADA";
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                double a;
                if (double.TryParse(textBox1.Text, out a) == false)
                {
                    MessageBox.Show("Digite apenas numeros no prazo de entrega", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cbVeiculo.SelectedIndex.ToString() != null)
                    {
                        dados.Data_Entrega = data.AddDays(double.Parse(textBox1.Text));
                        dados.id_veiculo = int.Parse(cbVeiculo.SelectedIndex.ToString());
                        bd_entrega.Insert_Entrega(dados);
                        this.Close();
                        this.Dispose();
                    }
                    else {
                        MessageBox.Show("Selecione o veiculo para entrega", "erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch(FormatException b) {
                MessageBox.Show(" " + b,"erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }catch(Exception a){
                MessageBox.Show(" " + a, "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double ds;
                if (double.TryParse(textBox1.Text, out ds) == false)
                {
                    MessageBox.Show("Digite apenas numeros no prazo de entrega", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    monthCalendar1.SetDate(data.AddDays(Double.Parse(textBox1.Text)));
                }
            }
            catch (FormatException b)
            {
                MessageBox.Show(" " + b, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                MessageBox.Show(" " + a, "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
