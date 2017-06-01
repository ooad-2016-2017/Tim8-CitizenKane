using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Devices.SerialCommunication;
using Windows.Storage.Streams;

namespace FootballSimulator.ExternalDevices.Arduino
{
    class Arduino
    {
        SerialDevice device;

        public static List<SerialDeviceWrapper> SerialDevices;

        public Arduino(SerialDevice device)
        {
            this.Device = device;
        }

        public SerialDevice Device { get => device; set => device = value; }

        public async static Task skenirajPortove()
        {
            SerialDevices = new List<SerialDeviceWrapper>();

            var tmp = await DeviceInformation.FindAllAsync(SerialDevice.GetDeviceSelector());
            var infos = tmp.ToList();

            foreach (var i in infos)
            {
                SerialDevices.Add(new SerialDeviceWrapper(await SerialDevice.FromIdAsync(i.Id), i.Name));
            }
        }

        public async void pobjeda()
        {
            DataWriter dw = new DataWriter(Device.OutputStream);
            dw.WriteString("win");
            await dw.StoreAsync();
        }

        public async void poraz()
        {
            DataWriter dw = new DataWriter(Device.OutputStream);
            dw.WriteString("lose");
            await dw.StoreAsync();
        }

        public async void remi()
        {
            DataWriter dw = new DataWriter(Device.OutputStream);
            dw.WriteString("draw");
            await dw.StoreAsync();
        }

        public async void ugasi()
        {
            DataWriter dw = new DataWriter(Device.OutputStream);
            dw.WriteString("ledsOff");
            await dw.StoreAsync();
        }

    }
}
