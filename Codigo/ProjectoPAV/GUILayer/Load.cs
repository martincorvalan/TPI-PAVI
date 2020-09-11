using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoPAV
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void timerload_Tick(object sender, EventArgs e)
        {
            loadsegment.Width += 3;
            if (loadsegment.Width >= 600)
            {
                timerload.Stop();
                Login log = new Login();
                this.Hide();
                log.Show();

            }
        }   
                
    }
}
