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

namespace RMORRIS4Lab2BMI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private bool isMetric = false;
        logic calc = new logic();

        public MainPage()
        {
            this.InitializeComponent();
            stkpnlMetric.Visibility = Visibility.Collapsed;
        }

        private void HamburgerButton_Click(Object sender, RoutedEventArgs e)
        {
            MySplitview.IsPaneOpen = !MySplitview.IsPaneOpen; //make it opisote with not operator
        }
        
        private void btnImperial_Click(object sender, RoutedEventArgs e)
        {
            MySplitview.IsPaneOpen = !MySplitview.IsPaneOpen;
            isMetric = false;
            lblType.Text = "Imperial";
            stkpnlImperial.Visibility = Visibility.Visible;
            stkpnlMetric.Visibility = Visibility.Collapsed;
        }

        private void btnMetric_Click(object sender, RoutedEventArgs e)
        {
            MySplitview.IsPaneOpen = !MySplitview.IsPaneOpen;
            isMetric = true;
            lblType.Text = "Metric";
            stkpnlImperial.Visibility = Visibility.Collapsed;
            stkpnlMetric.Visibility = Visibility.Visible;
        }

        private void btnCalcImperial_Click(Object sender, RoutedEventArgs e)
        {
            try
            {
                txtResult.Text = calc.imperial(Convert.ToInt32(tbxImpHeight.Text), Convert.ToInt32(tbxImpWeight.Text));
            }
            catch
            {
                txtResult.Text = "Error; Check your numbers.";
            }
        }

        private void btnCalcMetric_Click(Object sender, RoutedEventArgs e)
        {
            try
            {
                txtResult.Text = calc.metric(Convert.ToInt32(tbxMetHeight.Text), Convert.ToInt32(tbxMetWeight.Text));
            }
            catch
            {
                txtResult.Text = "Error; Check your numbers.";
            }
        }
    }
}
