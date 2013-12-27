using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /*Concrete Command*/
    public class TurnTVUp : ICommand
    {
        IElectronicDevice theDevice;

        public TurnTVUp(IElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }

        public void execute()
        {
            theDevice.volumeUp();
        }

        public void undo()
        {
            theDevice.volumeDown();
        }
    }
}
