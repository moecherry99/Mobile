using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class Page1 : ContentPage
    {

        private System.Timers.Timer buttonTimer;
        int timer = 0;

        int counter = 0;

        public Page1()
        {
            InitializeComponent();
            SetupDefaults();


        }

        private void SetupDefaults()
        {


        }
        private void Game1Starter_Clicked(object sender, EventArgs e)
        {
            clickCounter.IsEnabled = true;
            game1Starter.IsEnabled = false;

            //this simply sets all of the values on the page back to what they
            //were before the Start Game 1 button was pressed
            counter = 0;
            label1.Text = "Times Clicked : " + counter;
            label2.Text = "";



            //this means when the game1 starter button is clicked, a timer for 10 seconds initiates.
            Device.StartTimer(new TimeSpan(0, 0, 10), Timer);

        }
        private bool Timer()
        {
            label2.Text = "You Clicked the button " + counter + " times in 10 seconds";
            clickCounter.IsEnabled = false;
            game1Starter.IsEnabled = false;
            return true;
            //after 10 seconds, the button for click counter becomes unclickable.
        }
        

        private void ClickCounter_Clicked(object sender, EventArgs e)
        {
            
            //when the click counter main button is clicked, this will activate the timer
            counter++;

            label1.Text = "Times Clicked : " + counter;
           
            /*
            if (counter == 20)
            {
                //if you click 20 times, the button disables itself and displays how long it took you
                //you to click 20 times.

                clickCounter.IsEnabled = false;
                label2.Text = "You Clicked the button " + counter + " times in 10 seconds";

            }
            */
            
        }
        

        private void homePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }

}
