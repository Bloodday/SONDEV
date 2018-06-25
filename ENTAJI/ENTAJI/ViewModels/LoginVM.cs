using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ENTAJI.Pages;
using Xamarin.Forms;

namespace ENTAJI.ViewModels
{
    public class LoginVm
    {
        public INavigation Navigation;
        public string UserName {set;get;}
        public string PassWord { set; get; }
        public ICommand LoginCommand { set; get; }
        public LoginVm()
        {
            LoginCommand = new Command(Login);
        }

        async void Login()
        {
            await Navigation.PushAsync(new Pages.MainPage());
        }
    }
}
