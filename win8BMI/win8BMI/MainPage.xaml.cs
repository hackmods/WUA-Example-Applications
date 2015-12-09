using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace RMORRISbmi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string type = "KG";
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        /// 
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double height = Convert.ToInt32(lblHeight.Text);
                double weight = Convert.ToInt32(lblWeight.Text);
                double bmi = 0;
                string msg = "";
                if (type == "KG")
                {
                    height = height / 100;
                    bmi = weight /(height * height);
                }
                else
                {
                    bmi = (weight / (height * height)) * 703;
                }

                //double comparison for decimal number
                double chk3 = 18.5;

                if (bmi < 15)
                    msg = "Very severely underweight";
                else if (bmi < 16)
                    msg = "Severely underweight";
                else if (bmi < chk3)
                    msg = "Underweight";
                else if (bmi < 25)
                    msg = "Normal (healthy weight)";
                else if (bmi < 30)
                    msg = "Overweight";
                else if (bmi < 35)
                    msg = "Obese Class I (Moderately obese)";
                else if (bmi < 40)
                    msg = "Obese Class II (Severely obese)";
                else
                    msg = "Obese Class III (Very severely obese)";

                txtResultString.Text = Convert.ToString(msg);
                txtResultNumber.Text = Convert.ToString(Math.Round(bmi, 2));
            }
            catch
            {
                txtResultString.Text = "Error. Check your input.";
                txtResultNumber.Text = "";
            }

        }

        private void rdoLBS_Checked(object sender, RoutedEventArgs e)
        {
            type = "LB";
            imperial();
        }

        private void rdoKGS_Checked(object sender, RoutedEventArgs e)
        {
            type = "KG";
            metric();

        }

        private void metric()
        {
            try
            {
                lblH.Text = "CM";
                lblW.Text = "KG";
            }
            catch
            {

            }
        }

        private void imperial()
        {
            try
            {
                lblH.Text = "IN";
                lblW.Text = "LB";
            }
            catch
            {

            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lblHeight.Text = "";
            lblWeight.Text = "";

            //not needed but seemed cleaner to wipe ui
            txtResultString.Text = "";
            txtResultNumber.Text = "";
        }
    }
}
