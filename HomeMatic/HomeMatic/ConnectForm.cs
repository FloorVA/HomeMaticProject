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
using InTheHand.Net.Bluetooth.Factory;
using System.Threading;

namespace HomeMatic
{
    public partial class ConnectForm : Form
    {
        /*   MAC addresses
         *   00-1A-22   => EQ-3
         *   00-1B-D6   => ELV
         *   48-D8-55   => ELV
         *   90-99-16   => ELV
         *   
         *   found in properties of CC-RT-BLE: BTHLE\DEV_001A2207B4A1\8&207BDF08&0&001A2207B4A1
         *   001A2207B4A1 == MAC-address of the Thermostat
         */

        private String DEVICE_PIN = "2339";
        BluetoothClient bc;
        BluetoothDeviceInfo[] devices;
        BluetoothEndPoint localEndpoint;
        BluetoothClient localClient;
        private Main main;

        public ConnectForm(Main main)
        {
            InitializeComponent();

            this.main = main;
            searchBltDevices();
        }

        /// <summary>
        /// Scan for devices in the area
        /// </summary>
        private void searchBltDevices()
        {
            try
            {
                bc = new BluetoothClient();
                try
                {
                    devices = bc.DiscoverDevices();
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
                /*
                 * While loop to show a messagebox when found a specific device.
                 * Mainly used for testing how to find a particular device.
                
                Boolean found = false;
                while (!found)
                {
                    devices = bc.DiscoverDevices();
                    for (int i = 0; i < devices.Length; i++)
                    {
                        //char[] tempChar = devices[i].DeviceName.ToString().Take(8).ToArray();
                        String tempStr = devices[i].DeviceName;

                        if (tempStr.Equals("CC-RT-BLE") || tempStr.Equals("001A2207B4A1"))
                        {
                            found = true;
                            MessageBox.Show("Found " + devices[i].DeviceName);
                        }
                    }
                }*/

                // add het found name and MAC-addresses of the bluetoothdevices to a listbox
                for (int i = 0; i < devices.Length; i++)
                {
                    lbFoundDevices.Items.Add(devices[i].DeviceName);
                    lbFoundDevices.Items.Add(devices[i].DeviceAddress);
                    lbFoundDevices.Items.Add("");
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("ERROR searching devices: " + e);
            }

        }

        /// <summary>
        /// Confirmed the bluetooth device
        /// New form opens to enter the PIN for the thermostat
        /// Based on: http://stackoverflow.com/questions/16802791/pair-bluetooth-devices-to-a-computer-with-32feet-net-bluetooth-library
        /// </summary>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // check if there even are bluetooth devices detectable 
            if (devices != null)
            {
                for (int i = 0; i < devices.Length; i++)
                {
                    if(devices[i].DeviceAddress != null && lbFoundDevices.SelectedItem != null && lbFoundDevices.SelectedItem.Equals(devices[i].DeviceAddress))
                    {
                        // connecting to the selected device
                        localEndpoint = new BluetoothEndPoint(devices[i].DeviceAddress, BluetoothService.SerialPort);
                        try
                        {
                            localClient = new BluetoothClient(localEndpoint);
                            localClient.Connect(localEndpoint);
                        }
                        catch (System.Net.Sockets.SocketException err)
                        {
                            Console.WriteLine(err);
                        }


                        // pairing
                        BluetoothDeviceInfo[] paired = null;
                        try
                        {
                            paired = localClient.DiscoverDevices(255, default(Boolean), default(Boolean), true, false);
                        }
                        catch(NullReferenceException er)
                        {
                            Console.WriteLine(er);
                        }

                        // check if a device is already paired
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
                                    BluetoothManager.setCurrentDevice(localClient);
                                    BluetoothManager.setEndPoint(localEndpoint);
                                }
                                else
                                {
                                    // pairing failed
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// When the refresh button is pressed, it should look for new devices.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            searchBltDevices();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }
    }
}
