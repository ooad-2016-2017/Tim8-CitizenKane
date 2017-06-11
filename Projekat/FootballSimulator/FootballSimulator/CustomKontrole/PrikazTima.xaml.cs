using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace FootballSimulator.CustomKontrole
{
    public sealed partial class PrikazTima : UserControl
    {
        String taktika;

        public string Taktika
        {
            get
            {
                return taktika;
            }
            set
            {
                this.taktika = value;
                prikazIgraca(taktika);
            }
        }
        public PrikazTima()
        {
            this.InitializeComponent();
            prikaz442();
        }
        
        public PrikazTima(String taktika)
        {
            this.InitializeComponent();
            this.Taktika = taktika;
            prikazIgraca(taktika);
        }
        private void prikazIgraca(String taktika)
        {
            if (taktika == "4-4-2")
            {
                prikaz442();
            }
            else
                prikaz433();
        }
        private void prikaz442()
        {
            Grid.SetRow(igrac1, 3); Grid.SetColumn(igrac1,2);
            Grid.SetRow(igrac2, 2); Grid.SetColumn(igrac2, 0);
            Grid.SetRow(igrac3, 2); Grid.SetColumn(igrac3, 1);
            Grid.SetRow(igrac4, 2); Grid.SetColumn(igrac4, 3);
            Grid.SetRow(igrac5, 2); Grid.SetColumn(igrac5, 4);
            Grid.SetRow(igrac6, 1); Grid.SetColumn(igrac6, 0);
            Grid.SetRow(igrac7, 1); Grid.SetColumn(igrac7, 1);
            Grid.SetRow(igrac8, 1); Grid.SetColumn(igrac8, 3);
            Grid.SetRow(igrac9, 1); Grid.SetColumn(igrac9, 4);
            Grid.SetRow(igrac10, 0); Grid.SetColumn(igrac10, 1);
            Grid.SetRow(igrac11, 0); Grid.SetColumn(igrac11, 3);
        }
        private void prikaz433()
        {
            Grid.SetRow(igrac1, 3); Grid.SetColumn(igrac1, 2);
            Grid.SetRow(igrac2, 2); Grid.SetColumn(igrac2, 0);
            Grid.SetRow(igrac3, 2); Grid.SetColumn(igrac3, 1);
            Grid.SetRow(igrac4, 2); Grid.SetColumn(igrac4, 3);
            Grid.SetRow(igrac5, 2); Grid.SetColumn(igrac5, 4);
            Grid.SetRow(igrac6, 1); Grid.SetColumn(igrac6, 1);
            Grid.SetRow(igrac7, 1); Grid.SetColumn(igrac7, 2);
            Grid.SetRow(igrac8, 1); Grid.SetColumn(igrac8, 3);
            Grid.SetRow(igrac9, 0); Grid.SetColumn(igrac9, 1);
            Grid.SetRow(igrac10, 0); Grid.SetColumn(igrac10, 2);
            Grid.SetRow(igrac11, 0); Grid.SetColumn(igrac11, 3);
        }
    }
}
