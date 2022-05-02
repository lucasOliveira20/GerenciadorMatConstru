using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.Properties;

namespace TCC.Relatorios
{
    public partial class Relatorio_de_Vendas : Form
    {
        String dataIMP = DateTime.Now.ToString();

        public int paginaAtual = 1;
        Font FonteRodape = new Font("Century Gothic", 8);
        Font fonteTextoNormal = new Font("Century Gothic", 10);
        int tamanhoLinhaNormal = 27;
        Font fonteTitulo = new Font("Century Gothic", 25);
        Brush CorPreto = new SolidBrush(Color.Black);
        Brush CorVerd = new SolidBrush(Color.LightGreen);
        Brush CorCinza = new SolidBrush(Color.Silver);

        List<Dados.Venda_Dados> vnd = null;
        private int ypos = 1;
        private PrintPreviewDialog previewDlg = null;

        public Relatorio_de_Vendas()
        {
            InitializeComponent();
        }

        private void Relatorio_de_Vendas_Load(object sender, EventArgs e)
        {
            DadosBD.Vendas_BD bd = new DadosBD.Vendas_BD(); ;
            vnd = bd.GetTodos();

            //Create a PrintPreviewDialog object
            previewDlg = new PrintPreviewDialog();
            //Create a PrintDocument object
            PrintDocument pd = new PrintDocument();
            //Add print-page event handler
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            //Set Document property of PrintPreviewDialog
            previewDlg.Document = pd;
            //Display dialog
            previewDlg.WindowState = FormWindowState.Maximized;
            previewDlg.PrintPreviewControl.Zoom = 1;
            previewDlg.Show();
        }

        public void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            ypos = 1;
            float pageheight = ev.MarginBounds.Height;
            //Create a Graphics object
            Graphics g = ev.Graphics;

            //Fazer Cabeçalho
            g.DrawImage(Resources.FC, 10, 10, 350, 140);
            g.DrawString(" Relatório de Vendas", fonteTitulo, CorPreto, 390, 60);
            ypos = 150;
            FazerTabela(vnd, g, ev);

        }
        private void FazerTabela(List<Dados.Venda_Dados> vend, Graphics g, PrintPageEventArgs ev)
        {
            //Fazer Moldura
            g.DrawLine(new Pen(CorPreto), new Point(1, 140), new Point(1000, 140));
            //g.DrawLine(new Pen(CorPreto), new Point(1, 1118), new Point(1000, 1118));

            //terminar Moldura
            g.FillRectangle(CorVerd, new Rectangle(0, 140, 1100, tamanhoLinhaNormal + 5));

            g.DrawString("ID. Venda", fonteTextoNormal, CorPreto, 15, ypos);
            g.DrawString("ID. Item", fonteTextoNormal, CorPreto, 100, ypos);
            g.DrawString("ID. Pag", fonteTextoNormal, CorPreto, 170, ypos);
            g.DrawString("ID. Func", fonteTextoNormal, CorPreto, 230, ypos);
            g.DrawString("Data de Venda", fonteTextoNormal, CorPreto, 310, ypos);
            g.DrawString("Total", fonteTextoNormal, CorPreto, 480, ypos);
            g.DrawString("V. Recebido", fonteTextoNormal, CorPreto, 560, ypos);
            g.DrawString("Troco", fonteTextoNormal, CorPreto, 670, ypos);
            g.DrawString("Entrega", fonteTextoNormal, CorPreto, 760, ypos);

            ypos += tamanhoLinhaNormal;
            int count = 0;
            for (int i = 0; i < vend.Count; )
            {
                if (count % 2 == 0)
                {
                    g.FillRectangle(CorCinza, new Rectangle(1, ypos - 5, 1100, tamanhoLinhaNormal));
                }
                count++;

                string a1 = vend[i].id_venda.ToString();
                string a2 = vend[i].id_itemVenda.ToString();
                string a3 = vend[i].id_formaPag.ToString();
                string a4 = vend[i].fun_id.ToString();
                string a5 = vend[i].data_venda.ToString();
                string a6 = "R$ " + vend[i].valor_venda.ToString();
                string a7 = "R$ " + vend[i].valor_recebido.ToString();
                string a8 = "R$ " + vend[i].troco.ToString();
                string a9 =  vend[i].entrega.ToString();

                g.DrawLine(new Pen(CorPreto), new Point(1, ypos - 5), new Point(1100, ypos - 5));
                g.DrawString(a1, fonteTextoNormal, CorPreto, 30, ypos);
                g.DrawString(a2, fonteTextoNormal, CorPreto, 115, ypos);
                g.DrawString(a3, fonteTextoNormal, CorPreto, 180, ypos);
                g.DrawString(a4, fonteTextoNormal, CorPreto, 250, ypos);
                g.DrawString(a5, fonteTextoNormal, CorPreto, 310, ypos);
                g.DrawString(a6, fonteTextoNormal, CorPreto, 480, ypos);
                g.DrawString(a7, fonteTextoNormal, CorPreto, 567, ypos);
                g.DrawString(a8, fonteTextoNormal, CorPreto, 675, ypos);
                g.DrawString(a9, fonteTextoNormal, CorPreto, 775, ypos);


                vend.Remove(vend[i]);

                ypos += tamanhoLinhaNormal;
                if (ypos > 1100)
                {
                    ev.HasMorePages = true;
                    break;
                }
            }
            this.Hide();

            g.DrawLine(new Pen(CorPreto), new Point(1, 1118), new Point(1000, 1118));

            g.DrawString("Data de impressão : " + dataIMP, FonteRodape, Brushes.Black, 10, 1135);
            g.DrawString("Página  " + paginaAtual, FonteRodape, Brushes.Black, 750, 1135);

            paginaAtual += 1;
        }

    }
}
