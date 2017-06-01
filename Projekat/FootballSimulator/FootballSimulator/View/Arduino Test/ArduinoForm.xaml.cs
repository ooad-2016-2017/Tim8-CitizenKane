using FootballSimulator.ExternalDevices;
using FootballSimulator.ExternalDevices.Arduino;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Enumeration;
using Windows.Devices.SerialCommunication;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FootballSimulator.View.Arduino_Test
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ArduinoForm : Page
    {
        Arduino arduino;
        List<String> stringovi;
        List<SerialDevice> devices;

        public ArduinoForm()
        {
            this.InitializeComponent();
            osvjezi();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            osvjezi();
        }

        async void osvjezi()
        {
            await Arduino.skenirajPortove();
            //Wrapper klasa sluzi da se izbjegnu ove dvije liste i for petlja
            stringovi = new List<string>();
            devices = new List<SerialDevice>();

            foreach(var sdw in Arduino.SerialDevices)
            {
                stringovi.Add(sdw.Name);
                devices.Add(sdw.Device);
            }

            comboBox.ItemsSource = stringovi;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            String name = (string)comboBox.SelectedItem;
            if(name != null)
                arduino = new Arduino(devices[stringovi.IndexOf(name)]);
        }

        private async void button2_Click(object sender, RoutedEventArgs e)
        {
            arduino.pobjeda();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            arduino.remi();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            arduino.poraz();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            arduino.ugasi();
        }
    }
}
