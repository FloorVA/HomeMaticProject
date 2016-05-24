using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeMatic
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectForm cfrm = new ConnectForm();
            cfrm.Show();
            this.Hide();
        }

        private void btnTempSettings_Click(object sender, EventArgs e)
        {
            TempForm tmpfrm = new TempForm();
            tmpfrm.Show();
            this.Hide();
        }
    }
}
