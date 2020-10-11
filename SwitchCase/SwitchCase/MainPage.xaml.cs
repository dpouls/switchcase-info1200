using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwitchCase
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// we will make sure a fruit was selected then assign the selected fruit to a value called FRUIT_CASE, then use that as our input in the switch-case statement to determine how we want to display the results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDetails_Clicked(object sender, EventArgs e)
        {
            
            //if an option is selected it's index will be 0 or more, if not it will not pass and we display the alert
            if (PckFruit.SelectedIndex > -1)
            {
                //assign the selected fruit to our FRUIT CASE VARIABLE after converting the object to a string
            string FRUIT_CASE = PckFruit.SelectedItem.ToString();
            switch (FRUIT_CASE)
            {
                //if it's an apple we will change the color, type and price accordingly
                case "Apple":
                    lblColor.Text = "Red";
                    lblPlantType.Text = "Tree";
                    lblPrice.Text = 1.99m.ToString("c");
                    break;
                case "Canteloupe":
                    //if it's a canteloupe we will change the color, type and price accordingly
                    lblColor.Text = "Orange";
                    lblPlantType.Text = "Vine";
                    lblPrice.Text = 1.50m.ToString("c");
                    break;
                case "Watermelon":
                    //if it's a watermelon we will change the color, type and price accordingly
                    lblColor.Text = "Green and Red";
                    lblPlantType.Text = "Vine";
                    lblPrice.Text = 3.50m.ToString("c");
                    break;
                case "Peach":
                    //if it's a peach we will change the color, type and price accordingly
                    lblColor.Text = "Orange and Red";
                    lblPlantType.Text = "Tree";
                    lblPrice.Text = 0.60m.ToString("c");
                    break;
                default:
                        //display alert if for whatever reason the case doesn't match any of the cases
                    DisplayAlert("Uh-oh!", "Please select an option and try again!", "Close");
                    break;

            }

            }
            else
            {
                //display alert when no option was selected 
                DisplayAlert("Invalid input.", "Please select an option from the drop-menu.", "Close");
            }

        }
        /// <summary>
        /// reset all the fields to starting values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            //reset picker to no value
                PckFruit.SelectedIndex= -1;
            //reset each text value to "Results..." again
                lblColor.Text = "Results...";
                lblPlantType.Text = "Results...";
                lblPrice.Text = "Results...";
        }
    }
}
