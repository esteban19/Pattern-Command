using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /*Device - Receiver*/
    public class Television : IElectronicDevice
    {
        private int volume = 0;

        public void on()
        {
            Console.WriteLine("TV is ON");
        }

        public void off()
        {
            Console.WriteLine("TV is OFF");
        }

        public void volumeUp()
        {
            volume++;
            Console.WriteLine("TV Volume is at " + volume);
        }

        public void volumeDown()
        {
            volume--;
            Console.WriteLine("TV Volume is at " + volume);
        }
    }
}
