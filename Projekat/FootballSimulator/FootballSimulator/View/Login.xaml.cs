﻿using FootballSimulator.CustomKontrole;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FootballSimulator.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();
        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            //Take selected user
            this.Frame.Navigate(typeof(MenuMain), null);
        }

        private void newBtn_Click(object sender, RoutedEventArgs e)
        {
            NoviKorisnik nk = new NoviKorisnik();

            p.Child = nk;
            p.IsOpen = true;
        }
    }
}
