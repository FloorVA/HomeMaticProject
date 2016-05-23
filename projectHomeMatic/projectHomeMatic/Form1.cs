using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectHomeMatic
{
    public partial class Form1 : Form
    {
        private double setTemp;
        private byte[] commandData = new byte[2];

        public Form1()
        {
            //test
            InitializeComponent();
            //test2
        }

        private void setTempBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (setTempTxt.Text != "")
                {
                    setTemp = Convert.ToDouble(setTempTxt.Text);
                }
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            SetTemperatureCommand stc = new SetTemperatureCommand(setTemp);
            commandData = stc.GetCommandData();

            cmdDataTxt.Text = commandData[0] + "; " + commandData[1];

            tempToSetTxt.Text = ((double)commandData[1] / 2).ToString();
        }
    }
}
