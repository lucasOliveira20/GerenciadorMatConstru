using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    public partial class SplashScreen : Form
    {
        int timervalue = 0;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timervalue += 100;
            progressBar1.Increment(10);
            if (timervalue == 1500)
            {
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Visible = false;
            }
        }
    }
}
