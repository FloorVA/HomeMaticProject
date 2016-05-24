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
    public partial class TempForm : Form
    {
        double currentTemp = 21.0;
        private byte[] commandData = new byte[2];

        public TempForm()
        {
            InitializeComponent();

            // Configure settings of the label with the current temperature
            lblCurrentTemp.Font = new Font("Microsoft Sans Serif", 20);
            lblCurrentTemp.TextAlign = ContentAlignment.MiddleCenter;
            Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Update the label and send it to via bluetooth
        /// Should always be called after the current temperature is changed
        /// </summary>
        private void updateLabel()
        {
            lblCurrentTemp.Text = currentTemp.ToString();
            bltSend();
        }

        /// <summary>
        /// Sends signal via bluetooth
        /// </summary>
        private void bltSend()
        {
            // TODO:
            // Send data to the thermostat
        }

        /// <summary>
        /// User input for temperature from textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTempChange_KeyDown(object sender, KeyEventArgs e)
        {
            // Key value of the Enter key is 13
            // check if enter is pressed to confirm
            if (e.KeyValue == 13)
            {
                try
                {
                    if (txtTempChange.Text != "")
                    {
                        currentTemp = Convert.ToDouble(txtTempChange.Text);
                        if (currentTemp < 5)
                        {
                            currentTemp = 5;
                        }
                        else if (currentTemp > 29.5)
                        {
                            currentTemp = 29.5;
                        }
                        updateLabel();
                        SendData();
                    }
                    else
                    {
                        updateLabel();
                        SendData();
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter a valid temperature");
                }
            }
        }

        /// <summary>
        /// Button pressed for higher the temperature by 0.5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHigher_Click(object sender, EventArgs e)
        {
            currentTemp += 0.5;
            updateLabel();
        }

        /// <summary>
        /// Button pressed for lowerer the temperature by 0.5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLower_Click(object sender, EventArgs e)
        {
            currentTemp -= 0.5;
            updateLabel();
        }

        private void SendData()
        {
            SetTemperatureCommand stc = new SetTemperatureCommand(currentTemp);
            commandData = stc.GetCommandData();

            MessageBox.Show("Command Data: " + commandData[0] + "; " + commandData[1]);
        }
    }
}
