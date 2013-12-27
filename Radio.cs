using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Radio : IElectronicDevice
    {
        private int volume = 0;

        public void on()
        {
            Console.WriteLine("Radio is ON");
        }

        public void off()
        {
            Console.WriteLine("Radio is OFF");
        }

        public void volumeUp()
        {
            volume++;
            Console.WriteLine("Radio Volume is at " + volume);
        }

        public void volumeDown()
        {
            volume--;
            Console.WriteLine("Radio Volume is at " + volume);
        }
    }
}
