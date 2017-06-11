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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FootballSimulator.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MenuOdabirTimova : Page
    {
        public MenuOdabirTimova()
        {
            this.InitializeComponent();
            SimulatorContext db = new SimulatorContext();


            listBoxIgrac.ItemsSource = db.Timovi;
            listBoxProtivnik.ItemsSource = db.Timovi;
            //listBoxIgrac.UpdateLayout();
            //listBoxProtivnik.UpdateLayout();
            
        }

        private void buttonNext_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(PanelTaktika), listBoxIgrac.SelectedItem);
        }
    }
}
