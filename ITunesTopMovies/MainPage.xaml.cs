using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITunesTopMovies.Data;
using Xamarin.Forms;

namespace ITunesTopMovies
{
    public partial class MainPage : ContentPage
    {
        private OpenDataManager odManager = new OpenDataManager();
        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            OpenDataItem itemCollection = await odManager.GetAll();
            ITunesListview.ItemsSource = itemCollection.feed.entry;
        }
    }
}
