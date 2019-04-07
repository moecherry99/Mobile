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

                //this simply sets all of the values on the page back to what they
                //were before the Start Game 1 button was pressed
                counter = 0;
                label1.Text = "Times Clicked : " + counter;
                label2.Text = "";
            }

            private void ClickCounter_Clicked(object sender, EventArgs e)
            {
                //when the click counter main button is clicked, this will activate the timer
                counter++;

            
          
            
            
                label1.Text = "Times Clicked : " + counter;

                if (counter == 20)
                {
                
                    clickCounter.IsEnabled = false;
                
                    label2.Text = "You Clicked the button " + counter + " times in 10 seconds";



                }
            }

       
        }

    }
