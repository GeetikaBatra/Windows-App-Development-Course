using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;
using Windows.Networking.Proximity;


namespace Umbilical
{   
    public partial class Details : PhoneApplicationPage
    {
        DispatcherTimer timer = new DispatcherTimer();
        
        String[] motherBeat = new String[10]{"84","85","86","84","85","84","86","85","86","84"};
        String[] fetalBeat = new String[10] { "125", "126", "124", "125", "126", "127", "124", "126", "125", "124" };
        
        int currentCount = 0;
        public Details()
        {

            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.Tick += new EventHandler(timer_Tick);
          

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (currentCount < 10)
            {
                tempText.Text = "97 F";
                contraText.Text = "15 mins";
                motherText.Text = motherBeat[currentCount];
              fetalText.Text = fetalBeat[currentCount];
              currentCount++;
            }
            else
                currentCount = 0;
        }


       

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }






          
    
     
    }
}