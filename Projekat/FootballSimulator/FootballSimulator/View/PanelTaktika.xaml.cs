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
using FootballSimulator.Model;
using System.Diagnostics;
using Windows.UI.Popups;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FootballSimulator.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PanelTaktika : Page
    {
        bool sezona = false;
        public PanelTaktika()
        {
            this.InitializeComponent();
            if(!sezona)
            {
                ToolBar.Visibility = Visibility.Collapsed;
                buttonSljedeceKolo.Visibility = Visibility.Collapsed;
            }
        }
        public PanelTaktika(Tim t)
        {
            this.InitializeComponent();
            prikazTima = new CustomKontrole.PrikazTima(t.Formacija);
            prikazIgraca("");
            listViewIgraci.ItemsSource = t.Sastav;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Tim t = e.Parameter as Tim;
            prikazIgraca(t.Formacija);
            try
            {
                SimulatorContext db = new SimulatorContext();
                List<Igrac> igraci = new List<Igrac>(db.Igraci.ToList());
                foreach (Igrac i in igraci)
                {
                    if (i.TimId == Convert.ToInt32(t.Id))
                        t.Sastav.Add(i);
                }
                listViewIgraci.ItemsSource = t.Sastav;
            }
            catch(Exception er)
            {
                MessageDialog mb = new MessageDialog(er.Message);
                mb.ShowAsync();
            }

            
        }
        private void prikazIgraca(String taktika)
        {
            if (taktika == "4-4-2")
                prikaz442();
            else
                prikaz433();

        }
        private void prikaz442()
        {

            Grid.SetRow(igrac1, 3); Grid.SetColumn(igrac1, 2);
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
