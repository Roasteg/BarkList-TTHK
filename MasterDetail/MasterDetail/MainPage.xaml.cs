using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetail
{
    public partial class MainPage : MasterDetailPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            aboutList.ItemsSource = GetMenuList();
            var homePage = typeof(Views.Dog);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }

        public List<MasterMenuItems> GetMenuList()  
        {
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text = "Вельш Корги",
                Detail = "О собаке...",
                ImagePath = "korgi.jpg",
                TargetPage = typeof(Views.Dog)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Лайка",
                Detail = "О собаке...",
                ImagePath = "eskimo.jpg",
                TargetPage = typeof(Views.dog1)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Немецкая овчарка",
                Detail = "О собаке...",
                ImagePath = "shepherd.jpg",
                TargetPage = typeof(Views.Dog2)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Золотистый ретривер",
                Detail = "О собаке...",
                ImagePath = "gold.jpg",
                TargetPage = typeof(Views.Dog3)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Гончая",
                Detail = "О собаке...",
                ImagePath = "hound.jpg",
                TargetPage = typeof(Views.Dog4)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Мопс",
                Detail = "О собаке...",
                ImagePath = "mops.jpg",
                TargetPage = typeof(Views.Dog5)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Такса",
                Detail = "О собаке...",
                ImagePath = "dachund.jpg",
                TargetPage = typeof(Views.Dog6)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Хаски",
                Detail = "О собаке...",
                ImagePath = "husky.jpg",
                TargetPage = typeof(Views.Dog7)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Сиба-Ину",
                Detail = "О собаке...",
                ImagePath = "shibe.jpg",
                TargetPage = typeof(Views.Dog8)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Спаниель",
                Detail = "О собаке...",
                ImagePath = "springer.jpg",
                TargetPage = typeof(Views.Dog9)
            });
            return list;
        }
        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItemMenu = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = selectedItemMenu.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
        }
    }
}
