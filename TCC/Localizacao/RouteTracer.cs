using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Localizacao
{
    public partial class RouteTracer : Form
    {
        public RouteTracer(string endereco, string nome_cliente, string veiculo, string placa, string dataPrevista)
        {
            InitializeComponent();
            
            lblNome.Text = nome_cliente;
            lblDescVeiculo.Text = veiculo;
            txtEndereco.Text = endereco;
            txtEndereco.ReadOnly = true;
            lblPlaca.Text = placa;
            lblData.Text = dataPrevista.ToString();
            
            ZoomBar.Maximum = 18;
            ZoomBar.Minimum = 5;
            ZoomBar.TickFrequency = 1;
            try
            {
                string start = "Rua Zumbi dos Palmares,470,Campinas,São Paulo,Brasil";
                string end = endereco;
                GeoCoderStatusCode status;
                PointLatLng? stt = GMapProviders.GoogleMap.GetPoint(start, out status);
                PointLatLng? endd = GMapProviders.GoogleMap.GetPoint(end, out status);
                PointLatLng starter = new PointLatLng(stt.Value.Lat, stt.Value.Lng);
                PointLatLng ending = new PointLatLng(endd.Value.Lat, endd.Value.Lng);
                MapRoute route = GMap.NET.MapProviders.OpenStreetMapProvider.Instance.GetRoute(starter, ending, false, false, 5);
                GMapRoute r = new GMapRoute(route.Points, "Rota");
                GMapOverlay routesOverlay = new GMapOverlay("routes");
                routesOverlay.Routes.Add(r);
                objMapa.Overlays.Add(routesOverlay);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("O endereço não pôde ser encontrado, por favor insira outro!");
                txtEndereco.ReadOnly = false;
            }
        }

        private void RouteTracer_Load(object sender, EventArgs e)
        {
            objMapa.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            ZoomBar.Value = 16;
            objMapa.Zoom = ZoomBar.Value;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            objMapa.SetPositionByKeywords("Rua Olivio Franceschini, Hortolândia - SP");
        }

        private void ZoomBar_ValueChanged(object sender, EventArgs e)
        {
            objMapa.Zoom = ZoomBar.Value;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                try
                {
                    string start = "Rua Zumbi dos Palmares,470,Campinas,São Paulo,Brasil";
                    string end = txtEndereco.Text;
                    GeoCoderStatusCode status;
                    PointLatLng? stt = GMapProviders.GoogleMap.GetPoint(start, out status);
                    PointLatLng? endd = GMapProviders.GoogleMap.GetPoint(end, out status);
                    PointLatLng starter = new PointLatLng(stt.Value.Lat, stt.Value.Lng);
                    PointLatLng ending = new PointLatLng(endd.Value.Lat, endd.Value.Lng);
                    MapRoute route = GMap.NET.MapProviders.OpenStreetMapProvider.Instance.GetRoute(starter, ending, false, false, 5);
                    GMapRoute r = new GMapRoute(route.Points, "Rota");
                    GMapOverlay routesOverlay = new GMapOverlay("routes");
                    routesOverlay.Routes.Add(r);
                    objMapa.Overlays.Add(routesOverlay);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("O endereço não pôde ser encontrado, por favor insira outro!");
                    txtEndereco.ReadOnly = false;
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

   }
}
