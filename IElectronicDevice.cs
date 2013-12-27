using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public interface IElectronicDevice
    {
        void on();
        void off();
        void volumeUp();
        void volumeDown();
    }
}
