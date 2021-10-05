using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible (false)]
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        
        // Increment the count whenever there is an onclick event.
        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";
        }
    }
}
