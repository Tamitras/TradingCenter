using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingCenter
{
    
    public partial class FormHome : Form
    {
        /// <summary>
        /// 
        /// </summary>
        UserContolls.UCUnterSpieler UCUnterSpieler { get; set; }

        /// <summary>
        /// 
        /// </summary>
        UserContolls.UCUnterTradingListe UCUnterTradingListe { get; set; }
        public FormHome()
        {
            InitializeComponent();
            // Objekt wird erstellt
            UCUnterSpieler = new UserContolls.UCUnterSpieler();
            UCUnterTradingListe = new UserContolls.UCUnterTradingListe();
            // Control wird hinzugefügt
            this.panel2.Controls.Add(UCUnterSpieler);
            this.panel2.Controls.Add(UCUnterTradingListe);
            // Es wird unsichtbar gemacht
            UCUnterSpieler.Visible = false;
            UCUnterTradingListe.Visible = false;
        }

        private void ResetUserContols()
        {
            // IsOpen wird auf false gesetzt
            UCUnterSpieler.IsOpen = false;
            UCUnterTradingListe.IsOpen = false;
            // Es wird unsichtbar gemacht
            UCUnterSpieler.Visible = false;
            UCUnterTradingListe.Visible = false;

            btnTradingListe.Location = new Point(btnSuche.Location.X, btnSuche.Location.Y + btnSuche.Height);
            btnLiveTrading.Location = new Point(btnTradingListe.Location.X, btnTradingListe.Location.Y + btnTradingListe.Height);
            btnForum.Location = new Point(btnLiveTrading.Location.X, btnLiveTrading.Location.Y + btnLiveTrading.Height);
            btnProfil.Location = new Point(btnForum.Location.X, btnForum.Location.Y + btnForum.Height);
            btnSupoort.Location = new Point(btnProfil.Location.X, btnProfil.Location.Y + btnProfil.Height);
            
        }

        /// <summary>
        /// Button Suche wird geklickt. Buttons werden verschoben und UserContolls werden sichtbar gemacht
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuche_Click(object sender, EventArgs e)
        {
            if(!UCUnterSpieler.IsOpen)
            {
                ResetUserContols();

                UCUnterSpieler.Location = new Point(btnSuche.Location.X, btnSuche.Location.Y + btnSuche.Height);
                btnTradingListe.Location = new Point(btnSuche.Location.X, btnTradingListe.Location.Y + UCUnterSpieler.Height);
                btnLiveTrading.Location = new Point(btnSuche.Location.X, btnTradingListe.Location.Y + btnTradingListe.Height);
                btnForum.Location = new Point(btnSuche.Location.X, btnLiveTrading.Location.Y + btnLiveTrading.Height);
                btnProfil.Location = new Point(btnSuche.Location.X, btnForum.Location.Y + btnForum.Height);
                btnSupoort.Location = new Point(btnSuche.Location.X, btnProfil.Location.Y + btnProfil.Height);
                UCUnterSpieler.IsOpen = true;
                UCUnterSpieler.Visible = true;

            }
            else
            {
                ResetUserContols();
            }
        }

        private void btnTradingListe_Click(object sender, EventArgs e)
        {
            if(!UCUnterTradingListe.IsOpen)
            {
                ResetUserContols();

                UCUnterTradingListe.Location = new Point(btnTradingListe.Location.X, btnTradingListe.Location.Y + btnTradingListe.Height);
                btnLiveTrading.Location = new Point(btnTradingListe.Location.X, btnLiveTrading.Location.Y + UCUnterTradingListe.Height);
                btnForum.Location = new Point(btnTradingListe.Location.X, btnLiveTrading.Location.Y + btnLiveTrading.Height);
                btnProfil.Location = new Point(btnTradingListe.Location.X, btnForum.Location.Y + btnForum.Height);
                btnSupoort.Location = new Point(btnTradingListe.Location.X, btnProfil.Location.Y + btnProfil.Height);
                UCUnterTradingListe.IsOpen = true;
                UCUnterTradingListe.Visible = true;
            }
            else
            {
                ResetUserContols();
            }
        }

     
    }
}
