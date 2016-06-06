using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

            Thread rand = new Thread(new ThreadStart(test));
            rand.Start();
        }

        public void test()
        {
            while(true)
            {
                Random rand = new Random();
                if (rand.Next(1) == 1)
                {
                    currentTemp += 0.5;
                }
                else
                {
                    currentTemp -= 0.5;
                }
                Thread.Sleep(1000);
                try
                {
                    lblCurrentTemp.Text = currentTemp.ToString();
                }
                catch(InvalidOperationException e)
                {
                    Console.WriteLine(e);
                }
            }
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
                catch (FormatException)
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

        /// <summary>
        /// Method that gets the commandData and then sends it to the device
        /// </summary>
        private void SendData()
        {
            SetTemperatureCommand stc = new SetTemperatureCommand(currentTemp);
            commandData = stc.GetCommandData();

            MessageBox.Show("Command Data: " + commandData[0] + "; " + commandData[1]);
        }

        /// <summary>
        /// Method that is called when the Get Information button is pressed. This method will send a request to
        /// get the current information for the thermostat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getInfoBtn_Click(object sender, EventArgs e)
        {
            SystemInformationRequestCommand sirc = new SystemInformationRequestCommand();
            commandData = sirc.GetCommandData();

            MessageBox.Show("Command Data: " + commandData[0]);
        }
    }
}
