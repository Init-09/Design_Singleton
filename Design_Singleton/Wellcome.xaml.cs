using Design_Singleton.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Design_Singleton
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Wellcome : ContentPage
    {
        public Wellcome()
        {
            InitializeComponent();
            wellcometext.Text = "Wellcome " + Singleton.Instance().getUsername();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageTest());
        }
    }
}