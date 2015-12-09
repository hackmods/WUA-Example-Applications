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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RMORRIS4Test1WUA
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private bool isAbout = false;

        public MainPage()
        {
            this.InitializeComponent();
            stkpnAbout.Visibility = Visibility.Collapsed;
        }

        private void HamburgerButton_Click(Object sender, RoutedEventArgs e)
        {
            MySplitview.IsPaneOpen = !MySplitview.IsPaneOpen; //make it opisote with not operator
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            MySplitview.IsPaneOpen = !MySplitview.IsPaneOpen;
            isAbout = false;
            lblType.Text = "Convert";
            stkpnCalc.Visibility = Visibility.Visible;
            stkpnAbout.Visibility = Visibility.Collapsed;
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            MySplitview.IsPaneOpen = !MySplitview.IsPaneOpen;
            isAbout = true;
            lblType.Text = "About";
            stkpnCalc.Visibility = Visibility.Collapsed;
            stkpnAbout.Visibility = Visibility.Visible;
        }

        private void btnCalcTemp_Click(Object sender, RoutedEventArgs e)
        {
            String error = "";
            
            try
            {
                Double temp = 0;
                String unit = "c";
                String result = "";

                //get temp
                try
                {
                    temp = Convert.ToDouble(tbxImpTemp.Text);

                    //unit cases
                    if (rdoC.IsChecked == true)
                    {
                        if (temp <= -273.15)
                        {
                            error += "Please entera warmer tempurature";
                            txtResult.Text = error;
                        }
                        else
                        {
                            result += "C = " + temp + "  ";
                            result += "F = " + tempConv.CtoF(temp) + "  ";
                            result += "K = " + tempConv.CtoK(temp) + "  ";
                            txtResult.Text = result;
                        }
                    }

                    else if (rdoF.IsChecked == true)
                    {
                        if (temp <= -459.67)
                        {
                            error += "Please entera warmer tempurature";
                            txtResult.Text = error;
                        }
                        else
                        {
                            result += "C = " + tempConv.FtoC(temp) + "  ";
                            result += "F = " + temp + " ";
                            result += "K = " + tempConv.FtoK(temp) + "  ";
                            txtResult.Text = result;
                        }
                    }

                    else if (rdoK.IsChecked == true)
                    {
                        if (temp <= 0)
                        {
                            error += "Please enter a warmer temperature";
                            txtResult.Text = error;
                        }
                        else
                        {
                            result += "C = " + tempConv.KtoC(temp) + "  ";
                            result += "F = " + tempConv.KtoF(temp) + "  ";
                            result += "K = " + temp + "  ";
                            txtResult.Text = result;
                        }
                    }
                }
                catch
                {
                    error += "Could not convert temp val to double \n";
                    txtResult.Text = error;
                }         
            }
            catch
            {
                txtResult.Text = "Error" + error;
            }
        }
    }
}

