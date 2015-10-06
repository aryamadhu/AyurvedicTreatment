using AyurvedicTreatment.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace AyurvedicTreatment
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class htmlview : Page
    {
      public int index;
       // selectedItem=TreatmentName;

        

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        public htmlview()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;
        }

        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// <para>
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="NavigationHelper.LoadState"/>
        /// and <see cref="NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        /// </para>
        /// </summary>
        /// <param name="e">Provides data for navigation methods and event
        /// handlers that cannot cancel the navigation request.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var indextemp = e.Parameter as string;
            index = Convert.ToInt16(indextemp);
            this.navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void WebView_LoadCompleted(object sender, NavigationEventArgs e)
        {

        }
        private void WebView_Loaded(object sender, RoutedEventArgs e)
        {

          //  Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/Abhyangam.html");
            //   LocalUriResolver resolver = new LocalUriResolver();
           //    web1.NavigateToLocalStreamUri(uri, resolver);


           switch(index)
            {
                case 0:
                    { 
                    Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/gandoosham4.html");
                    LocalUriResolver resolver = new LocalUriResolver();
                    web1.NavigateToLocalStreamUri(uri, resolver);
                    }
                    break;


                case 1:
                    {
                        Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/Thailadhara.html");
                        LocalUriResolver resolver = new LocalUriResolver();
                        web1.NavigateToLocalStreamUri(uri, resolver);
                    }
                    break;
               case 2:
                    {
                        Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/Netratharpanam.html");
                        LocalUriResolver resolver = new LocalUriResolver();
                        web1.NavigateToLocalStreamUri(uri, resolver);
                    }
                    break;

               case 3:
                    {
                        Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/Kateevasthi.html");
                        LocalUriResolver resolver = new LocalUriResolver();
                        web1.NavigateToLocalStreamUri(uri, resolver);
                    }
                    break;

               case 4:
                    {
                        Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/Lepam.html");
                        LocalUriResolver resolver = new LocalUriResolver();
                        web1.NavigateToLocalStreamUri(uri, resolver);
                    }
                    break;

               case 5:
                    {
                        Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/Njavarakizhi.html");
                        LocalUriResolver resolver = new LocalUriResolver();
                        web1.NavigateToLocalStreamUri(uri, resolver);
                    }
                    break;

               case 6:
                    {
                        Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/Thakradhara.html");
                        LocalUriResolver resolver = new LocalUriResolver();
                        web1.NavigateToLocalStreamUri(uri, resolver);
                    }
                    break;

               case 7:
                    {
                        Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/Snehapanam.html");
                        LocalUriResolver resolver = new LocalUriResolver();
                        web1.NavigateToLocalStreamUri(uri, resolver);
                    }
                    break;

               case 8:
                    {
                        Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/Sirodhara.html");
                        LocalUriResolver resolver = new LocalUriResolver();
                        web1.NavigateToLocalStreamUri(uri, resolver);
                    }
                    break;

              
               case 9:
                    {
                        Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/Thalapothichil.html");
                        LocalUriResolver resolver = new LocalUriResolver();
                        web1.NavigateToLocalStreamUri(uri, resolver);
                    }
                    break;

               case 10:
                    {
                        Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/Vasthi.html");
                        LocalUriResolver resolver = new LocalUriResolver();
                        web1.NavigateToLocalStreamUri(uri, resolver);
                    }
                    break;

               case 11:
                    {
                        Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/Abhyangam.html");
                        LocalUriResolver resolver = new LocalUriResolver();
                        web1.NavigateToLocalStreamUri(uri, resolver);
                    }
                    break;

               case 12:
                    {
                        Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/Dhoomapanam.html");
                        LocalUriResolver resolver = new LocalUriResolver();
                        web1.NavigateToLocalStreamUri(uri, resolver);
                    }
                    break;

               case 13:
                    {
                        Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/Netradhara.html");
                        LocalUriResolver resolver = new LocalUriResolver();
                        web1.NavigateToLocalStreamUri(uri, resolver);
                    }
                    break;

               case 14:
                    {
                        Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/Nasyam.html");
                        LocalUriResolver resolver = new LocalUriResolver();
                        web1.NavigateToLocalStreamUri(uri, resolver);
                    }
                    break;

               case 15:
                    {
                        Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/Vamanam.html");
                        LocalUriResolver resolver = new LocalUriResolver();
                        web1.NavigateToLocalStreamUri(uri, resolver);
                    }
                    break;

               case 16:
                    {
                        Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/Siropichu.html");
                        LocalUriResolver resolver = new LocalUriResolver();
                        web1.NavigateToLocalStreamUri(uri, resolver);
                    }
                    break;

               case 17:
                    {
                        Uri uri = web1.BuildLocalStreamUri("LocalData", "Html/Sirovasthi.html");
                        LocalUriResolver resolver = new LocalUriResolver();
                        web1.NavigateToLocalStreamUri(uri, resolver);
                    }
                    break;

                                                                           
                                                   

                default:
                    break;

            }
            
        }
     
    }
  }




