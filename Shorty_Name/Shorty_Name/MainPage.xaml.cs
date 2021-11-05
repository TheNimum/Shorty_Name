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
        public void OnClicked(object sender, EventArgs args)
        {
            Console.WriteLine("Test if work");
            Label addtoList = new Label();
            addtoList.Text = Fname.Text + " "  +Lname.Text;
            ResultList.Children.Add(addtoList);
        }

        private void OnClickedClear(object sender, EventArgs e)
        {
            ResultList.Children.Clear();
        }
    }
}
