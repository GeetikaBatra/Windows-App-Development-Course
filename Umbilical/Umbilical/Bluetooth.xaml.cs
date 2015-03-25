using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace Umbilical
{
      
   
    public partial class Bluetooth : PhoneApplicationPage
    {
        public Bluetooth()
        {
            InitializeComponent();
        }

        private void bluetoothOn_Click(object sender, RoutedEventArgs e)
        {
            var task = new ConnectionSettingsTask();
            task.ConnectionSettingsType = ConnectionSettingsType.Bluetooth;
            task.Show();
            


            NavigationService.Navigate(new Uri("/connectedDevice.xaml", UriKind.Relative));
            


        }

        
    }
}