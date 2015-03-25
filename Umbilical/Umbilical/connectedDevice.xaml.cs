using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Umbilical.Resources;
using Windows.Networking.Sockets;
using Windows.Networking.Proximity;
using System.Diagnostics;
using Windows.Storage.Streams;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Threading;
namespace Umbilical
{
    public partial class connectedDevice : PhoneApplicationPage
    {
        
        public connectedDevice()
        {
            InitializeComponent();
        }



        private void ConnectAppToDeviceButton_Click_1(object sender, RoutedEventArgs e)
        {


           

            //AppToDevice();
            NavigationService.Navigate(new Uri("/Details.xaml", UriKind.Relative));
        }


    }
}
