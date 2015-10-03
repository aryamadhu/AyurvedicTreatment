﻿using System;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace AyurvedicTreatment
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //int index;
       
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

           
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
       
        }


        private void TxtBx_SelectionChanged(object sender, RoutedEventArgs e)
        {
         //   Frame.Navigate(typeof(htmlview));
        }

        private void TxtBx1_SelectionChanged(object sender, RoutedEventArgs e)
        {
          //  this.Frame.Navigate(typeof(htmlview),null);
        }

        private void TxtBx2_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void lbSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        //   TreatmentListBx.SelectedIndex

         int index = this.TreatmentListBx.SelectedIndex ;
         String strPass = index.ToString();

         this.Frame.Navigate(typeof(htmlview), strPass);
        }

   
       
        
    }
}