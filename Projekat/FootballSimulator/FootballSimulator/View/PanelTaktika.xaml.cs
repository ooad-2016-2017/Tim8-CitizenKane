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
        Tim t;
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
            this.t = t;
            //prikazTima = new CustomKontrole.PrikazTima(t.Formacija);
            prikazIgraca("");
            listViewIgraci.ItemsSource = t.Sastav;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            t = e.Parameter as Tim;
            
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
            prikazIgraca(t.Formacija);

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
            popunjavanjeIgraca();
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
            popunjavanjeIgraca();
        }
        private void popunjavanjeIgraca()
        {
            igrac1.postaviIgraca(t.Sastav[0],1);
            igrac2.postaviIgraca(t.Sastav[1],2);
            igrac3.postaviIgraca(t.Sastav[2],3);
            igrac4.postaviIgraca(t.Sastav[3],4);
            igrac5.postaviIgraca(t.Sastav[4],5);
            igrac6.postaviIgraca(t.Sastav[5],6);
            igrac7.postaviIgraca(t.Sastav[6],7);
            igrac8.postaviIgraca(t.Sastav[7],8);
            igrac9.postaviIgraca(t.Sastav[8],9);
            igrac10.postaviIgraca(t.Sastav[9],10);
            igrac11.postaviIgraca(t.Sastav[10],11);
        }

        private void listViewIgraci_DragStarting(UIElement sender, DragStartingEventArgs args)
        {

        }
        private void SourceListView_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            // Set the content of the DataPackage
            e.Data.SetData("", listViewIgraci.SelectedItem);
            // As we want our Reference list to say intact, we only allow Copy
            //e.Data.RequestedOperation = DataPackageOperation.Copy;
        }
    }
}
