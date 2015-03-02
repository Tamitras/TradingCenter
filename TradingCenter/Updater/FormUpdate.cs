using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updater
{
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        public void Init(String temp)
        {
            label2.Text = temp;
        }

        private void btnAbortUpdate_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
