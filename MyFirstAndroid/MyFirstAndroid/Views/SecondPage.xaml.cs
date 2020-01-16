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
                HileLoginLabel.Text = $"Добро пожаловать {_userEmail}";
            }
            else
            {
                HileLoginLabel.Text = "Введите логин";
            }
        }
        
    }
}