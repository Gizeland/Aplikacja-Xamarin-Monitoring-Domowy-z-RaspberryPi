using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace loginCamera
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public static string playerUri;
        public MainPage()
        {
            InitializeComponent(); 
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            string login = string.Concat(Login.Text,":");
            string pass = string.Concat(Password.Text,"@");
            string url = tbUrl.Text;

            string uri = string.Concat("http://",login,pass,url);
            playerUri = uri;

            
            Application.Current.MainPage = new NavigationPage(new PlayerPage());

        }
        
    }

    
}
