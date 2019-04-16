using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class Page2 : ContentPage
    {
        Stopwatch mStopWatch = new Stopwatch();

        public Page2()
        {
            InitializeComponent();
            SetupDefaults();
            entText.IsEnabled = false;
        }

        private void SetupDefaults()
        {

        }

        private void EntText_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if(entText.ToString()==textToEnter.ToString())
            {
                gameConfirm.IsEnabled = true;
                
                
            }
        }

        private void Game2Starter_Clicked(object sender, EventArgs e)
        {
            string[] text = { "Android", "Apple", "Samsung", "Huawei", "Sony" };
            entText.IsEnabled = true;
            textToEnter.Text = text[new Random().Next(0, text.Length)];
            gameConfirm.IsEnabled = true;
            mStopWatch.Start();
        }

        private void GameConfirm_Clicked(object sender, EventArgs e)
        {
            if (entText.Text == textToEnter.Text)
            {
                mStopWatch.Stop();
                long elapsed = mStopWatch.ElapsedMilliseconds;
                time.Text = elapsed.ToString();
                mStopWatch.Reset();
                ifChecker.Text = "It is correct!";
                time.Text = "Time to enter string: "+time.Text+" milliseconds";
                gameConfirm.IsEnabled = false;
            }
            else
            {
                ifChecker.Text = "It is not correct!";
            }
        }

        private void Game2Rules_Clicked(object sender, EventArgs e)
        {
            //this is to navigate to the second game page
            Navigation.PushAsync(new Game2Rules());

        }
    }

}
