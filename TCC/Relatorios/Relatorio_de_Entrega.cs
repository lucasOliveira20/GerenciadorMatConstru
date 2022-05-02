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
    public partial class Relatorio_de_Entrega : Form
    {
        String dataIMP = DateTime.Now.ToString();

        public int paginaAtual = 1;
        Font fonteTextoNormal = new Font("Century Gothic", 10);
        int tamanhoLinhaNormal = 27;
        Font fonteTitulo = new Font("Century Gothic", 25);
        Font FonteRodape = new Font("Century Gothic", 8);
        Brush CorPreto = new SolidBrush(Color.Black);
        Brush CorVerd = new SolidBrush(Color.LightGreen);
        Brush CorCinza = new SolidBrush(Color.Silver);

        List<Dados.Entrega.Entrega_Dados> est = null;
        private int ypos = 1;
        private PrintPreviewDialog previewDlg = null;

        public Relatorio_de_Entrega()
        {
            InitializeComponent();
        }

        private void Relatorio_de_Entrega_Load(object sender, EventArgs e)
        {
            DadosBD.Entrega_BD bd = new DadosBD.Entrega_BD(); ;
            est = bd.GetTodos();

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
            g.DrawString(" Relatório de Entregas", fonteTitulo, CorPreto, 390, 60);



            ypos = 150;
            FazerTabela(est, g, ev);

        }
        private void FazerTabela(List<Dados.Entrega.Entrega_Dados> vend, Graphics g, PrintPageEventArgs ev)
        {
            //Fazer Moldura
            g.DrawLine(new Pen(CorPreto), new Point(1, 140), new Point(1100, 140));
            //g.DrawLine(new Pen(CorPreto), new Point(1, 1100), new Point(1000, 1100));

            //terminar Moldura
            g.FillRectangle(CorVerd, new Rectangle(0, 140, 1100, tamanhoLinhaNormal + 5));

            g.DrawString("ID da Entrega", fonteTextoNormal, CorPreto, 10, ypos);
            g.DrawString("ID da Venda", fonteTextoNormal, CorPreto, 140, ypos);
            g.DrawString("ID do Veículo", fonteTextoNormal, CorPreto, 290, ypos);
            g.DrawString("Data de Entrega", fonteTextoNormal, CorPreto, 460, ypos);
            g.DrawString("Situação", fonteTextoNormal, CorPreto, 695, ypos);


            ypos += tamanhoLinhaNormal;
            int count = 0;
            for (int i = 0; i < vend.Count; )
            {
                if (count % 2 == 0)
                {
                    g.FillRectangle(CorCinza, new Rectangle(1, ypos - 5, 1200, tamanhoLinhaNormal));
                }
                count++;

                string a1 = vend[i].id_entrega.ToString();
                string a2 = vend[i].id_venda.ToString();
                string a3 = vend[i].id_veiculo.ToString();
                string a4 = vend[i].Data_Entrega.ToString();
                string a5 = vend[i].situacao_Entrega.ToString();


                g.DrawLine(new Pen(CorPreto), new Point(1, ypos - 5), new Point(1200, ypos - 5));
                g.DrawString(a1, fonteTextoNormal, CorPreto, 50, ypos);
                g.DrawString(a2, fonteTextoNormal, CorPreto, 180, ypos);
                g.DrawString(a3, fonteTextoNormal, CorPreto, 320, ypos);
                g.DrawString(a4, fonteTextoNormal, CorPreto, 455, ypos);
                g.DrawString(a5, fonteTextoNormal, CorPreto, 690, ypos);


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