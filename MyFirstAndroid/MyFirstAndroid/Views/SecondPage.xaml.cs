using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstAndroid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        private string _userEmail;
        public SecondPage(string userEmail)
        {
            InitializeComponent();

            _userEmail = userEmail;

            WelcomeTextShow();
            
        }

        private void WelcomeTextShow()
        {
            if (!string.IsNullOrWhiteSpace(_userEmail))
            {
                HiLoginLabel.Text = $"Добро пожаловать {_userEmail}";
            }
            else
            {
                HiLoginLabel.Text = "Введите логин";
            }
        }
        async void OnNexPageClicked(object sender, EventArgs args)
        {
            await Services.NavigationService.NavigateToAsync(new ThirdPage());
        }

    }
}