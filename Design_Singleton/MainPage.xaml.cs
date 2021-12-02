using Design_Singleton.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Design_Singleton
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Singleton.Instance().setUsername(editUsername.Text.ToString());
            await Navigation.PushAsync(new Wellcome());
        }
    }
}