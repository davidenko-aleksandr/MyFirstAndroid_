using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyFirstAndroid
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void OnShowPassword(object sender, EventArgs args)
        {
            PasswordEntry.IsPassword = !PasswordEntry.IsPassword;
            if (PasswordEntry.IsPassword == true)
            {
                PasswordButton.Text = "*";
            }
            else
            {
                PasswordButton.Text = "%";
            }
        }
        void OnRegistClicked(object sender, EventArgs args)
        {
            Device.OpenUri(new Uri("http://htmlbook.ru/practical/forma-registratsii"));

        }
    }
}
