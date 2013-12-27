using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /*Concrete Command*/
    public class TurnTVOff : ICommand
    {
        /*Receiver*/
        IElectronicDevice theDevice;

        /*Connecting this concrete command to a new receiver*/
        public TurnTVOff(IElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }

        public void execute()
        {   /*Receiver -> Action */
            theDevice.off();
        }

        public void undo()
        {
            theDevice.on();
        }
    }
}
