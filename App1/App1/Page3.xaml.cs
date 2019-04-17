using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class Page3 : ContentPage
    {
        //stopwatch using system diagnostics
        Stopwatch mStopWatch = new Stopwatch();

        public Page3()
        {
            InitializeComponent();
            SetupDefaults();
           
        }

        private void SetupDefaults()
        {
            
        }

        private void Game3Rules_Clicked(object sender, EventArgs e)
        {
            //this is to navigate to the second game page
            Navigation.PushAsync(new Game3Rules());

        }

        private void startButton_Clicked(object sender, EventArgs e)
        {

            startButton.IsVisible = false;
            
            statusText.Text = "Get Ready";
            Random R = new Random();

            Device.StartTimer(TimeSpan.FromSeconds(R.Next(3, 10)), () =>
            {
                //stopwatch starts when clicked and appears randomly between 3-10 seconds
                mStopWatch.Start();
                stopButton.IsVisible = true;
                
                return false;
            });

        }

        private void stopButton_Clicked(object sender, EventArgs e)
        {
            //stop button is clicked and the start button becomes available to click
            startButton.IsEnabled = true;
            mStopWatch.Stop();
            double elapsed = (double)mStopWatch.ElapsedMilliseconds / 1000;
            statusText.Text = elapsed.ToString();

            //stopwatch resets.
            mStopWatch.Reset();

            //stopwatch starts and displays text when clicked.
            statusText.Text = "Time to react to button : " + statusText.Text + " seconds";

            //buttons become available again
            stopButton.IsVisible = false;
            startButton.IsVisible = true;
       
        }
       
    }

}
