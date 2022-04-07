using System;
using System.Collections.Generic;
using System.Device.I2c;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageDoorControl.Common
{
    public class GpioTest
    {
        public async Task ReadGpioPins()
        {

            var i2cSettings = new I2cConnectionSettings(1, 0x27);
            var i2cDevice = I2cDevice.Create(i2cSettings);
            while (true)
            {
                i2cDevice.WriteByte(0x00);
                var value = i2cDevice.ReadByte();
                Console.WriteLine("GPIO Value = " + Convert.ToString(value, 2).PadLeft(8, '0'));
                await Task.Delay(500);
            }

           
        }

    }
}
