using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTAJI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TabbedPage = Xamarin.Forms.TabbedPage;

namespace ENTAJI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage ()
        {
            InitializeComponent();
            MainPageVm vm = (MainPageVm) BindingContext;
            RestaurantsListView.ItemsSource = vm.Restaurants;
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Black;
        }
    }
}