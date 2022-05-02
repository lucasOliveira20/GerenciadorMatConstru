using DadosBD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using TCC.Gerenciamento_de_Vendas;
using TCC.Sistema;
using Microsoft.VisualBasic.Devices;


namespace TCC
{
    public partial class Principal : Form
    {

        /*TCC.Login login = null;
        private Graphics GR;
        const double PI = 3.14159265;
        const double ConvRad = PI / 180;
        private float CentroX;
        private float CentroY;
        private Computer MeuComputador = new Computer();
        private float sx, sy, sxf, syf;
        private float mx, my, mxf, myf;
        private float hx, hy, hxf, hyf;
        private float six, siy, sixf, siyf;*/
        TCC.Login login = null;
        private Graphics GR;
        private float cx;
        private float cy;
        private Computer MeuComputador = new Computer();
        static Double pi = 3.14159265;
        Double rad = pi / 180;
        int thix = 0, thiy = 0, tmix = 0, tmiy = 0, tsix = 0, tsiy = 0, tsiix = 0, tsiiy = 0;
        int thfx = 0, thfy = 0, tmfx = 0, tmfy = 0, tsfx = 0, tsfy = 0, tsifx = 0, tsify = 0;
        int othix = 0, othiy = 0, otmix = 0, otmiy = 0, otsix = 0, otsiy = 0, otsiix = 0, otsiiy = 0;
        int othfx = 0, othfy = 0, otmfx = 0, otmfy = 0, otsfx = 0, otsfy = 0, otsifx = 0, otisfy = 0;
        double oam = 0, oans = 0;

       

        public Principal(TCC.Login login)
        {
            InitializeComponent();
            popularLabels();
            popularLabels1();
            popularLabels2();
            popularLabels3();
            popularLabels4();
            
            this.login = login;
            
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            Vendas v = new Vendas(this);
            v.Show();
            popularLabels();
            popularLabels1();
            popularLabels2();
            popularLabels3();
            popularLabels4();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja finalizar o Sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                this.Dispose(); 
                Application.Exit(); 
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Deslogar do Sistema?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login l = new Login();
                this.Hide();
                this.Dispose();
                l.Show();
            }
            
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            Cadastros c = new Cadastros("");
            c.ShowDialog();
            popularLabels();
            popularLabels1();
            popularLabels2();
            popularLabels3();
            popularLabels4();
           
        }

        private void btnGERest_Click(object sender, EventArgs e)
        {
            Estoque.Gerenciamento_de_Estoque est = new Estoque.Gerenciamento_de_Estoque();
            est.ShowDialog();
            popularLabels();
            popularLabels1();
            popularLabels2();
            popularLabels3();
            popularLabels4();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Relatorio_de_Estoque r = new Relatorios.Relatorio_de_Estoque();
            r.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros c = new Cadastros("user");
            c.ShowDialog();
        }

