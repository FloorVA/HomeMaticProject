using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMatic
{
    class SystemInformationRequestCommand
    {
        private byte[] commandData = new byte[1];

        /// <summary>
        /// Method that fills the commandData array with the required data
        /// </summary>
        /// <param name="temperature"></param>
        public SystemInformationRequestCommand()
        {
            commandData[0] = 0;
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
