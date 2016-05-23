using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectHomeMatic
{
    public partial class Form1 : Form
    {
        private double setTemp; //De temperatuur die de gebruiker zet
        private byte[] commandData = new byte[2]; //De data die via bluetooth verstuurd moet worden

        public Form1()
        {
            //test
            InitializeComponent();
            //test2
        }

        private void setTempBtn_Click(object sender, EventArgs e)
        {
            //De temperatuur die in de textbox is aangegeven wordt in een variable gezet. Als de textbox
            //leeg is wordt er een error weergegeven.
            try
            {
                if (setTempTxt.Text != "")
                {
                    setTemp = Convert.ToDouble(setTempTxt.Text);
                }
                else
                {
                    MessageBox.Show("Vul een geldige temperatuur in");
                    return;
                }
            }
            //Als er geen double van de tekst kan worden gemaakt wordt er een error weergegeven
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //De aangegeven temperatuur wordt omgezet naar data die het apparaat kan gebruiken
            SetTemperatureCommand stc = new SetTemperatureCommand(setTemp);
            commandData = stc.GetCommandData();

            //De temperatuur die gezet wordt, wordt in een textbox weergegeven
            cmdDataTxt.Text = commandData[0] + "; " + commandData[1];

            //De data die naar het apparaat wordt gestuurd, wordt in een textbox weergegeven
            tempToSetTxt.Text = ((double)commandData[1] / 2).ToString();
        }
    }
}