        private void gerenciarVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirVendas form = new ExibirVendas(this);
            form.ShowDialog();
        }

        public void popularLabels()
        {

            Conexao.AC();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dtReader;

            String sql = "select count(Nome) as quantidade from cliente";

            cmd.Connection = Conexao.conexao;
            cmd.CommandText = sql;
            dtReader = cmd.ExecuteReader();

            while (dtReader.Read())
            {
                lblNumClientes.Text = dtReader[0].ToString();
            }

            Conexao.FC();

        }

        public void popularLabels1()
        {

            Conexao.AC();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dtReader;

            String sql = "select sum(quant_disponivel) as quantidade from estoque;";

            cmd.Connection = Conexao.conexao;
            cmd.CommandText = sql;
            dtReader = cmd.ExecuteReader();

            while (dtReader.Read())
            {
                lblQuantEst.Text = dtReader[0].ToString();
            }

            Conexao.FC();

        }

        public void popularLabels2()
        {

            Conexao.AC();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dtReader;

            String sql = "select count(Nome) as quantidade from fornecedor;";

            cmd.Connection = Conexao.conexao;
            cmd.CommandText = sql;
            dtReader = cmd.ExecuteReader();

            while (dtReader.Read())
            {
                lblNumForn.Text = dtReader[0].ToString();
            }

            Conexao.FC();

        }

        public void popularLabels3()
        {

            Conexao.AC();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dtReader;

            String sql = "select count(id_veiculo) as quantidade from veiculo";

            cmd.Connection = Conexao.conexao;
            cmd.CommandText = sql;
            dtReader = cmd.ExecuteReader();

            while (dtReader.Read())
            {
                lblNumVeic.Text = dtReader[0].ToString();
            }

            Conexao.FC();

        }

        public void popularLabels4()
        {

            Conexao.AC();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dtReader;

            String sql = "select count(user_log) as quantidade from usuario;";

            cmd.Connection = Conexao.conexao;
            cmd.CommandText = sql;
            dtReader = cmd.ExecuteReader();

            while (dtReader.Read())
            {
                lblNUmUsers.Text = dtReader[0].ToString();
            }

            Conexao.FC();

        }

        private void agenciasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros c = new Cadastros("Agencia");
            c.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros c = new Cadastros("Clientes");
            c.ShowDialog();
        }

        private void fabricantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros c = new Cadastros("Fabricantes");
            c.ShowDialog();
        }

        private void formaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros c = new Cadastros("Forma");
            c.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros c = new Cadastros("Fornecedores");
            c.ShowDialog();
        }

        private void funçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros c = new Cadastros("Funcao");
            c.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros c = new Cadastros("Func");
            c.ShowDialog();
        }

        private void localizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros c = new Cadastros("Loc");
            c.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros c = new Cadastros("Prod");
            c.ShowDialog();
        }

        private void setorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros c = new Cadastros("Setor");
            c.ShowDialog();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros c = new Cadastros("Veiculos");
            c.ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Relatorio_de_Vendas r = new Relatorios.Relatorio_de_Vendas();
            r.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void btnREL_Click(object sender, EventArgs e)
        {
            Relatorios.PainelRelatorios p = new Relatorios.PainelRelatorios();
            p.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SobreNos s = new SobreNos();
            s.ShowDialog();

        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Relatorios.Relatorio_de_Fornecedores rel = new Relatorios.Relatorio_de_Fornecedores();
            rel.Show();
        }

        private void entregasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Relatorio_de_Entrega rel_Ent = new Relatorios.Relatorio_de_Entrega();
            rel_Ent.Show();
        }

        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerenciamento_de_Orçamento.Exibir_Orcamento orc = new Gerenciamento_de_Orçamento.Exibir_Orcamento();
            orc.ShowDialog();
        }

        private void btnEntregas_Click(object sender, EventArgs e)
        {
            Entrega.GerenciamentoDeEntregas entrega = new Entrega.GerenciamentoDeEntregas();
            entrega.ShowDialog();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void Principal_Activated(object sender, EventArgs e)
        {
            GR = panel1.CreateGraphics();
            cx = panel1.Width / 2;
            cy = panel1.Height / 2;
            GR.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Temporizado.Interval = 1000;
            Temporizado.Enabled = true;
            RefrescarGraficos();   
        }

                public void DrawPoints()
                {
                    // fazer os tracinhos

                     float AnguloTemp = 0;
                    double i;
                    for (i = 0; i <= 360; i += (360 / 60))
                    {
                        AnguloTemp = (float)(i * rad);

                        float TempXInicial = (float)(cx - (Math.Cos(AnguloTemp) * 80));
                        float TempYInicial = (float)(cy - (Math.Sin(AnguloTemp) * 80));

                        float TempXInicialMaior = (float)(cx - (Math.Cos(AnguloTemp) * 80));
                        float TempYInicialMaior = (float)(cy - (Math.Sin(AnguloTemp) * 80));

                        float TempXInicialMenor = (float)(cx - (Math.Cos(AnguloTemp) * 85));
                        float TempYInicialMenor = (float)(cy - (Math.Sin(AnguloTemp) * 85));

                        float TempXFinal = (float)(cx - (Math.Cos(AnguloTemp) * 90));
                        float TempYFinal = (float)(cy - (Math.Sin(AnguloTemp) * 90));

                        Pen M1 = new Pen(Color.Black, (float)1.2);
                        Pen M2 = new Pen(Color.Black, (float)1.2);
                        Pen M3 = new Pen(Color.Black, (float)1.2);

                        M1.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        M2.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        M3.StartCap = System.Drawing.Drawing2D.LineCap.Round;

                        if (i == 0 || i == 90 || i == 180 || i == 270)
                        {
                            GR.DrawLine(M2, TempXInicialMaior, TempYInicialMaior, TempXFinal, TempYFinal);
                        }
                        else if (i == 30 || i == 60 || i == 120 || i == 150 || i == 210 || i == 240 || i == 300 || i == 330)
                        {
                            GR.DrawLine(M3, TempXInicial, TempYInicial, TempXFinal, TempYFinal);
                        }
                        else
                        {
                            GR.DrawLine(M1, TempXInicialMenor, TempYInicialMenor, TempXFinal, TempYFinal);
                        }
                    }

                }

        private void DesenharMarcaData()
        {

            //Bitmap B = new Bitmap(16, 16);
            //Graphics BG = Graphics.FromImage(B);

            //BG.DrawImage(this.Icon.ToBitmap(), new Rectangle(0, 0, 16, 16), new Rectangle(0, 0, (int)(this.Icon.ToBitmap().Width), (int)(this.Icon.ToBitmap().Height)), GraphicsUnit.Pixel);
            //GR.DrawImage(B, CentroX - 35, CentroY + 28);
            Font F = new Font("Arial", 14, FontStyle.Italic, GraphicsUnit.Pixel);
            Font F2 = new Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Pixel);
            string Marca = "GSLJ";
            DateTime Data = DateTime.Now;

            SizeF TamStr = new SizeF();
            TamStr = GR.MeasureString(Marca, F);
            SizeF TamData = new SizeF();
            TamData = GR.MeasureString(Data.ToString("dd/MM/yyyy"), F2);
            System.Drawing.Drawing2D.LinearGradientBrush GB = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(10, 0, (int)TamStr.Width, (int)TamStr.Height), Color.Black, Color.DarkGreen, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            GR.DrawString(Marca, F, GB, (cx - (TamStr.Width / 2)) + 3, cy + 28);
            GR.DrawString(Data.ToString("dd/MM/yyyy"), F2, Brushes.DarkGreen, cx - (TamData.Width / 2) + 4, cy + 45);
        }

        private void DesenharPonteiros()
        {
            int hora = DateTime.Now.Hour;
            int minuto = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            long tempototal = (hora * 3600) + (minuto * 60) + second;
            double AnguloSegundo = ((tempototal % 60) * 360) / 60;
            double AnguloMinuto = ((tempototal / 60 % 60) * 360) / 60;
            hora = hora % 12;
            int val = (int)((hora * 30) + (minuto * 0.5));
            double AnguloHora = 270 + ((hora + (minuto / 60) + (second / 3600) * 360) / 12);
            double AnguloSegundoInverso = (AnguloSegundo + 270) * rad;
            double am, ans, anis;
            am = AnguloMinuto;
            ans = AnguloSegundo;
            anis = AnguloSegundoInverso;

            AnguloHora = (AnguloHora + 90) * rad;
            AnguloMinuto = (AnguloMinuto + 89.9) * rad;
            AnguloSegundo = (AnguloSegundo + 90) * rad;

            double TempHoraXFinal = cx - Math.Cos(AnguloHora) * 40;
            double TempHoraYFinal = cy - Math.Sin(AnguloHora) * 40;
            if (val >= 0 && val <= 180)
            {
                TempHoraXFinal = cx + (int)(40 * Math.Sin(Math.PI * val / 180));
                TempHoraYFinal = cy - (int)(40 * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                TempHoraXFinal = cx - (int)(40 * -Math.Sin(Math.PI * val / 180));
                TempHoraYFinal = cy - (int)(40 * Math.Cos(Math.PI * val / 180));
            }
            double TempMinutoXFinal = cx - Math.Cos(AnguloMinuto) * 75;
            double TempMinutoYFinal = cy - Math.Sin(AnguloMinuto) * 75;
            double TempSegundoXFinal = cx - Math.Cos(AnguloSegundo) * 80;
            double TempSegundoYFinal = cy - Math.Sin(AnguloSegundo) * 80;
            float TempSegundoInversoXFinal = (float)(cx - Math.Cos(AnguloSegundoInverso) * 17);
            float TempSegundoInversoYFinal = (float)(cy - Math.Sin(AnguloSegundoInverso) * 17);
            double TempHoraXInicial = 0;
            double TempHoraYInicial = 0;
            if (val >= 0 && val <= 180)
            {
                TempHoraXInicial = cx + (int)(Math.Sin(Math.PI * val / 180));
                TempHoraYInicial = cy - (int)(Math.Cos(Math.PI * val / 180));
            }
            else
            {
                TempHoraXInicial = cx - (int)(Math.Sin(Math.PI * val / 180));
                TempHoraYInicial = cy - (int)(Math.Cos(Math.PI * val / 180));
            }
            double TempMinutoXInicial = cx - Math.Cos(AnguloMinuto);
            double TempMinutoYInicial = cy - Math.Sin(AnguloMinuto);
            double TempSegundoXInicial = cx - Math.Cos(AnguloSegundo);
            double TempSegundoYInicial = cy - Math.Sin(AnguloSegundo);
            double TempSegundoIXInicial = cx - Math.Cos(AnguloSegundoInverso);
            double TempSegundoIYInicial = cy - Math.Sin(AnguloSegundoInverso);

            Pen p = new Pen(Color.Black, (float)2.2);
            Pen ps = new Pen(Color.Red, (float)0.8);
            Pen pb = new Pen(Color.White, 4);
            Pen PSegundoInverso = new Pen(Color.Red, (float)(0.6));
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            ps.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            PSegundoInverso.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            thix = (int)TempHoraXInicial;
            thiy = (int)TempHoraYInicial;
            tmix = (int)TempMinutoXInicial;
            tmiy = (int)TempMinutoYInicial;
            tsix = (int)TempSegundoXInicial;
            tsiy = (int)TempSegundoYInicial;
            tsiix = (int)TempSegundoIXInicial;
            tsiiy = (int)TempSegundoIYInicial;
            thfx = (int)TempHoraXFinal;
            thfy = (int)TempHoraYFinal;
            tmfx = (int)TempMinutoXFinal;
            tmfy = (int)TempMinutoYFinal;
            tsfx = (int)TempSegundoXFinal;
            tsfy = (int)TempSegundoYFinal;
            tsifx = (int)TempSegundoInversoXFinal;
            tsify = (int)TempSegundoInversoYFinal;
            if (othix != 0)
            {
                pb.Width = 5;
                GR.DrawLine(pb, othix, othiy, othfx, othfy);
            }
            if (otmix != 0)
            {
                pb.Width = 5;
                GR.DrawLine(pb, otmix, otmiy, otmfx, otmfy);
            }
            if (otsix != 0)
            {
                GR.DrawLine(pb, otsix, otsiy, otsfx, otsfy);
            }

            if (otsiix != 0)
            {
                GR.DrawLine(pb, otsiix, otsiiy, otsifx, otisfy);
            }

            if (oam % 30 == 0)
            {
                DrawPoints();
            }
            if (oans % 30 == 0)
            {
                DrawPoints();
            }
            GR.DrawLine(p, thix, thiy, thfx, thfy);
            GR.DrawLine(p, tmix, tmiy, tmfx, tmfy);
            GR.DrawLine(ps, tsix, tsiy, tsfx, tsfy);
            GR.DrawLine(PSegundoInverso, tsiix, tsiiy, tsifx, tsify);

            Rectangle Rect = new Rectangle(0, 0, 5, 5);
            Rect.X = (int)((cx) - Rect.Width / 2);
            Rect.Y = (int)((cy) - Rect.Height / 2);
            GR.FillEllipse(Brushes.Red, Rect);

            double temp = cx - Math.Cos(AnguloHora) * 42;
            double temp1 = cy - Math.Sin(AnguloHora) * 42;
            double temp2 = cx - Math.Cos(AnguloMinuto) * 77;
            double temp3 = cy - Math.Sin(AnguloMinuto) * 77;
            double temp4 = cx - Math.Cos(AnguloSegundo) * 82;
            double temp5 = cy - Math.Sin(AnguloSegundo) * 82;
            double temp14 = cx - Math.Cos(AnguloSegundoInverso) * 18;
            double temp15 = cy - Math.Sin(AnguloSegundoInverso) * 18;
            double temp6 = cx - Math.Cos(AnguloHora);
            double temp7 = cy - Math.Sin(AnguloHora);
            double temp8 = cx - Math.Cos(AnguloMinuto);
            double temp9 = cy - Math.Sin(AnguloMinuto);
            double temp10 = cx - Math.Cos(AnguloSegundo);
            double temp11 = cy - Math.Sin(AnguloSegundo);
            double temp110 = cx - Math.Cos(AnguloSegundoInverso);
            double temp111 = cy - Math.Sin(AnguloSegundoInverso);

            othix = (int)temp6;
            othiy = (int)temp7;
            otmix = (int)temp8;
            otmiy = (int)temp9;
            otsix = (int)temp10;
            otsiy = (int)temp11;
            otsiix = (int)temp110;
            otsiiy = (int)temp111;
            othfx = (int)temp;
            othfy = (int)temp1;
            otmfx = (int)temp2;
            otmfy = (int)temp3;
            otsfx = (int)temp4;
            otsfy = (int)temp5;
            otsifx = (int)temp14;
            otisfy = (int)temp15;
            oam = am;
            oans = ans;

        }

        private void Temporizado_Tick(object sender, System.EventArgs e)
        {
            DesenharPonteiros();
            DesenharMarcaData();
            mtbHora.Text = MeuComputador.Clock.LocalTime.ToLongTimeString();

        }

        private void RefrescarGraficos()
        {
            //panel1.SuspendLayout();
            //            GR.Clear(Color.Transparent);
            //DesenharLimites();
            //DesenharMarcadores();
            
            
            DesenharPonteiros();
            //panel1.ResumeLayout();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            SobreNos s = new SobreNos();
            s.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle R1 = new Rectangle(0, 0, 200, 200);
            R1.X = (int)((cx) - R1.Width / 2);
            R1.Y = (int)((cy) - R1.Height / 2);
            GR.FillEllipse(Brushes.Black, R1);

            Rectangle Rect = new Rectangle(0, 0, 190, 190);
            Rect.X = (int)((cx) - Rect.Width / 2);
            Rect.Y = (int)((cy) - Rect.Height / 2);
            GR.FillEllipse(Brushes.White, Rect);
            //fazer o centro

            
            DrawPoints();
        }

        private void preçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesquisarPreço p = new pesquisarPreço();
            p.ShowDialog();
        }
    }

}
