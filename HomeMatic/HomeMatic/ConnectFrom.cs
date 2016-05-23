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
    public partial class ConnectFrom : Form
    {
        public ConnectFrom()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Confirmed the bluetooth device
        /// New form opens to enter the PIN for the thermostat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            PinForm pinFrm = new PinForm();
            pinFrm.Show();
        }
    }
}
