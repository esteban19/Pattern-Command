using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class TurnItAllOff : ICommand
    {
        List<IElectronicDevice> theDevices;

        public TurnItAllOff(List<IElectronicDevice> newDevices)
        {
            theDevices = newDevices;
        }

        public void execute()
        {
            foreach (IElectronicDevice device in theDevices)
            {
                device.off();
            }
        }

        public void undo()
        {
            foreach (IElectronicDevice device in theDevices)
            {
                device.on();
            }
        }
    }
}
