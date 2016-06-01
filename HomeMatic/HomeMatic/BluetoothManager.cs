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
         * -95      SendFirmawreData            byte[], int, int
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
            commandData[0] = 65;
            commandData[1] = (byte)(int)(Convert.ToDouble(command) * 2.0D);
            if (bltStream != null)
            {
                bltStream.Write(commandData, 0, 2);
            }
        }

        public static void setCurrentDevice(BluetoothClient bltDevice)
        {
            currentDevice = bltDevice;
            bltStream = currentDevice.GetStream();
        }

        public static BluetoothClient getCurrentDevice()
        {
            return currentDevice;
        }

        public static void setEndPoint(BluetoothEndPoint newEndPoint)
        {
            currentEndPoint = newEndPoint;
        }

        public static BluetoothEndPoint getEndPoint()
        {
            return currentEndPoint;
        }
    }
}
