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

        //sets counter to 0
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

            //make buttons clickable or not
            clickCounter.IsEnabled = true;
            game1Starter.IsEnabled = false;

            //this simply sets all of the values on the page back to what they
            //were before the Start Game 1 button was pressed
            counter = 0;
            label1.Text = "Times Clicked : " + counter;
            label2.Text = "";

            //this means when the game1 starter button is clicked, a timer for 5 seconds initiates.
            Device.StartTimer(new TimeSpan(0, 0, 5), Timer);

        }
        private bool Timer()
        {
            double division;
            division = counter / 5;
            label2.Text = "You Clicked the button " + counter + " times in 5 seconds";
            label3.Text = "That's approximately "+ division +" times per second!";
            clickCounter.IsEnabled = false;
            game1Starter.IsEnabled = true;
            return true;
            //after 10 seconds, the button for click counter becomes unclickable.

        }
        

        private void ClickCounter_Clicked(object sender, EventArgs e)
        {
            
            //when the click counter main button is clicked, this will activate the timer
            counter++;
            label1.Text = "Times Clicked : " + counter;
      
        }

        private void Game1Rules_Clicked(object sender, EventArgs e)
        {
            //this is to navigate to the first games rule page
            Navigation.PushAsync(new Game1Rules());

        }
    }

}
