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
                Text = "Minust",
                Detail = "Lühike info",
                TargetPage = typeof(Views.Dog)
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
