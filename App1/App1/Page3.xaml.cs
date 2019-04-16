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
                mStopWatch.Start();
                stopButton.IsVisible = true;
                
                return false;
            });
        }

        private void stopButton_Clicked(object sender, EventArgs e)
        {
            mStopWatch.Stop();
            long elapsed = mStopWatch.ElapsedMilliseconds;
            statusText.Text = elapsed.ToString();
            mStopWatch.Reset();
            stopButton.IsVisible = false;
            startButton.IsVisible = true;
        }

       
    }

}
