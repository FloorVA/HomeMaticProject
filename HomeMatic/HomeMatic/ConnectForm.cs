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
using InTheHand.Net.Bluetooth;
using System.Threading;

namespace HomeMatic
{
    public partial class ConnectForm : Form
    {
        private String DEVICE_PIN = "2339";
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
                    if(devices[i].DeviceAddress != null && lbFoundDevices.SelectedItem.Equals(devices[i].DeviceAddress))
                    {
                        // connecting
                        localEndpoint = new BluetoothEndPoint(devices[i].DeviceAddress, BluetoothService.SerialPort);
                        try
                        {
                            localClient = new BluetoothClient(localEndpoint);
                        }
                        catch (System.Net.Sockets.SocketException err)
                        {
                            Console.WriteLine(err);
                        }


                        // pairing
                        BluetoothDeviceInfo[] paired = null;
                        try
                        {
                            paired = localClient.DiscoverDevices(255, false, true, false, false);
                        }
                        catch(NullReferenceException er)
                        {
                            Console.WriteLine(er);
                        }

                        foreach (BluetoothDeviceInfo device in devices)
                        {
                            bool isPaired = false;
                            try
                            {
                                for (int x = 0; x < paired.Length; x++)
                                {
                                    if (device.Equals(paired[i]))
                                    {
                                        isPaired = true;
                                        break;
                                    }
                                }
                            }
                            catch(NullReferenceException y)
                            {
                                Console.WriteLine(y);
                            }
                            

                            // if the device is not paired, pair it!
                            if (!isPaired)
                            {
                                // replace DEVICE_PIN here, synchronous method, but fast
                                isPaired = BluetoothSecurity.PairRequest(device.DeviceAddress, DEVICE_PIN);
                                Thread pair = new Thread(() => BluetoothSecurity.PairRequest(device.DeviceAddress, DEVICE_PIN));
                                pair.Start();

                                // wait till pair is done
                                while (pair.IsAlive) ;
                                
                                if (isPaired)
                                {
                                    // pairing completed
                                    MessageBox.Show("PAIRED");

                                    BluetoothManager.setCurrentDevice(localEndpoint);
                                }
                                else
                                {
                                    // pairing failed
                                    MessageBox.Show("PAIRING FAILED");
                                }
                            }
                        }
                    }
                }
            }
            //PinForm pinFrm = new PinForm();
            //pinFrm.Show();
        }
<<<<<<< HEAD

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            searchBltDevices();
        }
=======
>>>>>>> origin/master
    }
}
