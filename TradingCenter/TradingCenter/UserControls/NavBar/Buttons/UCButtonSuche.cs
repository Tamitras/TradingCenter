using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingCenter.UserControls.NavBar.Buttons
{
    public partial class UCButtonSuche : UserControl
    {
        public Boolean IsOpen { get; set; }
        public event EventHandler ButtonSpielerIsClicked;
        public UCButtonSuche()
        {
            InitializeComponent();
            
        }


        private void buttonPlayer_Click(object sender, EventArgs e)
        {
            // Event wird ausgelöst
            // Parent Control muss sich darauf anmelden
            if (null != ButtonSpielerIsClicked)
            {
                ButtonSpielerIsClicked(this, new EventArgs());
            }
        }
    }
}
