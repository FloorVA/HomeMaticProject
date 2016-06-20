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
        private Main main;

        public TempForm(Main main)
        {
            InitializeComponent();

            // Configure settings of the label with the current temperature
            lblCurrentTemp.Font = new Font("Microsoft Sans Serif", 20);
            lblCurrentTemp.TextAlign = ContentAlignment.MiddleCenter;
            Dock = DockStyle.Fill;

            this.main = main;
        }

        /// <summary>
        /// Update the label and send it to via bluetooth
        /// Should always be called after the current temperature is changed
        /// </summary>
        private void updateLabel()
        {
            lblCurrentTemp.Text = currentTemp.ToString();
            bltSend(currentTemp);
        }

        /// <summary>
        /// User input for temperature from textbox
        /// </summary>
        private void txtTempChange_KeyDown(object sender, KeyEventArgs e)
        {
            // Key value of the Enter key is 13
            // check if enter is pressed to confirm
            if (e.KeyValue == 13)
            {
                try
                {
                    // input check
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
                        bltSend(currentTemp);
                        updateLabel();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid temperature");
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
        private void btnHigher_Click(object sender, EventArgs e)
        {
            currentTemp += 0.5;
            updateLabel();
        }

        /// <summary>
        /// Button pressed for lowerer the temperature by 0.5
        /// </summary>
        private void btnLower_Click(object sender, EventArgs e)
        {
            currentTemp -= 0.5;
            updateLabel();
        }

        /// <summary>
        /// Method that gets the commandData and then sends it to the device
        /// </summary>
        private void bltSend(double newTmp)
        {
            BluetoothManager.sendData(newTmp.ToString());
        }
        /// <summary>
        ///  should get temperature but can not be tested or implemented because the connection between the thermostat cant be initialized.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // currentTemp = BluetoothManager.getTemperature(); 
            updateLabel();
        }

        /// <summary>
        /// Go to Main menu and close this form
        /// </summary>
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.Show();
        }
    }
}
