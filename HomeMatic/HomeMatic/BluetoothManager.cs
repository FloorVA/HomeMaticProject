using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InTheHand.Net.Bluetooth;
using InTheHand.Net;
using InTheHand.Net.Sockets;
using System.IO;

namespace HomeMatic
{
    /// <summary>
    /// Bluetooth manager is static class so it can be accessed at all times. 
    /// It's purpose is to connect to a device and be able to access it in every class.
    /// </summary>
    static class BluetoothManager
    {
        private static BluetoothEndPoint currentEndPoint;
        private static BluetoothClient currentDevice;
        private static Stream bltStream;

        /*
         * Command overviews
         * 
         * Nr.      Name                        Parameters
         * 
   * Byte.MIN_VALUE SetLockState                boolean
         * -96      StartFirmwareUpdate         void
         * -95      SendFirmwareData            byte[], int, int
         * -16      FactoryReset                void
         * 0        SystemInformationRequest    void
         * 3        SetTime                     void
         * 16       SetProfileDay               DayOfWeek, byte[]
         * 17       SetTemperatureConfig        int, int
         * 19       SetTemperatureOffset        int
         * 20       SetWindowOpenConfig         int, int
         * 32       RequestProfile              DayOfWeek
         * 64       SetVacationMode             Calendar, int
         * 64       ControlMode                 ControlMode
         * 65       SetTemperature              int
         * 67       ComfortTemperature          void
         * 68       EcoTemperature              void
         * 69       BoostMode                   boolean
         *   
         */
        
        /// <summary>
        /// Method to send data to the device the program is currently connected to
        /// </summary>
        public static void sendData(String command)
        {
            byte[] commandData = new byte[2];
            // 65 is SetTemperature command (see command summary above)
            commandData[0] = 65;

            // convert double to byte to send it over bluetooth
            commandData[1] = (byte)(int)(Convert.ToDouble(command) * 2.0D);
            if (bltStream != null)
            {
                bltStream.Write(commandData, 0, 2);
            }
        }

        /// <summary>
        /// When a new connection is set up, the device that will be connected to will be set to the current device in the manager. 
        /// A new stream will be set up to the new bluetooth device.
        /// </summary>
        /// <param name="bltDevice"></param>
        public static void setCurrentDevice(BluetoothClient bltDevice)
        {
            currentDevice = bltDevice;
            bltStream = currentDevice.GetStream();
        }

        /// <summary>
        /// Returns the device the program is connected to
        /// </summary>
        /// <returns>currentDevice</returns>
        public static BluetoothClient getCurrentDevice()
        {
            return currentDevice;
        }

        /// <summary>
        /// Sets a new endpoint when a new connection is initialized
        /// </summary>
        /// <param name="newEndPoint"></param>
        public static void setEndPoint(BluetoothEndPoint newEndPoint)
        {
            currentEndPoint = newEndPoint;
        }

        /// <summary>
        /// return the current endpoint of the connection
        /// </summary>
        /// <returns>currentEndPoint</returns>
        public static BluetoothEndPoint getEndPoint()
        {
            return currentEndPoint;
        }
    }
}
