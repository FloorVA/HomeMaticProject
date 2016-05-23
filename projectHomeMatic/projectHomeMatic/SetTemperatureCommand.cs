using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectHomeMatic
{
    class SetTemperatureCommand
    {
        private byte[] commandData = new byte[2]; //De data die via bluetooth verstuurd moet worden

        /// <summary>
        /// De array die via bluetooth wordt gestuurd wordt hier gevuld
        /// </summary>
        /// <param name="temperature"></param>
        public SetTemperatureCommand(double temperature)
        {
            commandData[0] = 65;
            commandData[1] = (byte)(int)(Convert.ToDouble(temperature) * 2.0D);
        }

        /// <summary>
        /// Methode die door andere classes kan worden aangeroepen om de commandData array op te halen
        /// </summary>
        /// <returns></returns>
        public byte[] GetCommandData()
        {
            return commandData;
        }
    }
}
