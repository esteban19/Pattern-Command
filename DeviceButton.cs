using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /* Invoker "owns a" Command */
    /* If invoker is destroyed, commands are destroyed */
    /* Invoker handles bookkeeping about the command execution */
    public class DeviceButton
    {
        ICommand theCommand;

        public DeviceButton(ICommand newCommand)
        {
            theCommand = newCommand;
        }

        public void press()
        {
            /*Bookkeeping here*/
            theCommand.execute();
        }

        public void pressUndo()
        {
            theCommand.undo();
        }
    }
}
