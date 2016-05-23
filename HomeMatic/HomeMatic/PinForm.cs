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
    public partial class PinForm : Form
    {
        public PinForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Confirms the given PINcode and tries to pair the devices. 
        /// Closes the connect forms and opens the temperature form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            /*
            if(paired)
            {
                Manager.setCurrentDevice(pairedDevice);
            }
            */
        }
    }
}
