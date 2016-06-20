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
    /// <summary>
    /// The Main menu. From here the user can navigate to the ConnectForm and TempForm
    /// </summary>
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// if btnConnect is clicked, the ConnectForm opens and Main (this) hides.
        /// </summary>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectForm cfrm = new ConnectForm(this);
            cfrm.Show();
            this.Hide();
        }

        /// <summary>
        /// if btnTempSettings is clicked, the TempForm opens and Main (this) hides.
        /// </summary>
        private void btnTempSettings_Click(object sender, EventArgs e)
        {
            TempForm tmpfrm = new TempForm(this);
            tmpfrm.Show();
            this.Hide();
        }
    }
}
