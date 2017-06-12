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
using Windows.UI.Popups;
using Windows.ApplicationModel.DataTransfer;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace FootballSimulator.CustomKontrole
{
    public sealed partial class PrikazIgraca : UserControl
    {


        public PrikazIgraca()
        {
            this.InitializeComponent();
            igracBroj.Text = Convert.ToString(0);
            igracIme.Text = "";
        }
        public PrikazIgraca(Model.Igrac i)
        {
            igracBroj.Text = Convert.ToString(0);
            igracIme.Text = i.Ime;

        }
        public PrikazIgraca(Model.Igrac i, int broj)
        {
            this.igracBroj.Text = Convert.ToString(broj);
            igracIme.Text = i.Ime;
        }
        public PrikazIgraca(int br)
        {
            igracBroj.Text = Convert.ToString(br);
            igracIme.Text = "";
        }
        public void postaviIgraca(Model.Igrac i)
        {
            igracIme.Text = i.Ime;
        }
        public void postaviIgraca(Model.Igrac i, int broj)
        {
            postaviIgraca(i);
            postaviBroj(broj);
        }
        public void postaviBroj(int broj)
        {
            this.igracBroj.Text = Convert.ToString(broj);
        }

        private void UserControl_DropCompleted(UIElement sender, DropCompletedEventArgs args)
        {
            //
        }

        private void UserControl_Drop(object sender, DragEventArgs e)
        {
            //if (e.DataView.Contains(StandardDataFormats.Text))
                //igracIme.Text = (e.DataView.GetStorageItemsAsync());
        }

        private void UserControl_DragEnter(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Copy;
        }
    }
}
