using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.SerialCommunication;

namespace FootballSimulator.ExternalDevices
{
    public class SerialDeviceWrapper
    {
        SerialDevice device;
        String name;

        public SerialDeviceWrapper(SerialDevice device, string name)
        {
            this.device = device;
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
        public SerialDevice Device { get => device; set => device = value; }


        //TODO: dodati binding u listu

    }
}
