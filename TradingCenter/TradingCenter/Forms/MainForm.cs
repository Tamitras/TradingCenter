using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingCenter.Forms
{    
    public partial class MainForm : Form
    {
        #region Events

        #endregion

        #region Attribute

        /// <summary>
        /// UserControl für den Button "Suche"
        /// </summary>
        UserControls.NavBar.Buttons.UCButtonSuche UCButtonSuche { get; set; }
        

        /// <summary>
        /// UserControl für den Button "TradingList"
        /// </summary>
        UserControls.NavBar.Buttons.UCButtonTradingList UCButtonTradingList { get; set; }

        /// <summary>
        /// UserControl für die Anzeige von ButtonSucheSpieler
        /// </summary>
        UserControls.MainForm.Sites.UCFormSucheSpieler UCFormSucheSpieler { get; set; }

        #endregion

        #region Konstruktor
               

        public MainForm()
        {
            InitializeComponent();

            InitPanelMainForm();
            InitPanelNavBar();
            

            //Events werden regestriert
            UCButtonSuche.ButtonSpielerIsClicked += UCButtonSuche_ButtonSpielerIsClicked;            
        }

        #endregion

        #region Initialisierung



        /// <summary>
        /// Initialisiert das Panel für die MainForm
        /// </summary>
        private void InitPanelMainForm()
        {            
            UCFormSucheSpieler = new UserControls.MainForm.Sites.UCFormSucheSpieler();
            UCFormSucheSpieler.Name = "UCFormSucheSpieler";
            this.panelMainForm.Controls.Add(UCFormSucheSpieler);
        }
        /// <summary>
        /// Initialisiert das Panel für die NavBar
        /// </summary>
        private void InitPanelNavBar()
        {
            UCButtonSuche = new UserControls.NavBar.Buttons.UCButtonSuche();
            UCButtonTradingList = new UserControls.NavBar.Buttons.UCButtonTradingList();

            this.panelNavBar.Controls.Add(UCButtonSuche);
            this.panelNavBar.Controls.Add(UCButtonTradingList);

            // Es wird unsichtbar gemacht
            UCButtonSuche.Visible = false;
            UCButtonTradingList.Visible = false;
        }

        /// <summary>
        /// Initialisiert das Panel für die StatusBar
        /// </summary>
        private void InitPanelStatusBar()
        {

        }

        #endregion

        #region EventHandler

        /// <summary>
        /// Eventhandler für ButtonSpieler im UserControl ButtonSuche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCButtonSuche_ButtonSpielerIsClicked(object sender, EventArgs e)
        {
            
            this.panelMainForm.Controls["UCFormSucheSpieler"].Show();
        }

        /// <summary>
        /// Klick auf ButtonSuche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuche_Click(object sender, EventArgs e)
        {
            if (!UCButtonSuche.IsOpen)
            {
                ResetUserContols();

                UCButtonSuche.Location = new Point(btnSuche.Location.X, btnSuche.Location.Y + btnSuche.Height);
                btnTradingListe.Location = new Point(btnSuche.Location.X, btnTradingListe.Location.Y + UCButtonSuche.Height);
                btnLiveTrading.Location = new Point(btnSuche.Location.X, btnTradingListe.Location.Y + btnTradingListe.Height);
                btnForum.Location = new Point(btnSuche.Location.X, btnLiveTrading.Location.Y + btnLiveTrading.Height);
                btnProfil.Location = new Point(btnSuche.Location.X, btnForum.Location.Y + btnForum.Height);
                btnSupoort.Location = new Point(btnSuche.Location.X, btnProfil.Location.Y + btnProfil.Height);
                UCButtonSuche.IsOpen = true;
                UCButtonSuche.Visible = true;

            }
            else
            {
                ResetUserContols();
            }
        }

        /// <summary>
        /// Klick auf ButtonTradingList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTradingListe_Click(object sender, EventArgs e)
        {
            if (!UCButtonTradingList.IsOpen)
            {
                ResetUserContols();

                UCButtonTradingList.Location = new Point(btnTradingListe.Location.X, btnTradingListe.Location.Y + btnTradingListe.Height);
                btnLiveTrading.Location = new Point(btnTradingListe.Location.X, btnLiveTrading.Location.Y + UCButtonTradingList.Height);
                btnForum.Location = new Point(btnTradingListe.Location.X, btnLiveTrading.Location.Y + btnLiveTrading.Height);
                btnProfil.Location = new Point(btnTradingListe.Location.X, btnForum.Location.Y + btnForum.Height);
                btnSupoort.Location = new Point(btnTradingListe.Location.X, btnProfil.Location.Y + btnProfil.Height);
                UCButtonTradingList.IsOpen = true;
                UCButtonTradingList.Visible = true;
            }
            else
            {
                ResetUserContols();
            }
        }

        #endregion

        #region private Methoden

        private void ResetUserContols()
        {
            // IsOpen wird auf false gesetzt
            UCButtonSuche.IsOpen = false;
            UCButtonTradingList.IsOpen = false;
            // Es wird unsichtbar gemacht
            UCButtonSuche.Visible = false;
            UCButtonTradingList.Visible = false;

            btnTradingListe.Location = new Point(btnSuche.Location.X, btnSuche.Location.Y + btnSuche.Height);
            btnLiveTrading.Location = new Point(btnTradingListe.Location.X, btnTradingListe.Location.Y + btnTradingListe.Height);
            btnForum.Location = new Point(btnLiveTrading.Location.X, btnLiveTrading.Location.Y + btnLiveTrading.Height);
            btnProfil.Location = new Point(btnForum.Location.X, btnForum.Location.Y + btnForum.Height);
            btnSupoort.Location = new Point(btnProfil.Location.X, btnProfil.Location.Y + btnProfil.Height);
            
        }

        #endregion

        #region public Methoden

        #endregion
        
    }
}
