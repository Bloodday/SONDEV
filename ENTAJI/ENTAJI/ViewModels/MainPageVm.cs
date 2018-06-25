using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ENTAJI.ViewModels
{
    public class MainPageVm
    {
        public class Item
        {
            public string Name { set; get; }
            public string Description { set; get; }
            public ImageSource Image { set; get; }
        }
       
        public ObservableCollection<Item> Restaurants { set; get; }
        public ObservableCollection<Item> Stores { set; get; }
        public ObservableCollection<Item> Services { set; get; }

        public MainPageVm()
        {
            GenerateContent();
        }

        private void GenerateContent()
        {
            string[] restaurantNames = new string[]
            {
                "Restaurant 1",
                "Restaurant 2",
                "Restaurant 3",
                "Restaurant 4",
                "Restaurant 5"
            };
            string[] restaurantCategories = new string[]
            {
                "Description 5",
                "Description 4",
                "Description 3",
                "Description 2",
                "Description 1",
            };

            Restaurants = new ObservableCollection<Item>();
            for (int i=0;i<restaurantNames.Length;i++)
            {
                var restaurant = new Item
                {
                    Name = restaurantNames[i],
                    Description = restaurantCategories[i],
                    Image = ImageSource.FromResource("ENTAJI.DummyContent.Images." + restaurantNames[i] + ".jpg")
                };
                //var iimage = ImageSource.FromResource("ENTAJI.DummyContent.Images." + restaurantNames[i] + ".jpg");
                Restaurants.Add(restaurant);
            }
        }
    }

    
}
