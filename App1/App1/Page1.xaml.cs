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

        int counter = 0;
        public Page1()
        {
            InitializeComponent();
            SetupDefaults();

        }

        private void SetupDefaults()
        {
            
            
        }

        private void ClickCounter_Clicked(object sender, EventArgs e)
        {
            //when the click counter main button is clicked, this will activate the timer
            counter++;
            
            
            label1.Text = "Times Clicked : " + counter;
        }
    }

}
