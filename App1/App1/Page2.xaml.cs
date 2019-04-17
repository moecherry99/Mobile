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
            //if text is in the box, the confirm button can be clicked
            if(entText.ToString()==textToEnter.ToString())
            {
                gameConfirm.IsEnabled = true;
                
            }

        }

        private void Game2Starter_Clicked(object sender, EventArgs e)
        {
            //random array of strings that are chosen to type
            string[] text = { "Android", "Apple", "Samsung", "Huawei", "Sony" };
            entText.IsEnabled = true;
            textToEnter.Text = text[new Random().Next(0, text.Length)];
            gameConfirm.IsEnabled = true;

            //stopwatch timer starts
            mStopWatch.Start();
        }

        private void GameConfirm_Clicked(object sender, EventArgs e)
        {
            if (entText.Text == textToEnter.Text)
            {
                //if it is correct when confirm button is clicked, the timer stops 
                //the users time will be displayed if it is correct
                mStopWatch.Stop();
                double elapsed = (double)mStopWatch.ElapsedMilliseconds / 1000;
                time.Text = elapsed.ToString();
                mStopWatch.Reset();
                ifChecker.Text = "It is correct!";
                time.Text = "Time to enter string: "+time.Text+" seconds";
                gameConfirm.IsEnabled = false;
            }
            else
            {
                //timer does not stop if entry is incorrect
                ifChecker.Text = "It is not correct!";
            }

        }

        private void Game2Rules_Clicked(object sender, EventArgs e)
        {
            //this is to navigate to the second pages game rules
            Navigation.PushAsync(new Game2Rules());

        }

    }

}
