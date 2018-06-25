using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTAJI.ViewModels;
using Xamarin.Forms;

namespace ENTAJI.Pages
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
		    InitializeComponent();
		    var vm = (LoginVm) BindingContext;
		    vm.Navigation = Navigation;
        }
	}
}
