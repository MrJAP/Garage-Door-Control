using System;
using System.Collections.Generic;
using System.Device.I2c;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageDoorControl.Common
{
    public class RelayTest
    {
        public async Task ToggleRelay(byte relay)
        {
            if (relay < 1 || relay > 4)
                throw new ArgumentOutOfRangeException(nameof(relay), "This relay only has four modules, and supports relay values 1 through 4.");

            var i2cSettings = new I2cConnectionSettings(1, 0x6D);
            var i2cDevice = I2cDevice.Create(i2cSettings);

            i2cDevice.WriteByte(relay);

            i2cDevice.WriteByte(Convert.ToByte(relay + 4));
            var value = i2cDevice.ReadByte();
            Console.WriteLine("Relay value = " + value);

            await Task.Delay(500);

            i2cDevice.WriteByte(relay);

            i2cDevice.WriteByte(Convert.ToByte(relay + 4));
            value = i2cDevice.ReadByte();
            Console.WriteLine("Relay value = " + value);


        }


        public void TurnAllRelaysOff()
        {
            var i2cSettings = new I2cConnectionSettings(1, 0x6D);
            var i2cDevice = I2cDevice.Create(i2cSettings);

            i2cDevice.WriteByte(0xA);

        }
    }
}
