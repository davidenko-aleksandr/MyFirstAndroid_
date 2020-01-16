using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyFirstAndroid.Services
{
    public static class NavigationService
    {
        private static Application CurrentApplication
        {
            get { return Application.Current; }
        }

        public static async Task NavigateToAsync(Page page)
        {
            if (CurrentApplication.MainPage is NavigationPage navigationPage)
            {
                await navigationPage.Navigation.PushAsync(page);
            }
        }
    }
}
