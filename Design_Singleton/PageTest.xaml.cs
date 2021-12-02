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
    public partial class PageTest : ContentPage
    {
        public PageTest()
        {
            InitializeComponent();
            wellcometext.Text = "Wellcome " + Singleton.Instance().getUsername();
        }
    }
}