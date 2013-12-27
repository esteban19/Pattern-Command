using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class TVRemote
    {
        public static IElectronicDevice getDevice()
        {
            return new Television();
        }
    }
}
