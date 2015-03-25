using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;


namespace Umbilical
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }



        private void deviceConnect_Click(object sender, RoutedEventArgs e)
        {
            //var statusBar = Windows.UI.ViewManagement.StatusBar.GetForCurrentView();
            var task = new ConnectionSettingsTask();
            task.ConnectionSettingsType = ConnectionSettingsType.Bluetooth;
            task.Show();
            
            NavigationService.Navigate(new Uri("/Details.xaml", UriKind.Relative));
        }

      
       
    }
}