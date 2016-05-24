using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMatic
{
    class SetTemperatureCommand
    {
        private byte[] commandData = new byte[2];

        /// <summary>
        /// Method that fills the commandData array with the required data
        /// </summary>
        /// <param name="temperature"></param>
        public SetTemperatureCommand(double temperature)
        {
            commandData[0] = 65;
            commandData[1] = (byte)(int)(Convert.ToDouble(temperature) * 2.0D);
        }

        /// <summary>
        /// Method that returns the commandData array
        /// </summary>
        /// <returns></returns>
        public byte[] GetCommandData()
        {
            return commandData;
        }
    }
}
