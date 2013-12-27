using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /*Concrete Command*/
    public class TurnTVOn : ICommand
    {
        IElectronicDevice theDevice;

        public TurnTVOn(IElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }

        public void execute()
        {
            theDevice.on();
        }

        public void undo()
        {
            theDevice.off();
        }
    }
}
