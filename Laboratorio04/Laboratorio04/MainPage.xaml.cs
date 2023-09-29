using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Laboratorio04
{
   
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
              InitializeComponent();

                Item1.Clicked += async (sender , e) =>
            {

                await Navigation.PushAsync(new Page1());

                 

            }

        }
    }
}