using System;
using System.Collections.Generic;
using System.Device.I2c;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageDoorControl.Common
{
    public class LcdTest
    {
        const byte LcdDislayAddress = 0x72;

        public void SendMessage(string message)
        {
            //TODO: Check for strings that are too long

            var i2cSettings = new I2cConnectionSettings(1, LcdDislayAddress);
            var i2cDevice = I2cDevice.Create(i2cSettings);

            ClearDisplay(i2cDevice);

            var messageBytes = Encoding.ASCII.GetBytes(message);
            i2cDevice.Write(messageBytes);

        }

        public void ClearDisplay()
        {
            var i2cSettings = new I2cConnectionSettings(1, LcdDislayAddress);
            var i2cDevice = I2cDevice.Create(i2cSettings);
            i2cDevice.WriteByte(0x7C); //Enter settings mode
            i2cDevice.WriteByte(0x2D); //Clear Display
        }

        private void ClearDisplay(I2cDevice i2cDevice)
        {
            i2cDevice.WriteByte(0x7C); //Enter settings mode
            i2cDevice.WriteByte(0x2D); //Clear Display
        }
    }
}
