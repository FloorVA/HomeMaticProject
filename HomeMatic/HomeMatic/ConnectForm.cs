using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand.Net.Sockets;
using InTheHand.Net;

namespace HomeMatic
{
    public partial class ConnectForm : Form
    {
        // code is 2339 van bluetooth
        BluetoothClient bc;
        BluetoothDeviceInfo[] devices;
        BluetoothEndPoint localEndpoint;
        BluetoothClient localClient;

        public ConnectForm()
        {
            InitializeComponent();
            searchBltDevices();
        }

        private void searchBltDevices()
        {
            try
            {
                bc = new BluetoothClient();
                try
                {
                    devices = bc.DiscoverDevices(8);
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e);
                }
            }
            catch (PlatformNotSupportedException e)
            {
                Console.WriteLine(e);
            }

            lbFoundDevices.Items.Clear();

            try
            {
                for (int i = 0; i < devices.Length; i++)
                {
                    lbFoundDevices.Items.Add(devices[i].DeviceName);
                    lbFoundDevices.Items.Add(devices[i].DeviceAddress);
                    lbFoundDevices.Items.Add("");
                }
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e);
            }
            
        }

        /// <summary>
        /// Confirmed the bluetooth device
        /// New form opens to enter the PIN for the thermostat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (devices != null)
            {
                for (int i = 0; i < devices.Length; i++)
                {
                    if(lbFoundDevices.SelectedItem == devices[i])
                    {
                        BluetoothManager.setCurrentDevice(localEndpoint);
                    }
                }
            }
            PinForm pinFrm = new PinForm();
            pinFrm.Show();
        }
    }
}
