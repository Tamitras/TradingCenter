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
    public partial class UCButtonTradingList : UserControl
    {
        public Boolean IsOpen { get; set; }
        public UCButtonTradingList()
        {
            InitializeComponent();
        }
    }
}
