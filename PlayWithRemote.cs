using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class PlayWithRemote
    {
        /* Client (1)*/
        static void Main(string[] args)
        {
            /*IElectronicDevice: General interface for a television-radio*/
            IElectronicDevice newDevice = TVRemote.getDevice();

            //Client (1): creates the ConcreteCommand
            //            and sets its receiver
            //ConcreteCommand creation: newDevice connected to onCommand
            /*Connecting this concrete command to a new receiver*/
            TurnTVOn onCommand = new TurnTVOn(newDevice);
            TurnTVOff offCommand = new TurnTVOff(newDevice);
            TurnTVUp upCommand = new TurnTVUp(newDevice);

            //invokes (newDevice connected to onCommand)
            /*Invoker connected to a concrete command*/
            /*Buttons on a remote*/
            DeviceButton onPressed = new DeviceButton(onCommand);
            /*Executes the command*/
            onPressed.press();

            //Invoker invokes the Command(execute)
            onPressed = new DeviceButton(offCommand);
            onPressed.press();

            onPressed = new DeviceButton(upCommand);
            onPressed.press();
            onPressed.press();
            onPressed.press();

            //--//

            Television theTV = new Television();
            Radio theRadio = new Radio();
            List<IElectronicDevice> allDevices = new List<IElectronicDevice>();
            allDevices.Add(theTV);
            allDevices.Add(theRadio);

            TurnItAllOff turnOffDevices = new TurnItAllOff(allDevices);

            DeviceButton turnThemOff = new DeviceButton(turnOffDevices);
            turnThemOff.press();

            //--//

            turnThemOff.pressUndo();

            //LinkedList addFirst()
            LinkedList<ICommand> allCommands = new LinkedList<ICommand>();
            allCommands.AddFirst(upCommand);
            allCommands.AddFirst(offCommand);
            allCommands.AddFirst(onCommand);
            //allCommands: onCommand-offCommand-upCommand
            allCommands.First.Value.undo();
            allCommands.First.Next.Value.undo();
            allCommands.First.Next.Next.Value.undo();
            allCommands.Last.Value.undo();
            // OFF-ON-2-1
        }
    }
}
