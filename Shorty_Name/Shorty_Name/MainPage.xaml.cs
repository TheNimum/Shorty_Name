using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Shorty_Name
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void OnClicked(object sender , EventArgs args)
        {
            Console.WriteLine("Test if work");
        }

        public void NameChange(object sender, TextChangedEventArgs e)
        {

        }

        public void LastNameChange(object sender, TextChangedEventArgs e)
        {

        }
    }
}
