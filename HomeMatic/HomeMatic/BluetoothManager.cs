﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InTheHand.Net.Bluetooth;
using InTheHand.Net;
using InTheHand.Net.Sockets;

namespace HomeMatic
{
    static class BluetoothManager
    {
        private static BluetoothClient currentDevice;
        
        /// <summary>
        /// Method to send data to the device the program is currently connected to
        /// </summary>
        public static void sendData()
        {
            //currentDevice.GetStream().Write();
        }

        public static void setCurrentDevice(BluetoothClient bltClient)
        {
            currentDevice = bltClient;
        }

        public static BluetoothClient getCurrentDevice()
        {
            return currentDevice;
        }
    }
}