using System;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        bool bW, bH;

        public MainPage()
        {
            InitializeComponent();
            SetupDefaults();

        }

        private void SetupDefaults()
        {
            //ctrl + . generate method
            bW = false;
            bH = false;
            btnBodyFatPage.IsEnabled = false;
            GamePage2.IsEnabled = false;
            GamePage3.IsEnabled = false;
            //show image on screen, chart.png


            //var assembly = typeof(MainPage);
            //string fileName = "App1.Assets.Images.chart.png";
            //chart.Source = ImageSource.FromResource(fileName, assembly);
        }

        private void btnCalculate_Clicked(object sender, EventArgs e)
        {
            //this is to enable all the buttons after entering the info necessary
            string bmi;
            bmi = entHeight.Text;
            lblAnswer.Text = "Hello " + bmi + "!";
            btnBodyFatPage.IsEnabled = true;
            GamePage2.IsEnabled = true;
            GamePage3.IsEnabled = true;
        }

        private void btnBodyFatPage_Clicked(object sender, EventArgs e)
        {
            //this is to navigate to the first game page

            Navigation.PushAsync(new Page1());
        }

        private void GamePage2_Clicked(object sender, EventArgs e)
        {
            //this is to navigate to the second game page
            Navigation.PushAsync(new Page2());

        }

        private void GamePage3_Clicked(object sender, EventArgs e)
        {
            //this is to navigate to the third game page
            Navigation.PushAsync(new Page3());

        }

        private void entWeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            //check entry boxes are full
            if (entWeight.Text == "")
            {
                btnCalculate.IsEnabled = false;
                lblAnswer.Text = "Hello : ";
                bW = false;

            }
            else
            {
                bW = true;

            }

            //check other bool

            if (bW == true)

            {
                if (bH == true) btnCalculate.IsEnabled = true;

            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            ResetFieldsGeneral();
        }

        private void ResetFieldsGeneral()
        {
            //if values are taken out of the text boxes, the buttons do not stay active
            bW = bH = false;
            entHeight.Text = "";
            entWeight.Text = "";
            btnCalculate.IsEnabled = false;
        }



        private void entHeight_TextChanged(object sender, TextChangedEventArgs e)
        {

            //check entry boxes are full
            if (entHeight.Text == "")
            {
                btnCalculate.IsEnabled = false;
                lblAnswer.Text = "Hello : ";
                bH = false;

            }
            else
            {
                bH = true;

            }

            //check other bool

            if (bH == true)

            {
                if (bW == true) btnCalculate.IsEnabled = true;

            }


        }
    }




}
